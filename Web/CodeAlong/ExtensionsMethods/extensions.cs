namespace extensionMethods.extensions;

public static class StringExtension 
{
    public static bool IsValidEmail(this string email)
    {
        return email.Contains("@") && email.Contains(".");
    }
}


public static class HttpContextExtensions
{
    public static string GetQueryParameter(this HttpContext httpContext, string key, string defaultValue = "")
    {
        return httpContext.Request.Query.TryGetValue(key, out var value) ? value.ToString() : defaultValue;
    }

    public static bool IsJsonRequest(this HttpContext httpContext)
    {
        return httpContext.Request.Headers["Content-Type"].ToString().Contains("application(json)", StringComparison.OrdinalIgnoreCase);
    }
}