var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{action}",
    defaults: new { controller = "Home", action = "Index" });

app.Run();
