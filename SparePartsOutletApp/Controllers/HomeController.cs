using Microsoft.AspNetCore.Mvc;

namespace SparePartsOutletApp.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
