var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/call-serviceb", async () =>
{
    var serviceBUrl = Environment.GetEnvironmentVariable("SERVICEB_URL") ?? "http://http://localhost:5001/hello";
    try
    {
        using var http = new HttpClient();
        var resp = await http.GetAsync($"{serviceBUrl}/hello");
        resp.EnsureSuccessStatusCode();
        var content = await resp.Content.ReadAsStringAsync();
        return Results.Ok(content);
    }
    catch (Exception ex)
    {
        return Results.Problem(ex.Message);
    }
});

app.Run();
