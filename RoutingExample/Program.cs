var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Enable routing
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    // Add your end points
});

app.Run();
