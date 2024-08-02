using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssystem
{
    class Program
    {
        static void Main(string[] args)
            //unødvendigt at bruge args
        {
            //display test
            Library library = new Library();

            User user = new("Jhon Doe", "U1424");

            Book book = new("JDoe", "Jhon Doe", "B1235", true);
            Book book1 = new Book("C# Programming", "John Doe", "B1234", true);
            Book book2 = new Book("ASP.NET MVC", "Jane Doe", "B0987", true);
            Book book3 = new Book("Learn LINQ", "Alice Smith", "B1122", true);
            Book book4 = new Book("Entity Framework Core", "Bob Johnson", "B2233", true);
            Book book5 = new Book("Blazor WebAssembly", "Carol Brown", "B3344", true);

            //IsAvailable kan eventuelt fjernes som parameter, da bøgerne plejer at være tilgængelige når de oprettes.

            library.AddBook(book);
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            //eventuelt lav et loop til at tilføje.

            library.RegisterUser(user);

            user.BorrowBook(library, "B1235");

            library.DisplayAllBooks();
            library.DisplayAllAvailableBooks();
            book.DisplayInfo("B1235", library);

            user.ReturnBook(library, "B1235");
            library.DisplayAllAvailableBooks();
            book.DisplayInfo("B1235", library);
        }
    }
}
//generelt kan jeg foreslå følgende.
//ikke brug bool hvis det kun benyttes til unit test (med undtagelser)
//Eventuelt overvej at lave en automatisk opretning af ISBN
//overvej at sørge for at en bog er available indtil den lånes, så behøves den ekstra parameter ikke.

