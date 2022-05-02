using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace WeatherApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
  private static List<string> Summaries = new List<string>
  {
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
  };

  [HttpGet(Name = "GetWeatherForecast")]
  public IEnumerable<WeatherForecast> Get()
  {
    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
    {
      Date = DateTime.Now.AddDays(index),
      TemperatureC = Random.Shared.Next(-20, 55),
      Summary = Summaries[Random.Shared.Next(Summaries.Count)]
    })
    .ToArray();
  }

  [HttpPost(Name = "PostWeatherForecast")]
  public List<string> Post([FromBody] string summary)
  {
    Summaries.Add(summary);
    Log.Information("New weather summary added {summary}", summary);
    return Summaries;
  }
}
