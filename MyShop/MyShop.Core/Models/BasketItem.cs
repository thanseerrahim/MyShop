﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class BasketItem
    {
        [Key]
        public string BasketId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }

    }
}
