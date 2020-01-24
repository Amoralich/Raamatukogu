using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamatukogu.Models
{
	public class RaamatuLisamine
	{
		public int Id { get; set; }
		public string nimi { get; set; }
		public string autor { get; set; }
		public string LaenuPikkus { get; set; }
	}
}