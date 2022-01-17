using System;
using System.Collections.Generic;
using System.Text;
using BusinessContrast;
using DALContrast;

namespace BusinessImplementation
{
   public class BAStudent : IBAStudent
    {

        public readonly IStudentService studentService;

        public BAStudent(IStudentService _studentService)
        {
            studentService = _studentService;
        }

        public Object GetOrderDetail(dynamic parameters)
        {
            return studentService.GetOrderDetails(parameters);
        }

        public Object PlaceOrder(dynamic parameters)
        {
            return studentService.PlaceOrder(parameters);
        }

        public Object ReturnBook(dynamic parameters)
        {
            return studentService.ReturnBook(parameters);
        }

        public Object GetBookList(dynamic parameters)
        {
            return studentService.GetBookList(parameters);
        }
    }
}
