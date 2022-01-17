using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using DTO;

namespace LibraryManagementBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        LibraryManagementContext context = new LibraryManagementContext();

        [HttpPost]
        [Route("login")]
        public JsonResult Login([FromBody] LoginParameters parameters )
        {
            var res = context.PlaceAndReturn.FromSqlRaw<SpResponse>("EXEC [UserLogin] {0},{1} ", parameters.Username, parameters.Password);

            return new JsonResult(res);
        }

        [HttpPost]
        [Route("register")]
        public JsonResult Register([FromBody] LoginParameters parameters)
        {
            var res = context.PlaceAndReturn.FromSqlRaw<SpResponse>("EXEC [RegisterUser] {0},{1},{2} ", parameters.Username, parameters.Password,parameters.Usn);

            return new JsonResult(res);
        }
    }
}
