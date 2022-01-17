using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DTO
{
  public   class AdminOrderDetails
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string AuthorName { get; set; }
        public int Cost { get; set; }
        public int AvailableQuantity { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string USN { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
