using System.ComponentModel.DataAnnotations;

namespace website.Models
{
    public class PageContent
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string PageName { get; set; } = ""; // About, Contact, Delivery, Reviews

        [Required]
        public string Title { get; set; } = "";

        [Required]
        public string Content { get; set; } = "";

        public string ImageUrl { get; set; } = ""; // Path to image
    }
}
