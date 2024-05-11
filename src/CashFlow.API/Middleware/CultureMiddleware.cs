using System.Globalization;

namespace CashFlow.API.Middleware;

public class CultureMiddleware(RequestDelegate next)
{
    public async Task Invoke(HttpContext context)
    {
        var supportedLanguages = CultureInfo.GetCultures(CultureTypes.AllCultures).ToList();
        var requestedCulture = context.Request.Headers.AcceptLanguage.FirstOrDefault();

        CultureInfo cultureInfo = new("en");

        if (string.IsNullOrWhiteSpace(requestedCulture) == false &&
            supportedLanguages.Exists(language => language.Name.Equals(requestedCulture)))
            cultureInfo = new CultureInfo(requestedCulture);

        CultureInfo.CurrentCulture = cultureInfo;
        CultureInfo.CurrentUICulture = cultureInfo;
        await next(context);
    }
}