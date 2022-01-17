using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Database.Models
{
    public partial class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public int StudentId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public virtual Books Book { get; set; }
        public virtual Students Student { get; set; }
    }
}
