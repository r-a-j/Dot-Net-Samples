using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookInsertOperation.Models
{
	public class BookModel
	{
		public int BookId { get; set; }
		public string BookTitle { get; set; }
		public string BookAuthor { get; set; }
		public Nullable<int> BookQuantity { get; set; }
	}
}