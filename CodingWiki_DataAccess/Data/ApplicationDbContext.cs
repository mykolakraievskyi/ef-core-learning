﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingWiki_Model_.Models;
using Microsoft.EntityFrameworkCore;

namespace CodingWiki_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // temporary
            optionsBuilder.UseSqlServer("Server=localhost;Database=CodingWiki;TrustServerCertificate=true;Trusted_Connection=true;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(x => x.Price).HasPrecision(10, 5);
            modelBuilder.Entity<Book>().HasData(
                new Book() { BookId = 1, Title = "The Catcher in the Rye", ISBN = "978-0-316-76948-0", Price = 9.99m },
                new Book() { BookId = 2, Title = "1984", ISBN = "978-0-452-28423-4", Price = 14.99m }
                );

            var bookList = new Book[]
            {
                new Book() { BookId = 3, Title = "To Kill a Mockingbird", ISBN = "978-0-06-112008-4", Price = 18.99m },
                new Book() { BookId = 4, Title = "The Great Gatsby", ISBN = "978-0-7432-7356-5", Price = 10.99m },
                new Book() { BookId = 5, Title = "Moby Dick", ISBN = "978-0-14-243724-7", Price = 12.99m }
            };
            modelBuilder.Entity<Book>().HasData(bookList);
            base.OnModelCreating(modelBuilder);
        }
    }
}
