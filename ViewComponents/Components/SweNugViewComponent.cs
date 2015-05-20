using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace ViewComponents.Components
{
    public class SweNugViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        } 
    }
}
