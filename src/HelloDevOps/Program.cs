var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello DevOps from feature branch");

app.Run("http://0.0.0.0:8080");