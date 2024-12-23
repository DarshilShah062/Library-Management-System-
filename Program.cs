using LibraryManagementSystem.Services;

namespace LibraryManagementSystem 
{
    public class Program
    {
        private static LibraryService _libraryService = new LibraryService();

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=== Library Management System ===");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. View All Books");
                Console.WriteLine("3. Add Member");
                Console.WriteLine("4. View All Members");
                Console.WriteLine("5. Exit");
                Console.Write("\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        AddBook();
                        break;
                    case "2":
                        ViewAllBooks();
                        break;
                    case "3":
                        AddMember();
                        break;
                    case "4":
                        ViewAllMembers();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        private static void AddBook()
        {
            Console.WriteLine("\n=== Add New Book ===");
            Console.Write("Enter Title: ");
            string title = Console.ReadLine() ?? "";
            Console.Write("Enter Author: ");
            string author = Console.ReadLine() ?? "";

            if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(author))
            {
                _libraryService.AddBook(title, author);
                Console.WriteLine("Book added successfully!");
            }
            else
            {
                Console.WriteLine("Title and Author cannot be empty!");
            }
        }

        private static void ViewAllBooks()
        {
            Console.WriteLine("\n=== All Books ===");
            var books = _libraryService.GetAllBooks();
            if (books.Any())
            {
                foreach (var book in books)
                {
                    Console.WriteLine($"ID: {book.Id} - '{book.Title}' by {book.Author}");
                }
            }
            else
            {
                Console.WriteLine("No books found in the library.");
            }
        }

        private static void AddMember()
        {
            Console.WriteLine("\n=== Add New Member ===");
            Console.Write("Enter Name: ");
            string name = Console.ReadLine() ?? "";

            if (!string.IsNullOrWhiteSpace(name))
            {
                _libraryService.AddMember(name);
                Console.WriteLine("Member added successfully!");
            }
            else
            {
                Console.WriteLine("Name cannot be empty!");
            }
        }

        private static void ViewAllMembers()
        {
            Console.WriteLine("\n=== All Members ===");
            var members = _libraryService.GetAllMembers();
            if (members.Any())
            {
                foreach (var member in members)
                {
                    Console.WriteLine($"ID: {member.Id} - {member.Name}");
                }
            }
            else
            {
                Console.WriteLine("No members found in the library.");
            }
        }
    }
}