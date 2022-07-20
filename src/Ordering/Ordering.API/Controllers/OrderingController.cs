using Microsoft.AspNetCore.Mvc;

namespace Ordering.API.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderingController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<OrderingController> _logger;

    public OrderingController(ILogger<OrderingController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetOrdering")]
    public IEnumerable<OrderingModel> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new OrderingModel
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
