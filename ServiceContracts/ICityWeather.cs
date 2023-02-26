namespace DependencyInjection.ServiceContracts;

public interface ICityWeather
{
    public string? CityUniqueCode { set; get; }
    public string? CityName { set; get; }
    public DateTime DateAndTime { set; get; }
    public int TemperatureFahrenheit { set; get; }
}