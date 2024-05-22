internal partial class Program
{
    private static void Runner(string[] args)
    {
        static void Runner()
        {
            Library library = new Library();

            // Add some books to the library
            library.AddBook("Science Fiction", new Book("Dune"));
            library.AddBook("Science Fiction", new Book("Hyperion"));
            library.AddBook("Fantasy", new Book("Game of Thrones"));
            library.AddBook("Fantasy", new Book("The Lord of The Rings"));
            library.AddBook("Non-Fiction", new Book("Clean Code"));

            // List all books in a specific genre
            Console.WriteLine("\nListing books in 'Science Fiction' genre:");
            library.ListBooksByGenre("Science Fiction");

            // Remove a book from a specific genre
            library.RemoveBook("Fantasy", "The Hobbit");

            // List all books in the library
            Console.WriteLine("\nListing all books in the library:");
            library.ListAllBooks();
        }
    }
}