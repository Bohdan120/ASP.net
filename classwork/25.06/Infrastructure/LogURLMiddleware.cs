namespace _25._06.Infrastructure
{
    public class LogURLMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<LogURLMiddleware> _logger;

        public LogURLMiddleware(RequestDelegate next, ILogger<LogURLMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            _logger.LogInformation("Request URL: {URL}", context.Request.Path);

            await _next(context);
        }
    }
}
