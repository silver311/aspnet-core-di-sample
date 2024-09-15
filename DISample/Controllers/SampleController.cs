using DISample.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace DISample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly ISampleService _sampleService;

        public SampleController(ISampleService sampleService)
        {
            _sampleService = sampleService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _sampleService.Start();
            return Ok();
        }
    }
}
