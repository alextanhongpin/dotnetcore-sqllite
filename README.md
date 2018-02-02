# DBService

Sample service that uses EF Core 2.0.


## Init

```bash
$ dotnet new webapi -o DBService
```

## Add Package

Install `Microsoft.EntityFrameworkCore.Sqlite` and `Microsoft.EntityFrameworkCore.Design`.

```bash
$ dotnet add package Microsoft.EntityFrameworkCore.Sqlite
$ dotnet add package Microsoft.EntityFrameworkCore.Design
```

Manually edit `ConsoleApp.SQLite.csproj` to add a DotNetCliToolReference to `Microsoft.EntityFrameworkCore.Tools.DotNet`:

```xml
<ItemGroup>
  <DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="2.0.0" />
</ItemGroup>
```


## Create the Database

```bash
# Scaffold a migration and create the initial set of tables for the model
$ dotnet ef migrations add InitialCreate

# Apply new migration to the database. 
# This command creates the databases before applying migrations.
$ dotnet ef database update
```