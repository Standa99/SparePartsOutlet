using Microsoft.AspNetCore.Mvc;
using SparePartsOutletApp.Models.ApiRequests.UserManagement;
using SparePartsOutletApp.Services._Interfaces;

namespace SparePartsOutletApp.Controllers
{
    [Route("users")]
    public class UserManagementController : Controller
    {
        private readonly IUserManagementService _userManagementService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserManagementController(IUserManagementService userManagementService, IHttpContextAccessor httpContextAccessor)
        {
            _userManagementService = userManagementService;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody]UserLoginRequest userLoginRequest)
        {
            var response = _userManagementService.Login(userLoginRequest);

            //HttpContext.Session.SetString("JwtToken", response.AuthenticationToken);

            TempData["JwtToken"] = response.AuthenticationToken;

            return Ok(response);
        }
    }
}
