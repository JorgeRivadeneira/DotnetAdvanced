using Microsoft.AspNetCore.Mvc;
using SampleAttributes.Filters;

namespace SampleAttributes
{
    public class WeatherForecast
    {
        [ServiceFilter(typeof(LoggingFilter)]
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
