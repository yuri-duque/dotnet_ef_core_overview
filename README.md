# MySql

add .gitgnore

```csharp
dotnet new gitignore
```

create a connection string on file `appsettings.json`

```json
...
"ConnectionStrings": {
    "Context": "Server=root@localhost:3306;Database=dotnet7overview;Uid=root;Pwd=123123;"
}
...
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
