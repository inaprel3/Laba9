namespace Laba9.Models
{
    public class Weather
    {
        public string? Name { get; set; }
        public MainDetails? Main { get; set; }
        public WeatherDetails[]? WeatherCondition { get; set; } 
    }

    public class MainDetails
    {
        public double Temp { get; set; }
    }

    public class WeatherDetails
    {
        public string? Description { get; set; }
    }
}