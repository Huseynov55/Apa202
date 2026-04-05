using _10_GenericTypesCollections.Library_System;

namespace _10_GenericTypesCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new(1, "Martin Eden", "Jack London", 1909, 400);
            Book book2 = new(2, "1984", "George Orwell", 1949, 328);
            Book book3 = new(3, "Animal Farm", "George Orwell", 1945, 112);
            Book book4 = new(4, "Ag Gemi", "Cingiz Aytmatov", 1970, 200);
            Book book5 = new(5, "Qiriq Budaq", "Elcin", 1998, 350);

            Console.WriteLine("Kitablarin melumatlari:");
            book1.DisplayInfo();
            book2.DisplayInfo();
            book3.DisplayInfo();
            book4.DisplayInfo();
            book5.DisplayInfo();

            Console.WriteLine("==================================================================");

            Console.WriteLine("Generic Library<T> test:");
            Library<Book> MilliKitabxana = new("Milli Kitabxana");
            MilliKitabxana.Add(book1);
            MilliKitabxana.Add(book2);
            MilliKitabxana.Add(book3);
            MilliKitabxana.Add(book4);
            MilliKitabxana.Add(book5);

            Console.WriteLine("==================================================================");

            Console.WriteLine($"Kitabxanada {MilliKitabxana.GetAll().Count} kitab var.");

            Console.WriteLine("==================================================================");

            Book book = MilliKitabxana.FindByIndex(0);
            Console.WriteLine($"0-ci indexdeki kitab:{book.Title}");

            Book book0 = MilliKitabxana.FindByIndex(2);
            Console.WriteLine($"2-ci indexdeki kitab:{book0.Title}");

            Console.WriteLine("==================================================================");

            List<Book> AllBooks = MilliKitabxana.GetAll();
            foreach (var item in AllBooks)
            {
                item.DisplayInfo();
            }

            Console.WriteLine("==================================================================");

            List<Member> members = new();
            Member member1 = new(1, "Ali Memmedov", "ali@mail.com");
            Member member2 = new(2, "Leyla Hesenova", "leyla@mail.com");
            Member member3 = new(3, "Vuqar Eliyev", "vuqar@mail.com");

            Console.WriteLine("Uzvler ve borc sistemi:");
            members.Add(member1);
            members.Add(member2);
            members.Add(member3);

            member1.BorrowBook(book1);
            member1.BorrowBook(book2);
            member1.DisplayBorrowedBooks();

            Console.WriteLine("==================================================================");

            member1.ReturnBook(1);
            member1.DisplayBorrowedBooks();

            Console.WriteLine("==================================================================");

            member1.BorrowBook(book3);
            member1.BorrowBook(book4);
            member1.BorrowBook(book5);

            Console.WriteLine("=================================================================");

            BookManager manager = new();
            manager.AddBook(book1);
            manager.AddBook(book2);
            manager.AddBook(book3);
            manager.AddBook(book4);
            manager.AddBook(book5);

            Console.WriteLine("Muellife gore axtaris:");

            var OrwellsBook = manager.GetBooksByAuthor("George Orwell");
            Console.WriteLine("George Orwellin kitablari:");

            foreach (var o in OrwellsBook)
            {
                Console.WriteLine(o.Title);
            }

            Console.WriteLine("================================================================");

            var AytmatovsBook = manager.GetBooksByAuthor("Cingiz Aytmatov");
            Console.WriteLine("Cingiz Aytmatovun kitablari:");

            foreach (var o in AytmatovsBook)
            {
                Console.WriteLine(o.Title);
            }

            Console.WriteLine("================================================================");

            var LondonsBook = manager.GetBooksByAuthor("Jack London");
            Console.WriteLine("Jack Londonun kitablari:");

            foreach (var o in LondonsBook)
            {
                Console.WriteLine(o.Title);
            }

            Console.WriteLine("===============================================================");

            var DostoyevskisBook = manager.GetBooksByAuthor("Dostoyevski");
            Console.WriteLine("Dostoyevskinin kitablari:");

            foreach (var o in DostoyevskisBook)
            {
                Console.WriteLine(o.Title);
            }

            Console.WriteLine("===============================================================");

            Console.WriteLine("Gozleme novbesi:");
            manager.AddToWaitingQueue("Nigar");
            manager.AddToWaitingQueue("Resad");
            manager.AddToWaitingQueue("Sebine");

            Console.WriteLine("===============================================================");

            Console.WriteLine($"Novbede olanlarin sayi:{manager.WaitingQueue.Count}");
            string nextPerson = manager.ServeNextInQueue();
            Console.WriteLine($"Xidmet edilir: {nextPerson}");
            Console.WriteLine($"Qalan musteri sayi:{manager.WaitingQueue.Count}");

            Console.WriteLine("==============================================================");

            Console.WriteLine($"Novbede olanlarin sayi:{manager.WaitingQueue.Count}");
            string nextPerson1 = manager.ServeNextInQueue();
            Console.WriteLine($"Xidmet edilir: {nextPerson1}");
            Console.WriteLine($"Qalan musteri sayi:{manager.WaitingQueue.Count}");

            Console.WriteLine("==============================================================");

            Console.WriteLine($"Novbede olanlarin sayi:{manager.WaitingQueue.Count}");
            string nextPerson2 = manager.ServeNextInQueue();
            Console.WriteLine($"Xidmet edilir: {nextPerson2}");
            Console.WriteLine($"Qalan musteri sayi:{manager.WaitingQueue.Count}");

            Console.WriteLine("==============================================================");

            Console.WriteLine("Son qaytarilan kitablar:");
            manager.ReturnBook(book1);
            manager.ReturnBook(book2);
            manager.ReturnBook(book3);

            Console.WriteLine($"Stackdeki kitab sayi:{manager.RecentlyReturned.Count}");

            Book lastBook = manager.GetLastReturnedBook();
            Console.WriteLine($"Son qaytarilan kitab:{lastBook.Title}");

            Console.WriteLine("==============================================================");

            Book removeBook = manager.RecentlyReturned.Pop();
            Console.WriteLine($"Stackde olan kitablarin sayi:{manager.RecentlyReturned.Count}");

            Console.WriteLine("===============================================================");

            Book lastbook = manager.GetLastReturnedBook();
            Console.WriteLine($"Yeniden son qaytarilan kitab:{lastbook.Title}");

            Console.WriteLine("===============================================================");

            Console.WriteLine("Axtaris testi:");

            Book searchBook = manager.SearchByTitle("1984");
            if (searchBook != null)
            {
                Console.WriteLine($"{searchBook.Title} adli kitab tapildi.");
            }

            Console.WriteLine("===============================================================");

            Book notBook = manager.SearchByTitle("Harry Potter");
            if(notBook == null)
            {
                Console.WriteLine($"Harry Potter tapilmadi");
            }

            Console.WriteLine("===============================================================");

            Console.WriteLine("Statistika:");

            Console.WriteLine($"Umumi kitab sayi:{AllBooks.Count}");
            Console.WriteLine($"Umumi uzv sayi:{members.Count}");
            Console.WriteLine($"Novbede nefer sayi:{manager.WaitingQueue.Count}");
            Console.WriteLine($"Stack-deki kitab sayi:{manager.RecentlyReturned.Count}");

            int min = AllBooks[0].Year;
            int max = AllBooks[0].Year;
            if (AllBooks.Count > 0)
            {
                foreach(var item in AllBooks)
                {
                    if (item.Year < min)
                    {
                        min = item.Year;
                    }
                    if(item.Year > max)
                    {
                        max = item.Year;
                    }
                }
            }
            Console.WriteLine($"En kohne kitabin ili:{min}");
            Console.WriteLine($"En yeni kitabin ili:{max}"); 









        }
    }
}
