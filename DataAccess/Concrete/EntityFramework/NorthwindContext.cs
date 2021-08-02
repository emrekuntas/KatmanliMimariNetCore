using Core.Entities.Concrete;
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
            optionsBuilder.UseSqlServer(@"Server=EM;DataBase=Northwind;Trusted_Connection=true;");

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }






        //Mapping örneği

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<User>().ToTable("users");
            modelbuilder.Entity<User>().Property(p => p.Id).HasColumnName("Id");
            modelbuilder.Entity<User>().Property(p => p.FirstName).HasColumnName("FirstName");
            modelbuilder.Entity<User>().Property(p => p.LastName).HasColumnName("LastName");
            modelbuilder.Entity<User>().Property(p => p.Email).HasColumnName("Email");



        }
    }
}
