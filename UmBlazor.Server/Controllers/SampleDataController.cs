using UmBlazor.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UmBlazor.Shared.Models;

namespace UmBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : BaseUmbracoApiController
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetTimeline()
        {
            var headlessClient = Authenticate();

            var timelineItems = await headlessClient.GetAll<TimelineItem>();

            return Ok(timelineItems);
        }
    }
}
