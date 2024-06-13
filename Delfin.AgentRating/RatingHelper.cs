using AgentRating3;
using ServiceStack.Text;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows;
using System.Xml;
using Yandex.Geocoding;

namespace Delfin.AgentRating
{
	public class RatingHelper
	{
		public List<int> SpecialPartnerId = new List<int>()
		{
			19050,
			14986,
			5218
		};

		private AvalonDbDataContext db = new AvalonDbDataContext();

		public RatingHelper()
		{
		}

		public static Point Geocode(string name)
		{
			Point point;
			if (!string.IsNullOrEmpty(name))
			{
				XmlDocument xmlDocument = (new Geocoding()).Get(name);
				Thread.Sleep(100);
				XmlNamespaceManager xmlNamespaceManagers = new XmlNamespaceManager(xmlDocument.NameTable);
				xmlNamespaceManagers.AddNamespace("ym", "http://maps.yandex.ru/ymaps/1.x");
				xmlNamespaceManagers.AddNamespace("gml", "http://www.opengis.net/gml");
				XmlNode xmlNodes = xmlDocument.SelectSingleNode("//ym:GeoObject", xmlNamespaceManagers);
				CultureInfo cultureInfo = CultureInfo.GetCultureInfo("en-US");
				if (xmlNodes == null)
				{
					point = new Point(-1000, -1000);
				}
				else
				{
					string[] strArrays = (xmlNodes.SelectSingleNode("gml:Point/gml:pos", xmlNamespaceManagers).InnerText ?? "").Split(new char[] { ' ' });
					point = new Point(Convert.ToDouble(strArrays[0], cultureInfo.NumberFormat), Convert.ToDouble(strArrays[1], cultureInfo.NumberFormat));
				}
			}
			else
			{
				point = new Point(-1000, -1000);
			}
			return point;
		}

		private Dictionary<string, Point> GetCoordFromMap(string map)
		{
			Dictionary<string, Point> strs = new Dictionary<string, Point>();
			WebClient webClient = new WebClient();
			webClient.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 6.1; rv:13.0) Gecko/20100101 Firefox/13.0.1";
			webClient.Encoding = Encoding.UTF8;
			string str = webClient.DownloadString(string.Concat("http://maps.yandex.ru/export/usermaps/", map));
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(str);
			XmlNamespaceManager xmlNamespaceManagers = new XmlNamespaceManager(xmlDocument.NameTable);
			xmlNamespaceManagers.AddNamespace("ym", "http://maps.yandex.ru/ymaps/1.x");
			xmlNamespaceManagers.AddNamespace("gml", "http://www.opengis.net/gml");
			CultureInfo cultureInfo = CultureInfo.GetCultureInfo("en-US");
			foreach (XmlNode xmlNodes in xmlDocument.DocumentElement.SelectNodes("//ym:GeoObject", xmlNamespaceManagers))
			{
				string str1 = xmlNodes.SelectSingleNode("gml:name", xmlNamespaceManagers).InnerText.Trim();
				int num = 0;
				if (xmlNodes.SelectSingleNode("gml:description", xmlNamespaceManagers) != null)
				{
					num = (int.TryParse(xmlNodes.SelectSingleNode("gml:description", xmlNamespaceManagers).InnerText.Trim(), out num) ? num : 0);
				}
				Point point = new Point(-1000, -1000);
				string[] strArrays = (xmlNodes.SelectSingleNode("gml:Point/gml:pos", xmlNamespaceManagers).InnerText ?? "").Split(new char[] { ' ' });
				if ((int)strArrays.Length > 1)
				{
					point.X = (double)((float)Convert.ToDouble(strArrays[0], cultureInfo.NumberFormat));
					point.Y = (double)((float)Convert.ToDouble(strArrays[1], cultureInfo.NumberFormat));
				}
				strs[string.Concat(str1, "+", num)] = point;
			}
			return strs;
		}

