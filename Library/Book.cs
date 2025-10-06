using System;

namespace Library
{
    internal class Book
    {
        public string Title;
        public string Author;
        public string ISBN;

        // Constructor that requires title, author, and ISBN
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }

        void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Book book1 = new Book("C# for beginners", "BillGates", "12345678");
            Book book2 = new Book("C#", "Microsoft", "1234");

            book1.DisplayInfo();
            book2.DisplayInfo();
        }
    }
}