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

        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"Added book: {book.Title}");
        }

        public void RemoveBook(Book book)
        {
            if (Books.Remove(book))
            {
                Console.WriteLine($"Removed book: {book.Title}");
            }
            else
            {
                Console.WriteLine($"Book not found: {book.Title}");
            }
        }

        public void RegisterUser(User user)
        {
            Users.Add(user);
            Console.WriteLine($"Registered user: {user.Name}");
        }

        public void DisplayAllBooks()
        {
            Console.WriteLine("All books in the library:");
            foreach (var book in Books)
            {
                Console.WriteLine($"- {book.Title} by {book.Author} (ISBN: {book.ISBN}) - Available: {book.IsAvailable}");
            }
        }

    }
}
