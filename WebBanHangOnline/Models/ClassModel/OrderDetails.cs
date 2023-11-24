﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models.ClassModel
{
    [Table("tb_OrderDetails")]
    public class OrderDetails
    {
        [Key]
        [Column(Order = 0)]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}