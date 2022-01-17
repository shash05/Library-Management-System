using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessContrast
{
   public  interface IBAAdmin
    {
        public Array Booklistitem();
        public Array AddBooks(dynamic book);
        public void DeleteBooks(int id);
        public Array EditBooks(dynamic book);
        public object OrderLists();
    }
}
