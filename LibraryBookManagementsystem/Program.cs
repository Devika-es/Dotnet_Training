// See https://aka.ms/new-console-template for more information
namespace LibraryBookManagementsystem;
public class Program
{
    public static void Main()
    {
        Catalog<Book> library = new Catalog<Book>();

Book book1 = new Book 
{ 
    ISBN = "978-3-16-148410-0", 
    Title = "C# Programming", 
    Author = "John Sharp", 
    Genre = "Programming" 
};

library.AddItem(book1);

var programmingBooks = library["Programming"];
Console.WriteLine(programmingBooks.Count); 

var johnsBooks = library.FindBooks(b => b.Author.Contains("John"));
Console.WriteLine(johnsBooks.Count()); 
    }
}