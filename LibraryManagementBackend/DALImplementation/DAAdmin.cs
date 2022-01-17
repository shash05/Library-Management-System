using DALContrast;
using Database.Models;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DALImplementation
{
   public class DAAdmin : IDAAdmin
    {
        public readonly LibraryManagementContext libraryManagementContext;

        public DAAdmin(LibraryManagementContext _libraryManagementContext)
        {
            libraryManagementContext = _libraryManagementContext;
        }
        public List<Books> BookList()
        {
            return libraryManagementContext.Books.ToList();
        }

        public Books AddBook(Books book)
        {
            libraryManagementContext.Books.Add(book);
            libraryManagementContext.SaveChanges();
            return null;
        }

        public  void DeleteBook(int id)
        {
            Books book = libraryManagementContext.Books.Find(id);
            libraryManagementContext.Remove(book);
            libraryManagementContext.SaveChanges();
        }

        public Books EditBook(Books book)
        {
            var id = libraryManagementContext.Books.Find(book.BookId);
            if (id != null)
            {
                id.BookTitle = book.BookTitle;
                id.Cost = book.Cost;
                id.AvailableQuantity = book.AvailableQuantity;
                libraryManagementContext.Books.Update(id);
                libraryManagementContext.SaveChanges();
            }
            return book;
        }

        public IEnumerable<AdminOrderDetails> OrderList()
        {
             IEnumerable<AdminOrderDetails> orderlist =libraryManagementContext.AdminOrderDetails.FromSqlRaw("EXEC [usp_AdminOrderDetails]");
            return orderlist;
        }

    }
}
