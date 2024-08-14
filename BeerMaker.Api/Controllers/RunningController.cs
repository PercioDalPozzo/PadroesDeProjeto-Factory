using Microsoft.AspNetCore.Mvc;

namespace BeerMaker.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RunningController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Running...";
        }
    }
}