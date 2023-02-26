using DependencyInjection.ServiceContracts;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.WebApp.Controllers;

public class HomeController : Controller
{
    private IWeatherService? _weatherService;    
    public HomeController(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    [Route("/")]
    public IActionResult Index()
    {
        return View(_weatherService!.GetWeatherDetails());
    }

    [Route("weather/{citycode}")]
    public IActionResult CityCode(string cityCode)
    {
        ViewBag.Title = "Bad Request";

        if (string.IsNullOrEmpty(cityCode))
        {
            HttpContext.Response.StatusCode = 400;
            return View("BadRequest");
        }
        else
        {
            ICityWeather? theCity = _weatherService!.GetWeatherByCityCode(cityCode);

            if (theCity != null)
            {
                ViewBag.Title = $"Weather of {theCity.CityName}";
                return View(theCity);
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
                return View("BadRequest");
            }
        }
    }
}