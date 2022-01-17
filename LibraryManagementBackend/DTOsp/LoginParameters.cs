using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    [Keyless]
    public class LoginParameters
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Usn { get; set; }
    }
}
