var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async (context, next) =>
{
    Endpoint? endPoint = context.GetEndpoint();
    if (endPoint != null)
        await context.Response.WriteAsync($"Endpoint: {endPoint.DisplayName}\n");
    await next(context);
});

// Enable routing
app.UseRouting();

app.Use(async (context, next) =>
{
    Endpoint? endPoint = context.GetEndpoint();
    if (endPoint != null)
        await context.Response.WriteAsync($"Endpoint: {endPoint.DisplayName}\n");
    await next(context);
});

app.UseEndpoints(endpoints =>
{
    // Add your end points
    // Method: GET. URL: http://localhost:{port}/map1
    endpoints.MapGet("map1", async (context) =>
    {
        await context.Response.WriteAsync("In Map 1\n");
    });

    // Method: POST. URL: http://localhost:{port}/map2
    endpoints.MapPost("map2", async (context) =>
    {
        await context.Response.WriteAsync("In Map 2\n");
    });
});

app.Run(async context =>
{
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});
app.Run();
