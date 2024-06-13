using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Xml.Serialization;

namespace Delfin.AgentRating
{
	public class PartnerInfo
	{
		[XmlAttribute("address")]
		public string Address
		{
			get;
			set;
		}

		[XmlAttribute("city")]
		public string City
		{
			get;
			set;
		}

		[XmlElement("coord")]
		public Point Coord
		{
			get;
			set;
		}

		[XmlAttribute("id")]
		public int Id
		{
			get;
			set;
		}

		[XmlAttribute("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlAttribute("phones")]
		public string Phones
		{
			get;
			set;
		}

		[XmlAttribute("web")]
		public string Web
		{
			get;
			set;
		}

		public PartnerInfo()
		{
		}
	}
}