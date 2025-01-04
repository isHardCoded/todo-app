# ToDoApp

# создал EF-классы для работы с БД (database-first)
```sh
dotnet ef dbcontext scaffold "Host=localhost;Port=5432;Username=postgres;Password=rootroot;Database=postgres;" Npgsql.EntityFrameworkCore.PostgreSQL
```

# Add initial migration
```sh
cd .\ToDoApp.Migrations\
dotnet ef migrations add InitialCreate
```

# Build migration script
```sh
dotnet ef migrations script --idempotent --project ToDoApp.Migrations --startup-project ToDoApp.Migrations --output Databases/ToDoApp.sql
```