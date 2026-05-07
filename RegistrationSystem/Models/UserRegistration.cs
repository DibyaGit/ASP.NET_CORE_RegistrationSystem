using System.ComponentModel.DataAnnotations;

namespace RegistrationSystem.Models
{
    public class UserRegistration
    {
        [Required(ErrorMessage = "Please enter a username")]
        public string? Username { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Not a valid email")]
        public string? Email { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password needs to be at least 6 characters")]
        public string? Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string? ConfirmPassword { get; set; }
    }
}