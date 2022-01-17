using BusinessContrast;
using DALContrast;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessImplementation
{
  public  class BAAdmin : IBAAdmin
    {
        public readonly IDAAdmin dAAdmin;

        public BAAdmin(IDAAdmin _dAAdmin)
        {
            dAAdmin = _dAAdmin;
        }
        public Array Booklistitem()
        {
            return dAAdmin.BookList().ToArray();
            
        }

        public Array AddBooks(dynamic book)
        {
           dAAdmin.AddBook(book);
            return null;
            
        }
        public void DeleteBooks(int id)
        {
            dAAdmin.DeleteBook(id);
        }
        public Array EditBooks(dynamic book)
        {
            dAAdmin.EditBook(book);
            return null;
        }
        public object OrderLists()
        {
            return dAAdmin.OrderList();
        }
    }
}
