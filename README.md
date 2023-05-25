# Library Catalog

#### This is an application for tracking books in a library!

#### By Kymani Stephens

## Technologies Used

* C#
* .NET
* SQL
* Entity Framework Core
* ASP.NET Core Identity Framework

## Description

This is an MVC web application that allows you to track and manage books in a library. Librarians that are logged in have the ability to create, read, update, search and list books in the catalog so they can keep track of its inventory. Librarians also have the ability to see a list of all overdue books belonging to the library.

Patrons that are logged in have the ability to check books out, see how many copies of a book the library currently has available, see a history of all the books they have previously borrowed and check due dates on books they are currently borrowing. 

This project was created to practice implementing authentication and authorization, as well as CRUD functionality and various types of database relationships.

## Setup/Installation

### Install Tools

Install the tools that are introduced in [this series of lessons on LearnHowToProgram.com](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c).

### Set up the Databases

Follow the instructions in the LearnHowToProgram.com lesson ["Creating a Test Database: Exporting and Importing Databases with MySQL Workbench"](https://www.learnhowtoprogram.com/c-and-net/database-basics/creating-a-test-database-exporting-and-importing-databases-with-mysql-workbench) to use the `kymani_stephens.sql` file located at the top level of this repo to create a new database in MySQL Workbench with the name `kymani_stephens`.

### Set Up and Run Project

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "Library".
3. Within the production directory "Library", create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL.

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=kymani_stephens;uid=[YOUR-USERNAME];pwd=[YOUR-PASSWORD];"
  }
}
```

5. Within the production directory "Library", run `dotnet watch run` in the command line to start the project in development mode with a watcher.
4. Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/lessons/ redirecting-to-https-and-issuing-a-security-certificate).

## Known Bugs

* No currently known bugs

## License
[MIT](https://opensource.org/license/mit)
<br>
Copyright (c) 2023 Kymani Stephens