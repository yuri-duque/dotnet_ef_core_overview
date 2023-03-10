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
