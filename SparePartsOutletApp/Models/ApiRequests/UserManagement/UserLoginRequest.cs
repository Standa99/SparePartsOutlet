using System.ComponentModel.DataAnnotations;

namespace SparePartsOutletApp.Models.ApiRequests.UserManagement
{
    public class UserLoginRequest
    {
        [Required(ErrorMessage = "Field is required."),
            MinLength(4, ErrorMessage = "Must be at least 4 characters long.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Field is required."),
            MinLength(8, ErrorMessage = "Must be at least 8 characters long.")]
        public string Password { get; set; }
    }
}
