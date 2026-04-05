using System;
using System.Collections.Generic;
using System.Text;

namespace _10_GenericTypesCollections.Library_System
{
     class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int PageCount { get; set; }

        public Book(int bookId,string title, string author, int year, int pageCount)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            Year = year;
            PageCount = pageCount;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"[{BookId}]{Title}-{Author}-{Year}-{PageCount}");
        }

    }
}
