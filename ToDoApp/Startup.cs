using Microsoft.EntityFrameworkCore;
using ToDoApp.DataAccess;

namespace ToDoApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddDbContext<ToDoDbContext>(optionsBuilder =>
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=rootroot;Database=postgres;");
            });

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) 
        {

            app.UseSwagger();
            app.UseSwaggerUI();
            
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", () => "Hello World!");
                endpoints.MapControllers();
            });
        }
    }
}
