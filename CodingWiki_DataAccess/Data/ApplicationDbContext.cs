using CodingWiki_Model.Models;
using CodingWiki_Model.Models.FluentModels;
using Microsoft.EntityFrameworkCore;

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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // temporary
            optionsBuilder.UseSqlServer("Server=localhost;Database=CodingWiki;TrustServerCertificate=true;Trusted_Connection=true;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FluentBookDetail>().HasKey(x => x.BookDetailId);
            modelBuilder.Entity<FluentBookDetail>().Property(x => x.NumberOfChapters).IsRequired();
            modelBuilder.Entity<FluentBookDetail>().ToTable("FluentBookDetail");
            modelBuilder.Entity<FluentBookDetail>().Property(x => x.NumberOfChapters).HasColumnName("NoOfChapters");
            modelBuilder.Entity<FluentBookDetail>()
                .HasOne(x => x.Book)
                .WithOne(x => x.BookDetail)
                .HasForeignKey<FluentBookDetail>(x => x.BookId);

            modelBuilder.Entity<FluentBook>().HasKey(x => x.BookId);
            modelBuilder.Entity<FluentBook>().Property(x => x.ISBN).IsRequired();
            modelBuilder.Entity<FluentBook>().Property(x => x.ISBN).HasMaxLength(50);
            modelBuilder.Entity<FluentBook>().Ignore(x => x.PriceRange);
            modelBuilder.Entity<FluentBook>()
                .HasOne(x => x.Publisher)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.PublisherId);

            modelBuilder.Entity<FluentAuthor>().HasKey(x => x.AuthorId);
            modelBuilder.Entity<FluentAuthor>().Property(x => x.FirstName).IsRequired();
            modelBuilder.Entity<FluentAuthor>().Property(x => x.FirstName).HasMaxLength(20);
            modelBuilder.Entity<FluentAuthor>().Property(x => x.LastName).IsRequired();
            modelBuilder.Entity<FluentAuthor>().Ignore(x => x.FullName);

            modelBuilder.Entity<FluentPublisher>().HasKey(x => x.PublisherId);
            modelBuilder.Entity<FluentPublisher>().Property(x => x.Name).IsRequired();

            modelBuilder.Entity<FluentBookAuthorMap>().HasKey(x => new { x.AuthorId, x.BookId });
            modelBuilder.Entity<FluentBookAuthorMap>().HasOne(x => x.Author).WithMany(x => x.BookAuthorMap)
                .HasForeignKey(x => x.AuthorId);
            modelBuilder.Entity<FluentBookAuthorMap>().HasOne(x => x.Book).WithMany(x => x.BookAuthorMap)
                .HasForeignKey(x => x.BookId);

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
