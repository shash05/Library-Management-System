using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Database.Models
{
    public partial class Login
    {
        [Key]
        public int LoginId { get; set; }
        public int StudentId { get; set; }
        public string Password { get; set; }
        public bool LoginStatus { get; set; }

        public virtual Students Student { get; set; }
    }
}
