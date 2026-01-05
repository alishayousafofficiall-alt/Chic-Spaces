using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace website.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First name required")]
        [StringLength(50)]
        public string FirstName { get; set; } = "";

        [Required(ErrorMessage = "Last name required")]
        [StringLength(50)]
        public string LastName { get; set; } = "";

        [Required]
        [Range(10, 100, ErrorMessage = "Age must be between 10 and 100")]
        public int Age { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; } = "";

        [Required]
        [EmailAddress]
        public string Email { get; set; } = "";

        [Required]
        [MinLength(6)]
        public string Password { get; set; } = "";

        [NotMapped]
        [Required(ErrorMessage = "Confirm password required")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; } = "";

        [Required(ErrorMessage = "Postal address required")]
        [StringLength(200)]
        public string PostalAddress { get; set; } = "";

        public string? ProfileImage { get; set; }

        [Required]
        public string Role { get; set; } = "User";
    }
}
