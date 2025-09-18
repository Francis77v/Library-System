namespace LibrarySystem.Entities;

public class Magazine : LibraryItem
{
    // fields
    private string _issueNumber;
    private string _month;
    private string _editor;
    private string _category;
    
    //properties
    public string IssueNUmber
    {
        get
        {
            return this._issueNumber;
        }
        set
        {
            this._issueNumber = value;
        }
    }

    public string Month
    {
        get
        {
            return this._month;
        }
        set
        {
            this._month = value;
        }
    }

    public string Editor
    {
        get
        {
            return this._editor;
        }
        set
        {
            this._editor = value;
        }
    }
    public string Category
    {
        get
        {
            return this._category;
        }
        set
        {
            this._category = value;
        }
    }

    public Magazine(string title, int year, string publisher, int availableCopies, string issueNumber, string month,
        string editor, string category)
        : base(title, year, publisher, availableCopies)
    {
        this._issueNumber = issueNumber;
        this._editor = editor;
        this._month = month;
        this._category = category;
    }
}