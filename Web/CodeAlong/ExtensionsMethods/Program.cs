using extensionMethods.extensions;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");


app.MapGet("/search", (HttpContext httpContext) => {
    var searchTerm = httpContext.GetQueryParameter("q", "sökning");
    return Results.Ok($"Söker efter: {searchTerm}");
});

app.Run();
