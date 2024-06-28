using System.Globalization;
using System.Text.RegularExpressions;

namespace Lesson13PU221ASP.Infrastructure
{
    public class CultureMiddleware
    {
        private readonly RequestDelegate _next;

        public CultureMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            var lang = context.Request.Headers["Accept-Language"].ToString();
            
            var lanq =lang.Split(',')[0];
            if (!String.IsNullOrEmpty(lang))
            {
                try
                {
                    CultureInfo.CurrentCulture = new CultureInfo(lang);
                    CultureInfo.CurrentUICulture = new CultureInfo(lang);
                }
                catch(CultureNotFoundException) { }
               
            }
            await _next.Invoke(context);
        }
    }
}
