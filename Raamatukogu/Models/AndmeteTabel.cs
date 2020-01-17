using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamatukogu.Models
{
	public class AndmeteTabel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Author { get; set; }
		public string rentalCube  {get; set;}
		public string TheLengthOfTheLoan { get; set; }
		public string availability { get; set; }
	}
}