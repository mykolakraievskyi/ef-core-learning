﻿// <auto-generated />
using CodingWiki_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240926123109_maxLengthAndNotMappedInTheTable")]
    partial class maxLengthAndNotMappedInTheTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CodingWiki_Model_.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 5)
                        .HasColumnType("decimal(10,5)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            ISBN = "978-0-316-76948-0",
                            Price = 9.99m,
                            Title = "The Catcher in the Rye"
                        },
                        new
                        {
                            BookId = 2,
                            ISBN = "978-0-452-28423-4",
                            Price = 14.99m,
                            Title = "1984"
                        },
                        new
                        {
                            BookId = 3,
                            ISBN = "978-0-06-112008-4",
                            Price = 18.99m,
                            Title = "To Kill a Mockingbird"
                        },
                        new
                        {
                            BookId = 4,
                            ISBN = "978-0-7432-7356-5",
                            Price = 10.99m,
                            Title = "The Great Gatsby"
                        },
                        new
                        {
                            BookId = 5,
                            ISBN = "978-0-14-243724-7",
                            Price = 12.99m,
                            Title = "Moby Dick"
                        });
                });

            modelBuilder.Entity("CodingWiki_Model_.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}
