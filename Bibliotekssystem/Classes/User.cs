using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssystem
{
    public class User
    {
        protected const int MaxBooksAllowed = 4;

        public string Name { get; set; }
        public string UserID { get; set; }
        public List<Book> Books { get; set; }

        public User(string name, string userid)
        {
            Name = name;
            UserID = userid;
            Books = new List<Book>();
        }

        public virtual bool BorrowBook(Library library, string isbn)
        {
            if (Books.Count >= MaxBooksAllowed)
            {
                Console.WriteLine($"{Name} has already borrowed the maximum number of {MaxBooksAllowed} books.");
                return false;
            }

            Book book = library.FindBookByISBN(isbn);
            if (book == null)
            {
                Console.WriteLine($"Book with ISBN {isbn} not found in the library.");
                return false;
            }

            if (book.IsAvailable)
            {
                Books.Add(book);
                book.IsAvailableFlip(book);
                Console.WriteLine($"{Name} borrowed {book.Title}.");
                return true;
            }
            else
            {
                Console.WriteLine($"{book.Title} is not available.");
                return false;
            }
        }

        public bool ReturnBook(Library library, string isbn)
        {
            Book book = Books.FirstOrDefault(b => b.ISBN == isbn);
            if (book == null)
            {
                Console.WriteLine($"{Name} does not have a book with ISBN {isbn} borrowed.");
                return false;
            }

            Books.Remove(book);
            Book libraryBook = library.FindBookByISBN(isbn);
            if (libraryBook != null)
            {
                libraryBook.IsAvailableFlip(libraryBook);
                Console.WriteLine($"{Name} returned {book.Title}.");
                return true;
            }
            else
            {
                Console.WriteLine($"Book with ISBN {isbn} not found in the library.");
                return false;
            }
        }
    }
}