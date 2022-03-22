using Microsoft.AspNetCore.Mvc;

namespace FollowSys.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
  

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "followers")]
        public string Get()
        {
            return "hi";
        }
    }
}