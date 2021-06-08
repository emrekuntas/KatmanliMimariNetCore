using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;DataBase=Northwind;Trusted_Connection=true;");

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }


        //Mapping örneği

        //protected override void OnModelCreating(ModelBuilder modelbuilder)
        //{
        //    modelbuilder.Entity<Product>().ToTable("products");
        //    modelbuilder.Entity<Product>().Property(p => p.ProductID).HasColumnName("ProductID");

        //}
    }
}
