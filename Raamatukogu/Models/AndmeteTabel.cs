using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamatukogu.Models
{
	public class AndmeteTabel
	{
		public int Id { get; set; }
		public string Nimi { get; set; }
		public string Autor { get; set; }
		public string laenutusKuupaev  {get; set;}
		public string laenuPikkus { get; set; }
		public string saadavus { get; set; }
	}
}