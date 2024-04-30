using TenSharedLibraryPractice;
using Ten.Shared.Templates;
using Microsoft.AspNetCore.Mvc;

var options = new AspNetCoreOptions("TenSharedLibraryPractice", "TSLP", args)
{
    ConfigureBuilder = AppSetup.Configure
};

var app = AspNetCoreTemplate.Create(options);

app.MapControllers();

app.Run();

[ApiController]
[Route("/")]
public class HelloWorldController : ControllerBase
{   
    private readonly ILogger<HelloWorldController> _logger;

    public HelloWorldController(ILogger<HelloWorldController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> GetResponse()
    {
        _logger.LogInformation("Hello, World!");
        return new ObjectResult(new TestResponse("Hello, World!"));
    }
}

record TestResponse(string value);