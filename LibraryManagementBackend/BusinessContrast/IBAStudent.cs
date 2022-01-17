using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessContrast
{
    public interface IBAStudent
    {
        public Object GetOrderDetail(dynamic parameters);

        public Object PlaceOrder(dynamic parameters);

        public Object ReturnBook(dynamic parameters);

        public Object GetBookList(dynamic parameters);
    }
}
 