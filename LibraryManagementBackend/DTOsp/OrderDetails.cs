using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    [Keyless]
    public class OrderDetails
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public int Fine { get; set; }
        public int BookId { get; set; }
        public string BookTitle { get; set; }
    }
}
