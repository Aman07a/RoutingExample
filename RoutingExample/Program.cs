var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Enable routing
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    // // Eg: files/sample.txt
    // endpoints.Map("files/{filename}.{extension}", async context =>
    // {
    //     string? fileName = Convert.ToString(context.Request.RouteValues["filename"]);
    //     string? extension = Convert.ToString(context.Request.RouteValues["extension"]);
    //     await context.Response.WriteAsync($"In files - {fileName} - {extension}\n");
    // });

    // // Eg: employee/profile/john
    // endpoints.Map("employee/profile/{EmployeeName=harsha}", async context =>
    // {
    //     string? employeeName = Convert.ToString(context.Request.RouteValues["employeeName"]);
    //     await context.Response.WriteAsync($"In Employee profile - {employeeName}\n");
    // });

    // // Eg: products/details/id
    // endpoints.Map("products/details/{id=1}", async context =>
    // {
    //     int id = Convert.ToInt32(context.Request.RouteValues["id"]);
    //     await context.Response.WriteAsync($"Product details - {id}\n");
    // });

    // // Eg: products/details/
    // endpoints.Map("products/details/{id?}", async context =>
    // {
    //     if (context.Request.RouteValues.ContainsKey("id"))
    //     {
    //         int id = Convert.ToInt32(context.Request.RouteValues["id"]);
    //         await context.Response.WriteAsync($"Product details - {id}\n");
    //     }
    //     else
    //     {
    //         await context.Response.WriteAsync($"Product details - id is not supplied\n");
    //     }
    // });

    // // Route constraints
    // // Eg: products/details/
    // endpoints.Map("products/details/{id:int?}", async context =>
    // {
    //     if (context.Request.RouteValues.ContainsKey("id"))
    //     {
    //         int id = Convert.ToInt32(context.Request.RouteValues["id"]);
    //         await context.Response.WriteAsync($"Product details - {id}\n");
    //     }
    //     else
    //     {
    //         await context.Response.WriteAsync($"Product details - id is not supplied\n");
    //     }
    // });

    // // Eg: daily-digest-report/{reportdate}
    // endpoints.Map("daily-digest-report/{reportdate:datetime}", async context =>
    // {
    //     DateTime reportDate = Convert.ToDateTime(context.Request.RouteValues["reportdate"]);
    //     await context.Response.WriteAsync($"In daily-digest-report - {reportDate.ToShortDateString()}");
    // });
});

app.Run(async context =>
{
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});
app.Run();
