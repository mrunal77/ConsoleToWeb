using Microsoft.AspNetCore.Mvc;


namespace ConsoleAppToWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewController : ControllerBase
    {
        [HttpGet(Name = "Get")]
        public string Get()
        {
            return "Hello this is API";
        }
    }
}