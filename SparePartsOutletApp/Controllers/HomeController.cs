using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SparePartsOutletApp.Controllers
{
    [Route("")]
    
    public class HomeController : Controller
    {
        [HttpGet("authorize")]
        public IActionResult Authorize() 
        {
            var token = TempData["JwtToken"] as string;
            //token = token.Substring(7);

            if (!string.IsNullOrEmpty(token))
            {
                //token = token.Substring(7);
                HttpContext.Response.Headers.Add("Authorization", $"Bearer {token}");
                return RedirectToAction("Index");
            }
            return Unauthorized(new {e = "authorize neprošel"}); 
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var token = TempData["JwtToken"] as string;
            //token = token.Substring(7);
            return View();
            //if (!string.IsNullOrEmpty(token))
            //{
            //    //token = token.Substring(7);
            //    HttpContext.Response.Headers.Add("Authorization", $"Bearer {token}");
            //    return View();
            //}
            //else
            //{
            //    return Unauthorized(new { eee = "asdfadf"});
            //}

        }
    }
}
