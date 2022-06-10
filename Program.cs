var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", 
  (HttpContext context) => {
    context.Response.ContentType = "text/html";
    return File.ReadAllText(Path.Combine(".", "ClientApp", "public", "index.html"));
  }
);

app.MapGet("/info", () => "info");

Console.WriteLine(Path.GetFullPath(Path.Combine(".", "ClientApp", "public", "index.html")));
Console.WriteLine(File.Exists(Path.Combine(".", "ClientApp", "public", "index.html")));

app.Run();
