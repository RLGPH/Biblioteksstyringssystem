using Bibliotekssystem;

namespace UnitTest_Bibliotekssystem
{
    public class UserTest
    {
        [Fact]
        public void Borrowtest()
        {
            Bibliotekssystem.Library library = new();
            User user = new("Jhon Doe","B1424");

            Book book = new("JDoe", "Jhon Doe", "B1235", true);
            Book book1 = new Book("C# Programming", "John Doe", "1234567890", true);
            Book book2 = new Book("ASP.NET MVC", "Jane Doe", "0987654321", true);
            Book book3 = new Book("Learn LINQ", "Alice Smith", "1122334455", true);
            Book book4 = new Book("Entity Framework Core", "Bob Johnson", "2233445566", true);
            Book book5 = new Book("Blazor WebAssembly", "Carol Brown", "3344556677", true);

            library.AddBook(book);
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);

            library.RegisterUser(user);

            bool status = user.BorrowBook(library, "B1235");
            Assert.True(status);

            Book testbook= library.FindBookByISBN("B1235");
            Assert.False(testbook.IsAvailable);
        }
        [Fact]
        public void returntest()
        {
            Bibliotekssystem.Library library = new();
            User user = new("Jhon Doe", "U1424");

            Book book = new("JDoe", "Jhon Doe", "B1235", true);
            Book book1 = new Book("C# Programming", "John Doe", "B1234", true);
            Book book2 = new Book("ASP.NET MVC", "Jane Doe", "B0987", true);
            Book book3 = new Book("Learn LINQ", "Alice Smith", "B1122", true);
            Book book4 = new Book("Entity Framework Core", "Bob Johnson", "B2233", true);
            Book book5 = new Book("Blazor WebAssembly", "Carol Brown", "B3344", true);

            library.AddBook(book);
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);

            library.RegisterUser(user);

            user.BorrowBook(library, "B1235");

            bool Status = user.ReturnBook(library, "B1235");
            Assert.True(Status);

            Book testbook = library.FindBookByISBN("B1235");
            Assert.True(testbook.IsAvailable);
        }
    }
}
