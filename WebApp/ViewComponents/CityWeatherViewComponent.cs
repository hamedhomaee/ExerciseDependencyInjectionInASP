using DependencyInjection.ServiceContracts;
using Microsoft.AspNetCore.Mvc;

public class CityWeatherViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(ICityWeather ViewComponentModel)
    {
        await Task.CompletedTask;
        return View(ViewComponentModel);
    }
}