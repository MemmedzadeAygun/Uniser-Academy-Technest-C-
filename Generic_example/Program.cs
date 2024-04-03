

using Generic_example.Classes;
using Generic_example.Managers;
using System.Diagnostics;
using System.Xml.Linq;
BookManager bookManager = new BookManager();

Book addedBook = new Book {Id=3, Name = "Crime and Punishment", Price = 30 };
bookManager.Add(addedBook);

foreach (var book in bookManager.GetAll())
{
    Console.WriteLine($"Id - {book.Id} - - - Name - {book.Name} - - - Price - {book.Price}");
}


//Console.WriteLine(bookManager.GetById(2).Name);
//bookManager.Update(1, new Book { Name = "Atomic Habits", Price = 30 });
