using Microsoft.EntityFrameworkCore;
using ToDoApp.DataAccess.Contexts;
using ToDoApp.DataAccess.Repositories;
using ToDoApp.Services;

namespace ToDoApp;

public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(Startup));
        /*services.AddAutoMapper(expression =>
        {
            expression.AddProfile<MapperProfile>();
        });*/
            
        services.AddScoped<ITaskRepository, TaskRepository>();
        services.AddScoped<ITaskService, TaskService>();
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddDbContext<ToDoDbContext>(optionsBuilder =>
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("MyDbConnection"));
        });

        services.AddCors();

    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env) 
    {

        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseCors(builder =>
        {
            builder.WithOrigins("http://localhost:5173") 
                .AllowAnyMethod()
                .AllowAnyHeader();
        });

        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/", () => "Hello World!");
            endpoints.MapControllers();
        });
    }
}