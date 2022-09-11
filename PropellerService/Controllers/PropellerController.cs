using Microsoft.AspNetCore.Mvc;

namespace PropellerService.Controllers;

[ApiController]
[Route("[controller]")]
public class PropellerController : ControllerBase
{
    private readonly ILogger<PropellerController> _logger;

    public PropellerController(ILogger<PropellerController> logger)
    {
        _logger = logger;
    }

    [HttpGet("TwelveFactors")]
    public IEnumerable<Factor> Get()
    {
        _logger.LogInformation("The twelve factor for app development");
        var result = new List<Factor>
        {
            new()
            {
                Number = 1,
                Name = "Codebase",
                Description = "One codebase tracked in revision control, many deploys"
            },
            new()
            {
                Number = 2,
                Name = "Dependencies",
                Description = "Explicitly declare and isolate dependencies"
            },
            new()
            {
                Number = 3,
                Name = "Config",
                Description = "Store config in the environment"
            },
            new()
            {
                Number = 4,
                Name = "Backing Services",
                Description = "Treat backing services as attached resources"
            },
            new()
            {
                Number = 5,
                Name = "Build, release, run",
                Description = "Strictly separate build and run stages"
            },
            new()
            {
                Number = 6,
                Name = "Processes",
                Description = "Execute the app as one or more stateless processes"
            },
            new()
            {
                Number = 7,
                Name = "Port binding",
                Description = "Export services via port binding"
            },
            new()
            {
                Number = 8,
                Name = "Concurrency",
                Description = "Scale out via the process model"
            },
            new()
            {
                Number = 9,
                Name = "Disposability",
                Description = "Maximize robustness with fast startup and graceful shutdown"
            },
            new()
            {
                Number = 10,
                Name = "Dev/Prod parity",
                Description = "Keep development, staging, and production as similar as possible"
            },
            new()
            {
                Number = 11,
                Name = "Logs",
                Description = "Treat logs as event streams"
            },
            new()
            {
                Number = 12,
                Name = "Admin processes",
                Description = "Run admin/management tasks as one-off processes"
            }
        };
        return result;
    }
}
