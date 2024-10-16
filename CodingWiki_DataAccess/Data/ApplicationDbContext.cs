﻿using CodingWiki_DataAccess.FluentConfig;
using CodingWiki_Model.Models;
using CodingWiki_Model.Models.FluentModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CodingWiki_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<BookAuthorMap> BookAuthorMaps { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<FluentBookDetail> BookDetailsFluent { get; set; }
        public DbSet<FluentBook> FluentBooks { get; set; }
        public DbSet<FluentAuthor> FluentAuthors { get; set; }
        public DbSet<FluentPublisher> FluentPublishers { get; set; }
        public DbSet<FluentBookAuthorMap> FluentBookAuthorMaps { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // temporary
            // const string connectionString =
            //     "Server=localhost;Database=CodingWiki;TrustServerCertificate=true;Trusted_Connection=true;";
            // optionsBuilder.UseSqlServer(connectionString).LogTo(Console.WriteLine, new[] {DbLoggerCategory.Database.Command.Name}, LogLevel.Information);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FluentAuthorConfig());
            modelBuilder.ApplyConfiguration(new FluentBookConfig());
            modelBuilder.ApplyConfiguration(new FluentPublisherConfig());
            modelBuilder.ApplyConfiguration(new FluentBookAuthorMapConfig());
            modelBuilder.ApplyConfiguration(new FluentBookDetailConfig());

            modelBuilder.Entity<Book>().Property(x => x.Price).HasPrecision(10, 5);
            modelBuilder.Entity<BookAuthorMap>().HasKey(x => new { x.AuthorId, x.BookId });

            modelBuilder.Entity<Book>().HasData(
                new Book() { BookId = 1, Title = "The Catcher in the Rye", ISBN = "978-0-316-76948-0", Price = 9.99m, Publisher_Id = 1},
                new Book() { BookId = 2, Title = "1984", ISBN = "978-0-452-28423-4", Price = 14.99m, Publisher_Id = 2}
                );

            var bookList = new Book[]
            {
                new Book() { BookId = 3, Title = "To Kill a Mockingbird", ISBN = "978-0-06-112008-4", Price = 18.99m, Publisher_Id = 3},
                new Book() { BookId = 4, Title = "The Great Gatsby", ISBN = "978-0-7432-7356-5", Price = 10.99m, Publisher_Id = 1},
                new Book() { BookId = 5, Title = "Moby Dick", ISBN = "978-0-14-243724-7", Price = 12.99m, Publisher_Id = 2}
            };
            modelBuilder.Entity<Book>().HasData(bookList);

            modelBuilder.Entity<Publisher>().HasData(
                new Publisher() { PublisherId = 1, Name = "Penguin Random House", Location = "New York" }, 
                new Publisher() { PublisherId = 2, Name = "HarperCollins", Location = "London" }, 
                new Publisher() { PublisherId = 3, Name = "Macmillan Publishers", Location = "Manchester" });

            base.OnModelCreating(modelBuilder);
        }
    }
}
