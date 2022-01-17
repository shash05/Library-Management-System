using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    [Keyless]
    public class SpParameters
    {
        public int? StudentId { get; set; }
        public int? OrderId { get; set; }
        public int? BookId { get; set; }
    }
}
