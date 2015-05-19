using DependencyInjection.Services;
using Microsoft.AspNet.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private GreeterService gs1;

        [FromServices]
        public GreeterService GreeterService { get; set; }


        public HomeController(GreeterService greeter)
        {
            gs1 = greeter;
        }

        public IActionResult Index()
        {
            ViewBag.greeter1 = gs1;
            ViewBag.greeter2 = GreeterService;

            return View();
        }
    }
}
