using System;
using System.Collections.Generic;

#nullable disable

namespace WebDemo20210622.Models
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
