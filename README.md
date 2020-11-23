# BookLibrary
BookLibrary is a one weekend mini project.

This app is a virtual book library that let's you log in/log out, add new book to the collection, edit selected book, reserve a book and show it's details (including reservation list).

## Table of contents
* [Technologies](#technologies)
* [Launch](#launch)

## Technologies
* [.NET 5](https://www.microsoft.com/net/download)
* [Entity Framework Core 5](https://docs.microsoft.com/en-us/ef/core/)
* [Microsoft SQL Server 2019](https://www.microsoft.com/en-us/sql-server/sql-server-2019)
* [Fluent Validation](https://fluentvalidation.net/)

## Launch
1. Download this project/repository.
2. Download and install:
   * [.NET 5 Runtime](https://www.microsoft.com/net/download)
   * [Microsoft SQL Server 2019](https://www.microsoft.com/en-us/sql-server/sql-server-2019)
3. Go to the `src\BookLibrary` and run `Powershell/Command Promp/Terminal` in this location.
4. Type `dotnet ef database update`. This will create the database and apply all migrations.
5. Type `dotnet run`. This will run the server.
6. You can now work with this app.
