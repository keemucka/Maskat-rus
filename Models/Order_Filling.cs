using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Максат_Рус.Models
{
    public class Order_Filling
    {
        [Key]
        public int Id_OrderBody { get; set; }
        public int Product_Id { get; set; }
        public int Order_Id { get; set; }

        [ForeignKey(nameof(Product_Id))]
        [InverseProperty(nameof(Product.Id_Product))]
        public virtual Product product { get; set; }

        [ForeignKey(nameof(Order_Id))]
        [InverseProperty(nameof(Order.Id_Order))]
        public virtual  ICollection<Order> order { get; set; }
    }
}
