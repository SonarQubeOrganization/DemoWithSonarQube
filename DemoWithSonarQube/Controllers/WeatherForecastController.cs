using DemoWithSonarQube.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoWithSonarQube.Controllers;

[Route("api")]
public class WeatherForecastController(ICarService carService, ILogger<WeatherForecastController> logger) : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Tempered", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    [HttpGet("weather")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
    }

    [HttpGet("cars")]
    public async Task<IActionResult> GetCarsAsync()
    {
        var cars = await Task.FromResult(new List<string> { "T-Cross", "Beetle" });

        carService.GetPerformance(571);

        return Ok(cars);
    }

    [HttpGet("airplanes")]
    public async Task<IActionResult> GetAirplanesAsync()
    {
        carService.getListofMechanicalfailuresAsync();

        return Ok();
    }
}
