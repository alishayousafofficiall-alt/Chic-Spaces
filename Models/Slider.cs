using System.ComponentModel.DataAnnotations;

namespace website.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string ImageUrl { get; set; } = ""; // Image path
    }
}
