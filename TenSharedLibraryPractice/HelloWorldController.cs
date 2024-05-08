using Grpc.Core;
using Microsoft.AspNetCore.Mvc;
using Ten.Shared.Audit.AspNetCore.Grpc;
using Ten.Shared.Hosting.AspNetCore.Builder;
using Ten.Shared.Logging.AspNetCore;
using TenSharedLibraryPractice.Protos;

namespace TenSharedLibraryPractice
{
    // TODO - Using messages from the protobuf requires the 'gRPC.Tools' NuGet package
    public class HelloWorldService : Greeter.GreeterBase
    {
        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello, new world!!!"
            });
        }
    }

    /*[ApiController]
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
    }*/
}