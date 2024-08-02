using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssystem
{
    public class Library
    {
        public List<Book> Books { get; set; }
        public List<User> Users { get; set; }

        public Library()
        {
            Books = new List<Book>();
            Users = new List<User>();
        }
        //du behøver ikke at bruge en constructor til at oprette en ny liste, kan gøres oppe i field'et.

        public bool AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"Added book: {book.Title}");
            return true;
            //Bool er ikke nødvendigt, når du altid returnerer true.
            //Desuden benyttes bool værdien ikke i andre steder i programmet. Valider eventuelt på library værdierne.
        }

        public bool RemoveBook(Book book)
        {
            //samme som ovenstående.
            if (Books.Remove(book))
            {
                Console.WriteLine($"Removed book: {book.Title}");
                return true;
            }
            else
            {
                Console.WriteLine($"Book not found: {book.Title}");
                return false;
            }
        }

        public bool RegisterUser(User user)
        {
            Users.Add(user);
            Console.WriteLine($"Registered user: {user.Name}");
            return true;
            //returnerer altid true, så din unit test vil altid gå igennem
            //brug evt. void, hvis ikke returværdien bruges.
        }

        public void DisplayAllAvailableBooks() 
        {
            Console.WriteLine("All available books in the library:");
            foreach (Book book in Books)
            {
                if (book.IsAvailable)
                {
                    Console.WriteLine($"- {book.Title} by {book.Author} (ISBN: {book.ISBN})");
                }
            }
        }

        public void DisplayAllBooks()
        {
            Console.WriteLine("All books in the library:");
            foreach (var book in Books)
            {
                Console.WriteLine($"- {book.Title} by {book.Author} (ISBN: {book.ISBN}) - Available: {book.IsAvailable}");
            }
        }
        public Book FindBookByISBN(string isbn)
        {
            return Books.FirstOrDefault(b => b.ISBN == isbn);
            //Brug evt. first i stedet for firstordefault.
        }
    }
}
