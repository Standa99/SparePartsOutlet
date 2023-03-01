using Microsoft.AspNetCore.Mvc;

namespace SparePartsOutletApp.Controllers
{
    [Route("user")]
    public class UserController : Controller
    {
        [HttpPost("register")]
        public IActionResult RegisterNewUser()
        {
            return View();
        }
    }
}
