using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Database.Models
{
    public partial class Roles
    {
        public Roles()
        {
            Students = new HashSet<Students>();
        }
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<Students> Students { get; set; }
    }
}
