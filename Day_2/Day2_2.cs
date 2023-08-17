using System;
using System.Collections.Generic;

namespace LibraryManagement
{
    class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string Genre { get; }
        public int QuantityAvailable { get; private set; }

        public Book(string title, string author, string genre, int quantityAvailable)
        {
            Title = title;
            Author = author;
            Genre = genre;
            QuantityAvailable = quantityAvailable;
        }

        public void DecreaseQuantity(int count)
        {
            QuantityAvailable -= count;
        }

        public void IncreaseQuantity(int count)
        {
            QuantityAvailable += count;
        }
    }

    class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Library Book List:");
            foreach (Book book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Quantity Available: {book.QuantityAvailable}");
            }
        }

        public List<Book> SearchByTitle(string title)
        {
            List<Book> foundBooks = new List<Book>();
            foreach (Book book in books)
            {
                if (book.Title.Contains(title, StringComparison.OrdinalIgnoreCase))
                {
                    foundBooks.Add(book);
                }
            }
            return foundBooks;
        }

        public List<Book> SearchByAuthor(string author)
        {
            List<Book> foundBooks = new List<Book>();
            foreach (Book book in books)
            {
                if (book.Author.Contains(author, StringComparison.OrdinalIgnoreCase))
                {
                    foundBooks.Add(book);
                }
            }
            return foundBooks;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book("Book Title 1", "Author A", "Fiction", 5);
            library.AddBook(book1);

            Book book2 = new Book("Book Title 2", "Author B", "Non-fiction", 3);
            library.AddBook(book2);

            library.DisplayBooks();

            Console.Write("Search books by title: ");
            string titleSearch = Console.ReadLine();
            List<Book> foundBooksByTitle = library.SearchByTitle(titleSearch);
            Console.WriteLine($"Found {foundBooksByTitle.Count} books by title:");
            foreach (Book book in foundBooksByTitle)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Quantity Available: {book.QuantityAvailable}");
            }

            Console.Write("Search books by author: ");
            string authorSearch = Console.ReadLine();
            List<Book> foundBooksByAuthor = library.SearchByAuthor(authorSearch);
            Console.WriteLine($"Found {foundBooksByAuthor.Count} books by author:");
            foreach (Book book in foundBooksByAuthor)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Quantity Available: {book.QuantityAvailable}");
            }
        }
    }
}
