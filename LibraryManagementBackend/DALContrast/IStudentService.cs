using System;
using System.Collections.Generic;
using System.Text;
using Database.Models;
using DTO;

namespace DALContrast
{
    public interface IStudentService
    {
        public IEnumerable<OrderDetails> GetOrderDetails(SpParameters parameters);

        public IEnumerable<SpResponse> PlaceOrder(SpParameters parameters);

        public IEnumerable<SpResponse> ReturnBook(SpParameters parameters);

        public IEnumerable<Books> GetBookList(SpParameters parameters);
    }
}
