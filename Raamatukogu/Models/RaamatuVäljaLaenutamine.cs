using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamatukogu.Models
{
	public class RaamatuVäljaLaenutamine
	{
		public int iD { get; set; }
		public string UleNadalaVeel { get; set; }
		public string KuniNadalVeel { get; set; }
		public string UletanudTahtaeg { get; set; }
	}
}