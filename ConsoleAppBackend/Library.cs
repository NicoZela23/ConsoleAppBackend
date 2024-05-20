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
    }

    public void RemoveBook(string genre, string title)
    {
        if (booksInLibrary.ContainsKey(genre))
        {
            Book bookToRemove = booksInLibrary[genre];
        }
    }
}