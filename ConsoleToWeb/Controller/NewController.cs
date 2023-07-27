using Microsoft.AspNetCore.Mvc;


namespace ConsoleAppToWebAPI.Controllers
{
    [ApiController]
    [Route("NewApi/[action]")]
    public class NewController : ControllerBase
    {
        public string Get()
        {
            return "Hii Learners";
        }
    }
}