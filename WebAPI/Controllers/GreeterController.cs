using Microsoft.AspNet.Mvc;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class GreeterController : Controller
    {
        [FromServices]
        public GreeterService GreeterService { get; set; }

        [HttpGet]
        public string Greeter()
        {
            return "Hello " + GreeterService.Greet();
        }

        [HttpGet("{no}")]
        public string Greeter(int no)
        {
            return "Hello " + GreeterService.RiggedGreet(no);
        }
    }
}
