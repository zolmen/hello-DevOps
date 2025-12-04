var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello DevOps");
app.MapGet("/info", () => "Hello DevOps info endpoint");

app.Run("http://0.0.0.0:8080");