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

        public User(string name, string Userid)
        {
            Name = name;
            UserID = Userid;
        }

        public User()
        {
            Books = new List<Book>();
        }

        public bool BorrowBook(Library library, Book book)
        {
            if (Books.Count >= MaxBooksAllowed)
            {
                Console.WriteLine($"{Name} has already borrowed the maximum number of {MaxBooksAllowed} books.");
                return false;
            }

            if (book.IsAvailable)
            {
                Books.Add(book);
                book.IsAvailable = false;
                Console.WriteLine($"{Name} borrowed {book.Title}.");
                return true;
            }
            else
            {
                Console.WriteLine($"{book.Title} is not available.");
                return false;
            }
        }

        public bool ReturnBook(Library library, Book book)
        {
            if (Books.Contains(book))
            {
                Books.Remove(book);
                book.IsAvailable = true;
                Console.WriteLine($"{Name} returned {book.Title}.");
                return true;
            }
            else
            {
                Console.WriteLine($"{Name} does not have {book.Title} borrowed.");
                return false;
            }
        }
    }
}