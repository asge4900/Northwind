﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Northwind.Gui.Web.Models;

namespace Northwind.Gui.Web.Models
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext (DbContextOptions<NorthwindContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Customer>().ToTable("Customer");

            modelBuilder.Entity<Employee>();
               
               
        }
    }
}
