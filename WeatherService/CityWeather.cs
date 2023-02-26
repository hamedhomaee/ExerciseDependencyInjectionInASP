using DependencyInjection.ServiceContracts;

namespace DependencyInjection.WeatherService;

public class CityWeather : ICityWeather
{
    public string? CityUniqueCode { set; get; }
    public string? CityName { set; get; }
    public DateTime DateAndTime { set; get; }
    public int TemperatureFahrenheit { set; get; }
}