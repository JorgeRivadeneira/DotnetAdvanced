using Microsoft.AspNetCore.Mvc.Filters;

namespace SampleAttributes.Filters
{
    public class LoggingFilter : IAsyncActionFilter
    {
        private readonly ILogger<LoggingFilter> _logger;

        public LoggingFilter(ILogger<LoggingFilter> logger)
        {
            _logger = logger;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            _logger.LogInformation("Before endpoint stuff");

            await next();

            _logger.LogInformation("After endpoint stuff");
        }
    }
}
