using System;

namespace Library
{
    internal class Book
    {
        public string Title;
        public string Author;
        public string ISBN;

        void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();

        }

        static void Main(string[] args)
        {

            Book book1 = new Book();
            book1.Title = "C# for beginners";
            book1.Author = "BillGates";
            book1.ISBN = "12345678";

            // book 2
            Book book2 = new Book();
            book2.Title = "C#";
            book2.Author = "Microsoft";
            book2.ISBN = "1234";

            // simpler way to displayinfo instead of writing Console.WriteLine each time
            book1.DisplayInfo();
            book2.DisplayInfo();


        }






   }
}