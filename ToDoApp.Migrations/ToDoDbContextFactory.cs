using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ToDoApp.DataAccess;

namespace ToDoApp.Migrations;

public class ToDoDbContextFactory : IDesignTimeDbContextFactory<ToDoDbContext>
{
    public ToDoDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ToDoDbContext>();

        optionsBuilder.UseNpgsql(builder =>
        {
            builder.MigrationsAssembly(typeof(ToDoDbContextFactory).Assembly.FullName);

        });

        return new ToDoDbContext(optionsBuilder.Options);
    }
}