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
}