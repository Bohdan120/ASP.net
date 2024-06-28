namespace _25._06.Infrastructure
{
    public static class TokenExtensions
    {
        public static IApplicationBuilder UseToken(this IApplicationBuilder builder, string pattern)
        {
            return builder.UseMiddleware<TokenMiddleware>(pattern);
        }
        public static IApplicationBuilder UseMyRouting(this IApplicationBuilder app)
        {
            return app.UseMiddleware<RoutingMiddleware>();
        }
        public static IApplicationBuilder UseLogURL(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LogURLMiddleware>();
        }
    }
}
