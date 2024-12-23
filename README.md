# Library Management System

## Overview

The Library Management System is a console-based application that allows users to manage books and members in a library. It provides functionalities to add books, view all books, add members, and view all members.

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
LibraryManagementSystem/
    bin/
    Data/
        LibraryContext.cs
    Models/
        Book.cs
        Member.cs
    obj/
    Services/
        LibraryService.cs
    Program.cs
    LibraryManagementSystem.csproj

    ##Running the Project

    git clone https://github.com/your-repo/LibraryManagementSystem.git
cd LibraryManagementSystem
