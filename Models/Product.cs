using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Максат_Рус.Models
{
    public class Product
    {
        [Key]
        public int Id_Product { get; set; }       
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Release { get; set; }
    }
}
