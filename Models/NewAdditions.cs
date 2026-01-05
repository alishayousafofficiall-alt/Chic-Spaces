using Microsoft.EntityFrameworkCore.Migrations;
using website.Models;

namespace website.Models
{
    public class NewAddition
    {
        public int Id { get; set; }

        public string Title { get; set; } = "";
        public string ImageUrl { get; set; } = "";
        public int CategoryId { get; set; }  // FK column
        public Category? Category { get; set; } // Navigation property
        public string? BannerImageUrl { get; set; }

        // ✅ Products relation
        public ICollection<Product> Products { get; set; } = new List<Product>();

    }
}