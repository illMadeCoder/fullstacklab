using System.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", 
  (HttpContext context) => {
    context.Response.ContentType ="text/html";
    return File.ReadAllText(@".\ClientApp\public\index.html");
  }
);

app.MapGet("/info", () => "info");

Console.WriteLine("test");
Console.WriteLine(File.Exists(@".\ClientApp\public\index.html"));

app.Run();
