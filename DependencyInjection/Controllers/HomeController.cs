using DependencyInjection.Services;
using Microsoft.AspNet.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private GreeterService greeterCTOR;

        [FromServices]
        public GreeterService GreeterService { get; set; }


        public HomeController(GreeterService greeter)
        {
            greeterCTOR = greeter;
        }

        public IActionResult Index()
        {
            ViewBag.greeter1 = greeterCTOR;
            ViewBag.greeter2 = GreeterService;

            return View();
        }
    }
}
