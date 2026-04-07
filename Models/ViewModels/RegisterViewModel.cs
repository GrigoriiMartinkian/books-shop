using System.ComponentModel.DataAnnotations;

namespace BookShop.Models.ViewModels
{
    // ViewModel for the registration form
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please enter an email")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Please enter a password")]
        [MinLength(6, ErrorMessage = "Minimum 6 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = "";

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; } = "";
    }
}
