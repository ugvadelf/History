using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Delfin.AgentRating
{
	public class Rating
	{
		[XmlElement("city")]
		public List<Rating.City> Cities
		{
			get;
			set;
		}

		[XmlAttribute("showphones")]
		public int ShowPhones
		{
			get;
			set;
		}

		public Rating()
		{
		}

		public void Calculate(List<PartnerSale> currentSale, List<PartnerSale> lastSale)
		{
			//PartnerSale partnerSale = null;
			IOrderedEnumerable<string> strs = 
				from x in (
					from x in currentSale
					select x.Partner.City).Distinct<string>()
				orderby x
				select x;
			this.Cities = new List<Rating.City>();
			foreach (string str in strs)
			{
				int num = 1;
				IEnumerable<PartnerSale> partnerSales = 
					from x in currentSale
					where x.Partner.City == str
					select x;
				foreach (PartnerSale partnerSale in partnerSales)
				{
					int num1 = num;
					num = num1 + 1;
					partnerSale.No = num1;
				}
				Dictionary<int, PartnerSale> nums = new Dictionary<int, PartnerSale>();
				num = 1;
				foreach (PartnerSale partnerSale1 in 
					from x in lastSale
					where x.Partner.City == str
					select x)
				{
					int num2 = num;
					num = num2 + 1;
					partnerSale1.No = num2;
					nums.Add(partnerSale1.Id, partnerSale1);
				}
				Rating.City city = new Rating.City()
				{
					Name = str
				};
				this.Cities.Add(city);
				foreach (PartnerSale partnerSale2 in partnerSales)
				{
					List<Rating.Place> places = city.Places;
					Rating.Place place = new Rating.Place()
					{
						Partner = partnerSale2.Partner,
						No = partnerSale2.No,
						Shift = (nums.ContainsKey(partnerSale2.Id) ? nums[partnerSale2.Id].No - partnerSale2.No : 0),
						Medal = Rating.Medal.NoMedal
					};
					places.Add(place);
				}
				int num3 = partnerSales.Count<PartnerSale>();
				int num4 = 1;
				int num5 = 1;
				int num6 = 1;
				int num7 = Convert.ToInt32(Math.Floor(0.05 * (double)num3));
				num4 = (num7 == 0 ? 1 : num7);
				num7 = Convert.ToInt32(Math.Floor(0.2 * (double)num3));
				num5 = (num7 == 0 ? 1 : num7);
				num7 = Convert.ToInt32(Math.Floor(0.55 * (double)num3)) - num4 - num5;
				num6 = (num7 <= 0 ? 1 : num7);
				num = 0;
				int num8 = 0;
				while (true)
				{
					if ((num >= num3 ? true : num8 >= num4))
					{
						break;
					}
					city.Places[num].Medal = Rating.Medal.Gold;
					num++;
					num8++;
				}
				num8 = 0;
				while (true)
				{
					if ((num >= num3 ? true : num8 >= num5))
					{
						break;
					}
					city.Places[num].Medal = Rating.Medal.Silver;
					num++;
					num8++;
				}
				num8 = 0;
				while (true)
				{
					if ((num >= num3 ? true : num8 >= num6))
					{
						break;
					}
					city.Places[num].Medal = Rating.Medal.Bronze;
					num++;
					num8++;
				}
			}
		}

		[XmlRoot("cities")]
		public class City
		{
			[XmlAttribute("name")]
			public string Name
			{
				get;
				set;
			}

			[XmlElement("place")]
			public List<Rating.Place> Places
			{
				get;
				set;
			}

			public City()
			{
				this.Places = new List<Rating.Place>();
			}
		}

		public enum Medal
		{
			Gold,
			Silver,
			Bronze,
			NoMedal
		}

		[XmlRoot("places")]
		public class Place
		{
			[XmlAttribute("medal")]
			public Rating.Medal Medal
			{
				get;
				set;
			}

			[XmlAttribute("no")]
			public int No
			{
				get;
				set;
			}

			[XmlElement("partner")]
			public PartnerInfo Partner
			{
				get;
				set;
			}

			[XmlAttribute("shift")]
			public int Shift
			{
				get;
				set;
			}

			public Place()
			{
			}
		}
	}
}