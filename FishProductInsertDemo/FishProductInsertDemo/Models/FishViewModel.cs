using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FishProductInsertDemo.Models
{
	public class FishViewModel
	{
		public decimal FishId { get; set; }
		public string FishName { get; set; }
		public string FishType { get; set; }
		public string FishQuantity { get; set; }
	}
}