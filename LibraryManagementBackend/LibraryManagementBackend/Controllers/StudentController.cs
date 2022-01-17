using BusinessContrast;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IBAStudent bAStudent;
        public StudentController(IBAStudent _bAStudent)
        {
            bAStudent = _bAStudent;
        }

        [HttpPost]
        [Route("GetBookList")]
        public JsonResult GetBookLists([FromBody] SpParameters parameters)
        {
            return new JsonResult(bAStudent.GetBookList(parameters));
        }

        [HttpPost]
        [Route("GetOrderDetails")]
        public JsonResult GetOrderDetails(SpParameters parameters)
        {
            return new JsonResult(bAStudent.GetOrderDetail(parameters));
        }

        [HttpPost]
        [Route("PlaceOrder")]
        public JsonResult PlaceOrder([FromBody] SpParameters parameters)
        {
            return new JsonResult(bAStudent.PlaceOrder(parameters));
        }

        [HttpPost]
        [Route("ReturnBook")]
        public JsonResult ReturnBook([FromBody] SpParameters parameters)
        {
            return new JsonResult(bAStudent.ReturnBook(parameters));
        }

        [HttpGet]
        [Route("StudentId")]
        public JsonResult StudentId(string name)
        {
            Database.Models.LibraryManagementContext library = new Database.Models.LibraryManagementContext();
            var student= library.Students.SingleOrDefault(x => x.StudentName == name);
            if (student != null)
            {
                return new JsonResult(student.StudentId);
            }
            else
            {
                return new JsonResult("Null");
            }
        }
    }
}

