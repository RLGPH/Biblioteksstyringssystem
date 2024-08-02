using System;
using System.Collections.Generic;
using System.Linq;

namespace Bibliotekssystem
{
    public class PremiumUser : User
    {
        private const int PremiumMaxBooksAllowed = MaxBooksAllowed + 1;

        public PremiumUser(string name, string userid) : base(name, userid)
        {
        }

        public override bool BorrowBook(Library library, string isbn)
        {
            if (Books.Count >= PremiumMaxBooksAllowed)
            {
                Console.WriteLine($"{Name} has already borrowed the maximum number of {PremiumMaxBooksAllowed} books.");
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
    }
}
