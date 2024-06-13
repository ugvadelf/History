using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

namespace Yandex.Geocoding
{
	public class Geocoding
	{
		private string geocoderUrl = "http://geocode-maps.yandex.ru/1.x/?";

		public Yandex.Geocoding.Format Format
		{
			get;
			set;
		}

		public string Geocode
		{
			get;
			set;
		}

		public string Key
		{
			get;
			set;
		}

		public Yandex.Geocoding.Kind Kind
		{
			get;
			set;
		}

		public Yandex.Geocoding.Language Language
		{
			get;
			set;
		}

		public int Results
		{
			get;
			set;
		}

		public int Skip
		{
			get;
			set;
		}

		public Geocoding()
		{
			this.Format = Yandex.Geocoding.Format.Xml;
			this.Results = 10;
			this.Skip = 0;
			this.Language = Yandex.Geocoding.Language.ru_RU;
			this.Key = string.Empty;
		}

		public XmlDocument Get(string geocode)
		{
			this.Geocode = geocode;
			XmlDocument xmlDocument = new XmlDocument();
			WebClient webClient = new WebClient();
			webClient.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 6.1; rv:13.0) Gecko/20100101 Firefox/13.0.1";
			webClient.Encoding = Encoding.UTF8;
			StringBuilder stringBuilder = new StringBuilder(this.geocoderUrl);
			object[] objArray = new object[] { Uri.EscapeUriString(this.Geocode), this.Format.ToString().ToLower(), this.Results, this.Skip, this.Language.ToString().Replace("_", "-") };
			stringBuilder.AppendFormat("geocode={0}&format={1}&results={2}&skip={3}&lang={4}", objArray);
			byte[] numArray = webClient.DownloadData(stringBuilder.ToString());
			xmlDocument.Load(new MemoryStream(numArray));
			return xmlDocument;
		}
	}
}