using System.Globalization;

namespace CashFlow.API.Middleware;

public class CultureMiddleware(RequestDelegate next)
{
    public async Task Invoke(HttpContext context)
    {
        var culture = context.Request.Headers.AcceptLanguage.FirstOrDefault();
        CultureInfo cultureInfo = new("en");

        if (string.IsNullOrWhiteSpace(culture) == false)
            cultureInfo = new CultureInfo(culture);

        CultureInfo.CurrentCulture = cultureInfo;
        CultureInfo.CurrentUICulture = cultureInfo;
        await next(context);
    }
}