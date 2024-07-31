using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssystem
{
    public class User
    {
        private const int MaxBooksAllowed = 5;

        public string Name { get; set; }
        public string UserID { get; set; }
        public List<Book> Books { get; set; }

        public User()
        {
            Books = new List<Book>();
        }

        public void BorrowBook(Library library, Book book)
        {
            if (Books.Count >= MaxBooksAllowed)
            {
                Console.WriteLine($"{Name} has already borrowed the maximum number of {MaxBooksAllowed} books.");
                return;
            }

            if (book.IsAvailable)
            {
                Books.Add(book);
                book.IsAvailable = false;
                Console.WriteLine($"{Name} borrowed {book.Title}.");
            }
            else
            {
                Console.WriteLine($"{book.Title} is not available.");
            }
        }

        public void ReturnBook(Library library, Book book)
        {
            if (Books.Contains(book))
            {
                Books.Remove(book);
                book.IsAvailable = true;
                Console.WriteLine($"{Name} returned {book.Title}.");
            }
            else
            {
                Console.WriteLine($"{Name} does not have {book.Title} borrowed.");
            }
        }

        public void DisplayBorrowedBooks()
        {
            Console.WriteLine($"{Name}'s borrowed books:");
            foreach (var book in Books)
            {
                Console.WriteLine($"- {book.Title} by {book.Author} (ISBN: {book.ISBN})");
            }
        }
    }
}
