namespace Library
{
    
}
internal class Book
{
    public string Title;
    public string Author;
    public string ISBN;

    static void Main(string[] args)
    {
        Book myBook = new Book();

        myBook.Title = "C# for beginners";
        myBook.Author = "BillGates";
        myBook.ISBN = "12345678";

        Console.WriteLine("Title: " + myBook.Title);
        Console.WriteLine("Author: " + myBook.Author);
        Console.WriteLine("ISBN: " + myBook.ISBN);
    }
}