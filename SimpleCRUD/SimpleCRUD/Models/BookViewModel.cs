using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleCRUD.Models
{
	public class BookViewModel
	{
		public decimal BookId { get; set; }
		public string BookTitle { get; set; }
		public string BookAuthor { get; set; }
		public Nullable<decimal> BookQuantity { get; set; }

		public List<BookViewModel> lstBook { get; set; }

		public List<BookViewModel> GetBookDetails()
		{
			using (var db = new BookEntities())
			{
				var getBookData = db.tblBook.ToList();
				var list = new List<BookViewModel>();

				if(getBookData.Count > 0)
				{
					foreach(var data in getBookData)
					{
						var lst = new BookViewModel();
						lst.BookId = data.BookId;
						lst.BookTitle = data.BookTitle;
						lst.BookAuthor = data.BookAuthor;
						lst.BookQuantity = data.BookQuantity;
						list.Add(lst);
					}
				}
				return list;
			}
				
		}
	}
}