namespace LibrarySystem.Entities;

public class Book : LibraryItem
{
    //fields
    private string _author;
    private int _pages;
    private string _genre;
    
    //properties
    public string Author
    {
        get
        {
            return this._author;
        }
        set
        {
            this._author = value;
        }
    }

    public int Pages
    {
        get
        {
            return this._pages;
        }
        set
        {
            this._pages = value;
        }
    }

    public string Genre
    {
        get
        {
            return this._genre;
        }
        set
        {
            this._genre = value;
        }
    }
    
    //constructor
    public Book(string title, int year, string publisher, int availableCopies, string author, int pages, string genre) 
        : base(title, year, publisher, availableCopies)
    {
        this._author = author;
        this._pages = pages;
        this._genre = genre;
    }
}