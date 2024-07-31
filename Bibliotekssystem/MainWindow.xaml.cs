using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bibliotekssystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Create a library instance
            Library library = new Library();

            // Preset books to add to the library
            Book book1 = new Book("C# Programming", "John Doe", "1234567890", true);
            Book book2 = new Book("ASP.NET MVC", "Jane Doe", "0987654321", true);
            Book book3 = new Book("Learn LINQ", "Alice Smith", "1122334455", true);
            Book book4 = new Book("Entity Framework Core", "Bob Johnson", "2233445566", true);
            Book book5 = new Book("Blazor WebAssembly", "Carol Brown", "3344556677", true);

            // Add books to the library
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);

            // Preset users to register in the library
            User user1 = new User { Name = "Alice", UserID = "U001" };
            User user2 = new User { Name = "Bob", UserID = "U002" };
            User user3 = new User { Name = "Charlie", UserID = "U003" };

            // Register users in the library
            library.RegisterUser(user1);
            library.RegisterUser(user2);
            library.RegisterUser(user3);
        }

        private void Button_Books_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_User_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}