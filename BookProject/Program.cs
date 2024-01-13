using BookProject;

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
Page page = new Page();