using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Максат_Рус.Models;
using System.Data.SqlClient;

namespace Максат_Рус
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext() : base()
        { }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        { }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order_Filling> Order_Fillings { get; set; }
        public virtual DbSet<Order_User> Order_User { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
                optionsBuilder.UseNpgsql("Host=localhost;Database=InternetStore;Username=postgres;Password=1234;Persist Security Info=True");
            //}
        }
    }
}
