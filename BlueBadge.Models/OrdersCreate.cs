﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Models
{
    public class OrdersCreate
    {
        [Required]
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int PaymentId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
