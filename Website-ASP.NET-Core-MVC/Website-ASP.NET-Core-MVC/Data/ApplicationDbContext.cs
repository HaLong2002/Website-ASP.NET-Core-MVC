﻿using Microsoft.EntityFrameworkCore;
using Website_ASP.NET_Core_MVC.Models;

namespace Website_ASP.NET_Core_MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        public DbSet<Customer> Customers { get; set; } // Add your DbSets here

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Customer>()
				.HasIndex(u => u.UserName)
				.IsUnique();

			modelBuilder.Entity<Customer>()
				.HasIndex(u => u.Email)
				.IsUnique();
		}

	}
}
