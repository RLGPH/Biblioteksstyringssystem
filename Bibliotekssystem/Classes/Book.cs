﻿using System;
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
        //just changed to true after getting reviewed and i can see why it should be true
        public bool IsAvailable { get; private set; } = true;

        public Book(string title, string author, string iSBN, bool isAvailable)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            IsAvailable = isAvailable;
        }
        
        public void DisplayInfo(string ISBN, Library library)
        {
            Book book = library.FindBookByISBN(ISBN);
            Console.WriteLine($"Info about Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Available: {book.IsAvailable}");
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
