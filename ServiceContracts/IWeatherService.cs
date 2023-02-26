namespace DependencyInjection.ServiceContracts;

public interface IWeatherService
{
    List<ICityWeather> GetWeatherDetails();
    ICityWeather? GetWeatherByCityCode(string CityCode);
}