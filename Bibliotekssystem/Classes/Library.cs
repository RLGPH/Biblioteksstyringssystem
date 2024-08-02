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

        public bool AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"Added book: {book.Title}");
            return true;
        }

        public bool RemoveBook(Book book)
        {
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
        }
    }
}
