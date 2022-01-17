using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Database.Models
{
    public partial class Students
    {
        public Students()
        {
            Orders = new HashSet<Orders>();
        }
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Usn { get; set; }
        public int RoleId { get; set; }

        public virtual Roles Role { get; set; }
        public virtual Login Login { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
