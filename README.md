# Library Management System

## Overview

The Library Management System is a console-based application that allows users to manage books and members in a library. It provides functionalities to add books, view all books, add members, view all members, and remove books.

## Dependencies

The project relies on the following dependencies:

- [.NET 9.0](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Microsoft.EntityFrameworkCore](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/9.0.0)
- [Microsoft.EntityFrameworkCore.Design](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design/9.0.0)
- [Microsoft.EntityFrameworkCore.Sqlite](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Sqlite/9.0.0)
- [Microsoft.NET.Test.Sdk](https://www.nuget.org/packages/Microsoft.NET.Test.Sdk/17.12.0)
- [xunit](https://www.nuget.org/packages/xunit/2.9.2)
- [xunit.runner.visualstudio](https://www.nuget.org/packages/xunit.runner.visualstudio/3.0.0)

## Tools Needed

To run and develop this project, you need to have the following tools installed:

- [Visual Studio Code](https://code.visualstudio.com/)
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [SQLite](https://www.sqlite.org/download.html)

## Database Connection

The project uses SQLite as the database provider. The connection string is configured in the `LibraryContext` class:

```csharp
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseSqlite("Data Source=library.db");
}
```

## Project Structure

```
LibraryManagementSystem/
├── bin/
├── Data/
│   └── LibraryContext.cs
├── Models/
│   ├── Book.cs
│   └── Member.cs
├── obj/
├── Services/
│   └── LibraryService.cs
├── Program.cs
├── LibraryManagementSystem.csproj
└── Readme.md
```

## Running the Project

1. **Clone the repository:**

   ```sh
   git clone https://github.com/your-repo/LibraryManagementSystem.git
   cd LibraryManagementSystem
   ```

2. **Restore dependencies:**

   ```sh
   dotnet restore
   ```

3. **Build the project:**

   ```sh
   dotnet build
   ```

4. **Run the project:**

   ```sh
   dotnet run
   ```

## Committing Changes to GitHub

To commit all of the changes you recently made to GitHub, follow these steps:

1. **Stage all changes:**

   ```sh
   git add .
   ```

2. **Commit the changes with a message:**

   ```sh
   git commit -m "Describe your changes here"
   ```

3. **Push the changes to the remote repository:**

   ```sh
   git push origin main
   ```

   Replace `main` with the name of your branch if you are not using the main branch.

## How It Works

The Library Management System allows you to manage books and members in a library. The main features include:

1. **Add Book**: Allows you to add a new book to the library by entering the title and author.
2. **View All Books**: Displays a list of all books currently in the library.
3. **Add Member**: Allows you to add a new member to the library by entering their name.
4. **View All Members**: Displays a list of all members currently registered in the library.
5. **Remove Book**: Allows you to remove a book from the library by entering its ID.

### Main Program Flow

The main program flow is handled in the `Program.cs` file. It uses a simple console interface to interact with the user. The user can select options from the menu to perform different actions. The `LibraryService` class is used to manage the books and members.

### LibraryService

The `LibraryService` class provides methods to add, retrieve, and remove books and members. It uses in-memory collections to store the data.

### Example Usage

1. **Add a Book**:
   - Select option `1` from the menu.
   - Enter the title and author of the book.
   - The book will be added to the library.

2. **View All Books**:
   - Select option `2` from the menu.
   - A list of all books will be displayed.

3. **Add a Member**:
   - Select option `3` from the menu.
   - Enter the name of the member.
   - The member will be added to the library.

4. **View All Members**:
   - Select option `4` from the menu.
   - A list of all members will be displayed.

5. **Remove a Book**:
   - Select option `5` from the menu.
   - Enter the ID of the book to be removed.
   - The book will be removed from the library.

## Contributing

If you would like to contribute to this project, please fork the repository and submit a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
