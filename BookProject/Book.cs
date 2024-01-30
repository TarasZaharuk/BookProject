
namespace BookProject
{
    public class Book
    {
        private int? _rating;
        private const int _countOfSymbolsPerPage = 1000;
        private int _countOfSymbolsInWordsPerPage;
        private int _numberOfWord;
        private List<Page> _pages = new List<Page>();
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
            do
            {
                if (text.Length < _countOfSymbolsPerPage)
                {
                    _pages.Add(new Page { Text = text });
                    break;
                }
                int firstSpaceIndex = text.AsSpan().Slice(0, _countOfSymbolsPerPage).LastIndexOf(' ');
                _pages.Add(new Page { Text = new string(text.Take(firstSpaceIndex).ToArray()) });
                text = text.Remove(0, firstSpaceIndex);
            } while (text.Length != 0);
        }
        public int CountOfPages { get { return _pages.Count; } }

        public string GetText(int index)
        {
            if (index < _pages.Count)
            {
                return _pages[index].Text;
            }
            return $"Index must be from {0} to {_pages.Count - 1} !";
        }
    }
}
