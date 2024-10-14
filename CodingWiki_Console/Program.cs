// See https://aka.ms/new-console-template for more information

using CodingWiki_DataAccess.Data;
using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

// using (var context = new ApplicationDbContext())
// {
//     context.Database.EnsureCreated(); // if doesn't exist (or schema doesn't exist)
//     if (context.Database.GetPendingMigrations().Any())
//     {
//         context.Database.Migrate();
//     }
// }
//AddBook();
//GetAllBooks();
GetBook();
return;

void GetBook()
{
    //EF.Functions.
    using var context = new ApplicationDbContext();
    var book = context.Books.FirstOrDefault(x => x.Publisher_Id == 3);
    Console.WriteLine(book);
}
void GetAllBooks()
{
    using var context = new ApplicationDbContext();
    var books = context.Books.ToList();
    books.ForEach(x => Console.WriteLine(x.Title + " - " + x.ISBN));
}

void AddBook()
{
    var book = new Book()
    {
        Title = "New EF Core book",
        ISBN = "978-1-84356-028-2",
        Price = 10.93m,
        Publisher_Id = 1
    };
    using var context = new ApplicationDbContext();
    context.Books.Add(book);
    context.SaveChanges();

}

