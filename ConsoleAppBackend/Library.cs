public class Library
{
    private Dictionary<string, List<Book>> booksInLibrary;

    public Library() {
        booksInLibrary = new Dictionary<string, List<Book>>();
    }

    public void AddBook(string genre, Book book)
    {
        if (!booksInLibrary.ContainsKey(genre))
        {
            booksInLibrary[genre] = new List<Book>();
        }
        booksInLibrary[genre].Add(book);
        Console.WriteLine($"Added '{book.Title}' to the '{genre}' genre.");
    }

    public void RemoveBook(string genre, string title)
    {
        if (booksInLibrary.ContainsKey(genre))
        {
            Book bookToRemove = booksInLibrary[genre].Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (bookToRemove != null)
            {
                booksInLibrary[genre].Remove(bookToRemove);
                Console.WriteLine($"Removed '{title}' from the '{genre}' genre.");
            }
            else
            {
                Console.WriteLine($"Book '{title}' not found in the '{genre}' genre.");
            }
        }
        else
        {
            Console.WriteLine($"Genre '{genre}' not found.");
        }
    }
    public void ListBooksByGenre(string genre)
    {
        if (booksInLibrary.ContainsKey(genre))
        {
            Console.WriteLine($"Books in the '{genre}' genre:");
            foreach (var book in booksInLibrary[genre])
            {
                Console.WriteLine(book);
            }
        }
        else
        {
            Console.WriteLine($"Genre '{genre}' not found.");
        }
    }
    public void ListAllBooks()
    {
        Console.WriteLine("Listing all books in the library:");
        foreach (var genre in booksInLibrary.Keys)
        {
            Console.WriteLine($"\nGenre: {genre}");
            foreach (var book in booksInLibrary[genre])
            {
                Console.WriteLine(book);
            }
        }
    }
}
}