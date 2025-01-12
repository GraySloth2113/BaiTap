using System;
using System.Collections.Generic;

interface IBook
{
    string Title { get; set; }
    string Author { get; set; }
    string Publisher { get; set; }
    string ISBN { get; set; }
    int Year { get; set; }
    List<string> Chapters { get; set; }

    void Show(); // Phương thức hiển thị thông tin sách
}
class Book : IBook, IComparable<Book>
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public string ISBN { get; set; }
    public int Year { get; set; }
    public List<string> Chapters { get; set; } = new List<string>();

    public Book(string title, string author, string publisher, string isbn, int year, List<string> chapters)
    {
        Title = title;
        Author = author;
        Publisher = publisher;
        ISBN = isbn;
        Year = year;
        Chapters = chapters;
    }

    // Phương thức hiển thị thông tin sách
    public void Show()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Publisher: {Publisher}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine("Chapters:");
        foreach (var chapter in Chapters)
        {
            Console.WriteLine($"- {chapter}");
        }
        Console.WriteLine();
    }

    // Thực hiện IComparable<Book> để sắp xếp theo tên sách mặc định
    public int CompareTo(Book other)
    {
        return this.Title.CompareTo(other.Title);
    }
}
class BookList
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void ShowBooks()
    {
        foreach (var book in books)
        {
            book.Show();
        }
    }

    // Sắp xếp theo tên sách (mặc định)
    public void SortByTitle()
    {
        books.Sort();
    }

    // Sắp xếp theo tên tác giả
    public void SortByAuthor()
    {
        books.Sort(new SortByAuthor());
    }

    // Sắp xếp theo nhà xuất bản
    public void SortByPublisher()
    {
        books.Sort(new SortByPublisher());
    }

    // Sắp xếp theo năm xuất bản
    public void SortByYear()
    {
        books.Sort(new SortByYear());
    }
}

// Sắp xếp theo tên tác giả (Author)
class SortByAuthor : IComparer<Book>
{
    public int Compare(Book x, Book y)
    {
        return x.Author.CompareTo(y.Author);
    }
}

// Sắp xếp theo nhà xuất bản (Publisher)
class SortByPublisher : IComparer<Book>
{
    public int Compare(Book x, Book y)
    {
        return x.Publisher.CompareTo(y.Publisher);
    }
}

// Sắp xếp theo năm xuất bản (Year)
class SortByYear : IComparer<Book>
{
    public int Compare(Book x, Book y)
    {
        return x.Year.CompareTo(y.Year);
    }
}


class Program
{
    static void Main()
    {
        BookList bookList = new BookList();

        bookList.AddBook(new Book("C# Programming", "John Doe", "TechBooks", "123456", 2020, new List<string> { "Chapter 1", "Chapter 2" }));
        bookList.AddBook(new Book("Java Fundamentals", "Alice Smith", "CodeWorld", "789012", 2018, new List<string> { "Intro", "OOP" }));
        bookList.AddBook(new Book("Python Basics", "Bob Johnson", "TechBooks", "345678", 2019, new List<string> { "Getting Started", "Data Structures" }));

        Console.WriteLine("\n📚 Danh sách gốc:");
        bookList.ShowBooks();

        Console.WriteLine("\n🔹 Sắp xếp theo Tên Sách:");
        bookList.SortByTitle();
        bookList.ShowBooks();

        Console.WriteLine("\n🔹 Sắp xếp theo Tác Giả:");
        bookList.SortByAuthor();
        bookList.ShowBooks();

        Console.WriteLine("\n🔹 Sắp xếp theo Nhà Xuất Bản:");
        bookList.SortByPublisher();
        bookList.ShowBooks();

        Console.WriteLine("\n🔹 Sắp xếp theo Năm Xuất Bản:");
        bookList.SortByYear();
        bookList.ShowBooks();
    }


}

