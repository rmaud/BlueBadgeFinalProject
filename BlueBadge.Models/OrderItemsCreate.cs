﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Models
{
    public class OrderItemsCreate
    {
        [Required]
        public Guid OrderID { get; set; }
        public int CustomerId { get; set; }
        [Required]
        public int GameId { get; set; }
        public int PaymentId { get; set; }
        [Required]
        public int Quantity { get; set; }
        public DateTimeOffset OrderDate { get; set; }
    }
}