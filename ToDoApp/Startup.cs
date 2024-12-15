using Microsoft.EntityFrameworkCore;
using ToDoApp.DataAccess;

namespace ToDoApp
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddDbContext<ToDoDbContext>(optionsBuilder =>
            {
                optionsBuilder.UseNpgsql(_configuration.GetConnectionString("MyDbConnection"));
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
