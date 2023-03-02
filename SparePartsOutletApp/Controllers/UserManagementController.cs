using Microsoft.AspNetCore.Mvc;
using SparePartsOutletApp.Models.ApiRequests.UserManagement;
using SparePartsOutletApp.Services._Interfaces;

namespace SparePartsOutletApp.Controllers
{
    [Route("users")]
    public class UserManagementController : Controller
    {
        private readonly IUserManagementService _userManagementService;

        public UserManagementController(IUserManagementService userManagementService)
        {
            _userManagementService = userManagementService;
        }

        [HttpPost("login")]
        public IActionResult Login(UserLoginRequest userLoginRequest)
        {
            var response = _userManagementService.Login(userLoginRequest);

            return Ok(response);
        }
    }
}
