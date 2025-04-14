using Microsoft.AspNetCore.Mvc;

namespace WebLab2.Controllers
{
    [ApiController]
    public class MyController : ControllerBase
    {
        [HttpGet("hello")]
        public string GetName()
        {
            return "Denys Vaschenko, group: kp-23";
        }
    }
}
