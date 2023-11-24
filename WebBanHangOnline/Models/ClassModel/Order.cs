using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models.ClassModel
{
    [Table("tb_Order")]
    public class Order
    {
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetails>();
        }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Code { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public decimal TotalAmount { get; set; }
        public int Quantity { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}