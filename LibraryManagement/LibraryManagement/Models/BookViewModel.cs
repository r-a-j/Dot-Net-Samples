using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.Models
{
	public class BookViewModel
	{
		public decimal BookId { get; set; }
		public string BookTitle { get; set; }
		public string BookAuthor { get; set; }
		public Nullable<decimal> BookQuantity { get; set; }

		public List<BookViewModel> lstBook { get; set; }

		public List<BookViewModel> GetBookList()
		{
			using (BookEntities db = new BookEntities())
			{
				var BookData = db.tblBook.ToList();
				var list = new List<BookViewModel>();

				if (BookData.Count > 0)
				{
					foreach (var item in BookData)
					{
						var lst = new BookViewModel();
						lst.BookId = item.BookId;
						lst.BookTitle = item.BookTitle;
						lst.BookAuthor = item.BookAuthor;
						lst.BookQuantity = item.BookQuantity;
						list.Add(lst);
					}
				}
				return list;
			}
		}

		// Adding book details to database
		public void AddBookToDatabase(BookViewModel model)
		{
			using (BookEntities db = new BookEntities())
			{
				tblBook data = new tblBook();
				data.BookTitle = model.BookTitle;
				data.BookAuthor = model.BookAuthor;
				data.BookQuantity = model.BookQuantity;
				db.tblBook.Add(data);
				db.SaveChanges();
			}
		}

		// Getting single book details by id
		public BookViewModel GetBookById(decimal? id)
		{
			using (var db = new BookEntities())
			{
				// Getting the data from database with the help of id
				var bookData = db.tblBook.Where(a => a.BookId == id).FirstOrDefault();

				// Assigning the data to the model from database 
				// with the help of bookData
				BookViewModel model = new BookViewModel();
				model.BookId = bookData.BookId;
				model.BookTitle = bookData.BookTitle;
				model.BookAuthor = bookData.BookAuthor;
				model.BookQuantity = bookData.BookQuantity;
				return (model);
			}

		}
	}
}