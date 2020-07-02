﻿using System.ComponentModel.DataAnnotations;
using static Shipping.Enums;

namespace Shipping.Models
{
    public class Payment
    {
        [Required]
        public OrderTypes Type { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public OrderMode OrderMode { get; set; }

    }
}
