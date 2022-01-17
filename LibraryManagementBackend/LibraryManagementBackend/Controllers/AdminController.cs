using BusinessContrast;
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
    public class AdminController : ControllerBase
    {

        private readonly IBAAdmin bAAdmin;
        public AdminController(IBAAdmin _bAAdmin)
        {
            bAAdmin = _bAAdmin;
        }
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(bAAdmin.Booklistitem());
        }
        [HttpPost]
        public JsonResult Post( Database.Models.Books array)
        {
            bAAdmin.AddBooks(array);
            return new JsonResult("Added Successfully");
        }

        [HttpDelete]

        public JsonResult Delete(int id)
        {
            bAAdmin.DeleteBooks(id);
            return new JsonResult("Deleted Successfully");
        }
        [HttpPut]
        public JsonResult Put(Database.Models.Books array)
        {
            bAAdmin.EditBooks(array);
            return new JsonResult("Updated Successfully");
        }

        [Route("GetAllOrders")]
        [HttpGet]
        public JsonResult GetAllOrders()
        {
            return new JsonResult(bAAdmin.OrderLists());
        }
    }
}
