using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Database.Models
{
    public partial class Books
    {
        public Books()
        {
            Orders = new HashSet<Orders>();
        }
        [Key]
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string AuthorName { get; set; }
        public int Cost { get; set; }
        public int AvailableQuantity { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