		private Dictionary<string, YandexUserMap> GetMapUrlList()
		{
			string str = "http://maps.yandex.ru/users/agents-maps/?skip={0}&output=json";
			Dictionary<string, YandexUserMap> strs = new Dictionary<string, YandexUserMap>();
			WebClient webClient = new WebClient();
			webClient.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 6.1; rv:13.0) Gecko/20100101 Firefox/13.0.1";
			webClient.Encoding = Encoding.UTF8;
			int num = 0;
			while (true)
			{
				string str1 = webClient.DownloadString(string.Format(str, num));
				List<YandexUserMap> yandexUserMaps = JsonObject.Parse(str1).Object("vpage").Object("data").Object("mapList").ArrayObjects("maps").ConvertAll<YandexUserMap>((JsonObject x) => new YandexUserMap()
				{
					Name = JsonExtensions.Get(x, "name"),
					Id = JsonExtensions.Get(x, "id")
				});
				foreach (YandexUserMap yandexUserMap in yandexUserMaps)
				{
					yandexUserMap.PublicMap = yandexUserMap.Name.Contains("(народная)");
					yandexUserMap.Name = yandexUserMap.Name.Replace("(народная)", "").Trim();
					strs[yandexUserMap.Name] = yandexUserMap;
				}
				if (yandexUserMaps.Count == 0)
				{
					break;
				}
				num += 10;
			}
			return strs;
		}

		public List<PartnerInfo> GetPartnerList()
		{
			List<PartnerInfo> list = (
				from p in this.db.tbl_Partners
				join c in this.db.CityDictionaries on p.PR_CTKEY equals (int?)c.CT_KEY
				select new PartnerInfo()
				{
					Id = p.PR_KEY,
					Name = p.PR_NAME,
					Address = p.PR_ADRESS,
					Phones = p.PR_PHONES,
					Web = p.PR_HOMEPAGE,
					City = c.CT_NAME
				}).ToList<PartnerInfo>();
			foreach (PartnerInfo partnerInfo in list)
			{
				string str = partnerInfo.Name.Replace("~", "");
				int num = str.IndexOf('*');
				if (num >= 0)
				{
					int num1 = str.LastIndexOf('*');
					str = str.Remove(num, num1 - num + 1);
				}
				partnerInfo.Name = str.Trim();
			}
			return list;
		}

		public Rating GetRating(DateTime from1, DateTime to1, DateTime from2, DateTime to2, PartnerSaleType saleType)
		{
			Dictionary<int, PartnerInfo> dictionary = this.GetPartnerList().ToDictionary<PartnerInfo, int>((PartnerInfo x) => x.Id);
			List<int> list = (
				from a in this.db.PrtTypesToPartners
				where a.PTP_PTId == 1061
				select a.PTP_PRKey).ToList<int>();
			foreach (int num in list)
			{
				dictionary.Remove(num);
			}
			List<PartnerSale> sales = this.GetSales(dictionary, from1, to1, saleType);
			List<PartnerSale> partnerSales = this.GetSales(dictionary, from2, to2, saleType);
			Rating rating = new Rating();
			rating.Calculate(sales, partnerSales);
			return rating;
		}

		public List<PartnerSale> GetSales(Dictionary<int, PartnerInfo> partners, DateTime date1, DateTime date2, PartnerSaleType saleType)
		{
			IQueryable<PartnerSale> tblDogovors = 
				from d in this.db.tbl_Dogovors
				where !this.SpecialPartnerId.Contains((int)d.DG_PARTNERKEY) && d.DG_PARTNERKEY > (int?)0 && d.DG_PRICE > new decimal(0) && (d.DG_CRDATE >= date1) && (d.DG_CRDATE <= date2)
				group d by new { DG_PARTNERKEY = d.DG_PARTNERKEY } into d_group
				select new PartnerSale()
				{
					Id = (int)d_group.Key.DG_PARTNERKEY,
					AllSum = d_group.Sum<tbl_Dogovor>((tbl_Dogovor x) => x.DG_PRICE),
					AllMen = (int)d_group.Sum<tbl_Dogovor>((tbl_Dogovor x) => (int?)x.DG_NMEN)
				};
			tblDogovors = (saleType == PartnerSaleType.BySum ? 
				from x in tblDogovors
				orderby x.AllSum descending
				select x : 
				from x in tblDogovors
				orderby x.AllMen descending
				select x);
			List<PartnerSale> list = tblDogovors.ToList<PartnerSale>();
			PartnerSale partnerSale = new PartnerSale()
			{
				Id = 19050,
				AllSum = new decimal(999999999),
				AllMen = 99999999
			};
			list.Insert(0, partnerSale);
			PartnerSale partnerSale1 = new PartnerSale()
			{
				Id = 14986,
				AllSum = new decimal(999999999),
				AllMen = 99999999
			};
			list.Insert(0, partnerSale1);
			PartnerSale partnerSale2 = new PartnerSale()
			{
				Id = 5218,
				AllSum = new decimal(999999999),
				AllMen = 99999999
			};
			list.Insert(0, partnerSale2);
			list.ForEach((PartnerSale x) => {
				if (partners.ContainsKey(x.Id))
				{
					x.Partner = partners[x.Id];
				}
			});
			list.RemoveAll((PartnerSale x) => x.Partner == null);
			return list;
		}

		public void InsertCoords(Rating rating)
		{
			Dictionary<string, YandexUserMap> mapUrlList = this.GetMapUrlList();
			Dictionary<string, Point> strs = new Dictionary<string, Point>();
			foreach (Rating.City city in rating.Cities)
			{
				strs = (!mapUrlList.ContainsKey(city.Name) ? new Dictionary<string, Point>() : this.GetCoordFromMap(mapUrlList[city.Name].Id));
				foreach (Rating.Place place in city.Places)
				{
					if (strs.ContainsKey(string.Concat(place.Partner.Name, "+", place.Partner.Id)))
					{
						place.Partner.Coord = strs[string.Concat(place.Partner.Name, "+", place.Partner.Id)];
					}
					else if (!strs.ContainsKey(string.Concat(place.Partner.Name, "+0")))
					{
						place.Partner.Coord = RatingHelper.Geocode(place.Partner.Address);
					}
					else
					{
						place.Partner.Coord = strs[string.Concat(place.Partner.Name, "+0")];
					}
				}
			}
		}
	}
}