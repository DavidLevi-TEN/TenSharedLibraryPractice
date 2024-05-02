using Microsoft.AspNetCore.Mvc;

namespace TenSharedLibraryPractice
{
    [ApiController]
    [Route("/")]
    public class HelloWorldController(ILogger<HelloWorldController> logger) : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger = logger;

        [HttpGet]
        public IActionResult GetResponse()
        {
            _logger.LogInformation("Hello, World!");
            return new ObjectResult(new TestResponse("Hello, World!"));
        }
    }
}