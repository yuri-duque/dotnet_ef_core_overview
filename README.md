


# Clean Architecture - Entity Framework

In this document we will see how to create a simple clean architecture with .Net 7 and Entity Framework.

[Clean Architecture ](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)


## Creating new project

In this example we will create a simple web api, so we need create a new web api project.

<img  src="https://user-images.githubusercontent.com/26638073/226075493-747bc1ec-5e00-465b-be15-e11b9c221154.png"  alt="Image"  width="25%" style="text-align: center;">


## Creating a project Structure

In our project, we will have four different projects each one for each different layer.

<img  src="https://user-images.githubusercontent.com/26638073/226077222-5cd3bfd9-ba08-4e54-b084-4b05b1c17a45.png"  alt="Image"  width="50%" style="text-align: center;">

<img  src="https://user-images.githubusercontent.com/26638073/226077333-149c1e89-d841-4c6f-96a3-8982fcf12a40.png"  alt="Image"  width="25%" style="text-align: center;">


### Controller
The Controller layer is the conductor of operations for a request. It controls the transaction scope and manages the session-related information for the request. The controller receives the requests and calls the functions that are responsible for the business rules and returns a response.

This Layer already have created when we created a web API project.


### Service
The Service layer is responsible to have all business rules, it is enabled to comunicate with all other layers


### Domain
The Domain layer is responsible to have all models for the project, it is the way to convert the DTOs from the controller and Database to use in the service layer


### Repository
The Repository layer is responsible to communicate the application to the database, this layer is accessible only in the Service layer.


# MySql

123

mysql Context : https://www.nuget.org/packages/Pomelo.EntityFrameworkCore.MySql

EF Core get started : https://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-7.0&tabs=visual-studio

add .gitgnore

```csharp
dotnet new gitignore
```

create a connection string on file `appsettings.json`

```json
"ConnectionStrings": {
    "Context": "Server=root@localhost:3306;Database=dotnet7overview;Uid=root;Pwd=123123;"
}
```

get the connectionString on program.cs

```csharp
var connectionString = builder.Configuration.GetConnectionString("Context");
```

create a Context

```csharp
using Microsoft.EntityFrameworkCore;

namespace Controller.Repository
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
        }
    }

    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
```

set a mysql server version on program.cs

```csharp
var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
```

add the context on program.cs


![image](https://user-images.githubusercontent.com/26638073/226075493-747bc1ec-5e00-465b-be15-e11b9c221154.png)
![image](https://user-images.githubusercontent.com/26638073/226077222-5cd3bfd9-ba08-4e54-b084-4b05b1c17a45.png)
![image](https://user-images.githubusercontent.com/26638073/226077333-149c1e89-d841-4c6f-96a3-8982fcf12a40.png)
