using System;
using System.Collections.Generic;
using System.Text;

namespace _10_GenericTypesCollections.Library_System
{
    class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public Member(int memberId, string name, string email)
        {
            MemberId = memberId;
            Name = name;
            Email = email;
            BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            if (BorrowedBooks.Count < 3)
            {
                BorrowedBooks.Add(book);
                Console.WriteLine($"Kitab goturuldu:[{book.Title}]");
            }
            else
            {
                Console.WriteLine("Maksimum 3 kitab goture bilersiniz!");
            }
        }

        public void ReturnBook(int bookId)
        {
            Book findBook = null;
            foreach(Book book in BorrowedBooks)
            {
                if(book.BookId == bookId)
                {
                    findBook = book;
                    break;
                }
            }
            if(findBook != null)
            {
                BorrowedBooks.Remove(findBook);
                Console.WriteLine($"Kitab qaytarildi:[{findBook.Title}]");
            }
        }

        public void DisplayBorrowedBooks()
        {
            if (BorrowedBooks.Count == 0)
            {
                Console.WriteLine("Borc kitab yoxdur.");
            }
            else
            {
                foreach(Book book in BorrowedBooks)
                {
                    Console.WriteLine(book.Title);
                }
            }
        }

    }
}
