using Database.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DALContrast
{
    public interface IDAAdmin
    {
        public List<Books> BookList();
        public Books AddBook(Books book);    
        public void DeleteBook(int id);
        public Books EditBook(Books book);
        public IEnumerable<AdminOrderDetails> OrderList();
    }
}
