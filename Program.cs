var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var publicPath = Path.GetFullPath(Path.Combine(".", "ClientApp", "public"));
var indexPath = Path.Combine(publicPath, "index.html");
if (File.Exists(indexPath) == false)
{
  throw new Exception($"Public File Path {publicPath} not found");
}


// app.MapGet("/", 
//   (HttpContext context) => {
//     context.Response.ContentType = "text/html";
//     return File.ReadAllText(indexPath));
//   }
// );

app.MapGet("/info", () => "info");

app.Run();
