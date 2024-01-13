
string path = "Tesla.txt";
string text;
using StreamReader streamReader = new StreamReader(path);
{
    text = streamReader.ReadToEnd();
}
Book book = new Book("C# Book", text, "Alex Shevchuk", new DateOnly(2024, 1, 7));
Console.WriteLine(book.CountOfPages);
Console.WriteLine(book.GetText(29));
Console.ReadKey();
class Book
{
    private int? _rating;
    private const int _countOfSymbolsPerPage = 200;
    private List<Page> pages = new List<Page>();
    public Book(string name, string text, string author, DateOnly dateOfPublishing)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new Exception("Name is empty");
        if (string.IsNullOrWhiteSpace(author))
            throw new Exception("Author is empty");
        if (dateOfPublishing.Year < 1991 || dateOfPublishing.Year > DateTime.Now.Year)
            throw new Exception($"date of puplishing must be more than 1991 and less than {DateTime.Now.Year}");
        if (string.IsNullOrWhiteSpace(text))
            throw new Exception("text should not be empty");
        
        DateOfPublishing = dateOfPublishing;
        Author = author;
        Name = name;
       
        InnitPages(text);
    }
    public int? Rating
    {
        get => _rating;
        set
        {
            if (value >= 1 && value <= 5)
                _rating = value;
            else
                throw new Exception("Rating can be from 1 to 5");
        }
    }
    public string Author { get; private set; }
    public DateOnly DateOfPublishing { get; private set; }
    public string Name { get; private set; }
    public string GetInfo() => $"{Name}-{Author}-{DateOfPublishing.Year}";
    private void InnitPages(string text)
    {
        int countOfPage = Convert.ToInt16(Math.Ceiling((double)text.Length/_countOfSymbolsPerPage));
        for (int i = 0; i < countOfPage; i++)
        {
            pages.Add(new Page
            {
                Index = i,
                Text = new string(text.Skip(i * _countOfSymbolsPerPage).Take(_countOfSymbolsPerPage).ToArray()),
            });
        }

    }
    public int CountOfPages { get { return pages.Count; } }

    public string GetText(int index)
    {
        if (index < pages.Count)
        {
            return pages[index].Text;
        }
        return $"Index must be from {0} to {pages.Count - 1} ";
    }
    class Page
    {
        public string Text { get; set; }
        public int Index { get; set; }
    }
}
