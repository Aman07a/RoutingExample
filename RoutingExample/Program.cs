var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Enable routing
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    // Add your end points
    // Method: GET. URL: http://localhost:{port}/map1
    endpoints.MapGet("map1", async (context) =>
    {
        await context.Response.WriteAsync("In Map 1");
    });

    // Method: POST. URL: http://localhost:{port}/map2
    endpoints.MapPost("map2", async (context) =>
    {
        await context.Response.WriteAsync("In Map 2");
    });
});

app.Run(async context =>
{
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});
app.Run();
