namespace LibrarySystem.Entities;

public abstract class LibraryItem
{
    //fields
    public Guid Id { get; private set; } = Guid.NewGuid();
    private string _title;
    private int _year;
    private string _publisher;
    private int _availableCopies;
    
    //properties
    public string Title
    {
        get
        {
            return this._title;
        }
        set
        {
            this._title = value;
        }
    }
    public int Year
    {
        get
        {
            return this._year;
        }
        set
        {
            this._year = value;
        }
    }
    public string Publisher
    {
        get
        {
            return this._publisher;
        }
        set
        {
            this._publisher = value;
        }
    }
    public int AvailableCopies
    {
        get
        {
            return this._availableCopies;
        }
        set
        {
            this._availableCopies = value;
        }
    }
    
    //constructor
    protected LibraryItem(string title, int year, string publisher, int availableCopies)
    {
        this._title = title;
        this._year = year;
        this._publisher = publisher;
        this._availableCopies = availableCopies;
    }
}