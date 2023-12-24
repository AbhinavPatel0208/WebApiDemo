using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    public class PantsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
