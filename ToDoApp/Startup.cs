namespace ToDoApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

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
