using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<YoloDbContext>(opts => opts.UseSqlServer(builder.Configuration.GetConnectionString("SQL")));
var app = builder.Build();

// Weird. The type "HttpContext" is required to be able to return "item"
// If the type is omitted (even though it's the same type?), you can't return "item", only Task
// Even if you go "Task.FromResult(item)" nothing is sent back in the response.
// So explicit type it is.
app.MapGet("/api/items", (HttpContext context) =>
{
    var dbContext = context.RequestServices.GetRequiredService<YoloDbContext>();
    var item = dbContext.Yolo.First();
    return item;
});

app.Run();
