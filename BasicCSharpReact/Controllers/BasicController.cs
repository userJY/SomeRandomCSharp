using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BasicCSharpReact.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BasicController : ControllerBase
    {
        private readonly ILogger<BasicController> _logger; 
        //dependency injection of logger service

        public BasicController(ILogger<BasicController> logger)
        {
            _logger = logger;
        }

        //HttpGet attribute 
        [HttpGet("{someEndpointName}")]
        public String Get(String someEndpointName) 
        //WARN HttpGet attribute parameter must be same as Get method parameter, "someEndpointName"
        {
            return $"Server returned {someEndpointName}";
        }
        //calling https://localhost:5001/Basic/bleh will hit this controller's endpoint
    }
}