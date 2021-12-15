using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Максат_Рус.Models
{
    public class Order
    {
        [Key]
        public int Id_Order { get; set; }
        public DateTime Date { get; set; }     
    }
}
