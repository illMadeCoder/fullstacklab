var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string baseURL = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).ToString()).ToString()).ToString()).ToString();

app.MapGet("/", 
  (HttpContext context) => {
    context.Response.ContentType = "text/html";
    return File.ReadAllText(Path.Combine(baseURL, "ClientApp", "public", "index.html"));
  }
);

app.MapGet("/info", () => "info");
Console.WriteLine(baseURL);
Console.WriteLine(Path.GetFullPath(Path.Combine(".", "ClientApp", "public", "index.html")));
Console.WriteLine(File.Exists(Path.Combine(".", "ClientApp", "public", "index.html")));

app.Run();
