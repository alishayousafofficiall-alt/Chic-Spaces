
using System.ComponentModel.DataAnnotations;

namespace website.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";

        public string Description { get; set; } = "";
        public string Color { get; set; } = "";
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public string ImageUrl { get; set; } = "";

        public bool IsTrending { get; set; } = false;

        // ===== FK =====
        public int CategoryId { get; set; }

        public Category Category { get; set; } = null!;
        public int? NewAdditionId { get; set; }
        public NewAddition? NewAddition { get; set; }

    }
}
