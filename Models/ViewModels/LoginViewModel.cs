using System.ComponentModel.DataAnnotations;

namespace BookShop.Models.ViewModels
{
    // ViewModel for the login form
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter an email")]
        [EmailAddress]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Please enter a password")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = "";

        // Remember user (cookie)
        public bool RememberMe { get; set; }
    }
}

