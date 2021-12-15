using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Максат_Рус.Models
{
    public class User
    {
        [Key]
        public int Id_User { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string LastName { get; set; }
        public DateTime DateBorn { get; set; }   
        public virtual Order_User Order_User { get; set; }
    }
}
