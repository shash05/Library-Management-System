
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DALContrast;
using Database.Models;

namespace DALImplementation
{
    public class StudentService : IStudentService
    {
        readonly LibraryManagementContext context = new LibraryManagementContext();
        public IEnumerable<Books> GetBookList(SpParameters parameters)
        {
            IEnumerable<Books> books = context.Books.FromSqlRaw<Books>("EXEC usp_BookSearchList {0}", parameters.StudentId);

            return books;
        }

        public IEnumerable<OrderDetails> GetOrderDetails(SpParameters parameters)
        {
            IEnumerable<OrderDetails> orderDetails = context.OrderDetails.FromSqlRaw("EXEC usp_OrderDetails {0}", parameters.StudentId);

            return orderDetails;
        }

        public IEnumerable<SpResponse> PlaceOrder(SpParameters parameters)
        {
            IEnumerable<SpResponse> orderDetails = context.PlaceAndReturn.FromSqlRaw("EXEC usp_PlaceOrder {0}, {1}", parameters.StudentId, parameters.BookId);

            return orderDetails;
        }

        public IEnumerable<SpResponse> ReturnBook(SpParameters parameters)
        {
            IEnumerable<SpResponse> orderDetails = context.PlaceAndReturn.FromSqlRaw("EXEC usp_ReturnBook {0}, {1}, {2}", parameters.StudentId, parameters.OrderId, parameters.BookId);

            return orderDetails;
        }
    }
}
