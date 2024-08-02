using Bibliotekssystem;

namespace UnitTest_Bibliotekssystem
{
    public class LibraryTest
    {
        [Fact]
        public void LibraryAddAndRemove()
        {
            Bibliotekssystem.Library library = new();
            Bibliotekssystem.Book book = new("jhon doe second","jhon doe","B2012",true);
            bool status = library.AddBook(book);
            Assert.True(status);
            bool status2 = library.RemoveBook(book);
            Assert.True(status2);
        }
        [Fact]
        public void LibraryRegisterUser() 
        { 
            Bibliotekssystem.Library library = new();
            Bibliotekssystem.User user = new("Jhon doe","U.ID1");
            bool status = library.RegisterUser(user);
            Assert.True(status);
        }
        [Fact]
        public void LibraryGetBookByISBN()
        {
            Bibliotekssystem.Library library = new();

            Book book1 = new Book("C# Programming", "John Doe", "1234567890", true);
            Book book2 = new Book("ASP.NET MVC", "Jane Doe", "0987654321", true);
            Book book3 = new Book("Learn LINQ", "Alice Smith", "1122334455", true);
            Book book4 = new Book("Entity Framework Core", "Bob Johnson", "2233445566", true);
            Book book5 = new Book("Blazor WebAssembly", "Carol Brown", "3344556677", true);

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);

            Book book = library.FindBookByISBN(book2.ISBN);
            Assert.Equal("0987654321",book.ISBN);
        }
    }
}