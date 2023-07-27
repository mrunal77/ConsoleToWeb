internal class Startup
{
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            //endpoints.MapGet("/", async context =>
            //{
            //    await context.Response.WriteAsync("Hello from new web Api");
            //});
        });
    }


    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc();
        services.AddControllers();
    }
}