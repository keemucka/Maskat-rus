using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Максат_Рус.Models
{
    public class Order_User
    {
        [Key]
        public int Id_OrderUser { get; set; }
        public int User_Id { get; set; }
        public int Order_Id { get; set; }

        [ForeignKey(nameof(User_Id))]
        [InverseProperty(nameof(User.Id_User))]
        public virtual User user { get; set; }

        [ForeignKey(nameof(Order_Id))]
        [InverseProperty(nameof(Order.Id_Order))]
        public virtual ICollection<Order> order { get; set; }


    }
}
