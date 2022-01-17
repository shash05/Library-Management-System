using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    [Keyless]
    public class SpResponse
    {
        public int Id { get; set; }
        public string Message { get; set; }

    }
}
