using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssystem
{
    public class Book
    {
        public string Title { get; set; } = "N/A";
        public string Author { get; set; } = "N/A";
        public string ISBN { get; set; } = "N/A";
        public bool IsAvailable { get; private set; } = false;

        public Book(string title, string author, string iSBN, bool isAvailable)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            IsAvailable = isAvailable;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Available: {IsAvailable}");
        }
        public void IsAvailableFlip(Book book)
        {
            if (IsAvailable)
            {
                book.IsAvailable = false; 
            }
            else
            {
                book.IsAvailable = true;
            }
        }
    }
}
