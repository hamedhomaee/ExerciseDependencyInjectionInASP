using DependencyInjection.ServiceContracts;

namespace DependencyInjection.WeatherService;

public class WeatherService : IWeatherService
{
    private List<ICityWeather> cityWeathers = new()
    {
        new CityWeather() {
            CityUniqueCode = "LDN",
            CityName = "London",
            DateAndTime = Convert.ToDateTime("2030-01-01 8:00"),
            TemperatureFahrenheit = 33
        },
        new CityWeather() {
            CityUniqueCode = "NYC",
            CityName = "New York City",
            DateAndTime = Convert.ToDateTime("2030-01-01 3:00"),
            TemperatureFahrenheit = 60
        },
        new CityWeather() {
            CityUniqueCode = "PAR",
            CityName = "Paris",
            DateAndTime = Convert.ToDateTime("2030-01-01 9:00"),
            TemperatureFahrenheit = 82
        }
    };

    public ICityWeather? GetWeatherByCityCode(string CityCode)
    {
        ICityWeather? cityWeather = this.cityWeathers.Where(i => string.Equals(i.CityUniqueCode, CityCode)).FirstOrDefault();

        if (cityWeather == null)
            return null;
        else
            return cityWeather;
    }

    public List<ICityWeather> GetWeatherDetails()
    {
        return cityWeathers;
    }
}