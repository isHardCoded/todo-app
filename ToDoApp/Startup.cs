namespace ToDoApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) 
        {
            
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", () => "Hello World!");
                endpoints.MapControllers();
            });
        }
    }
}
