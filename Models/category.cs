namespace website.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? ImageUrl { get; set; }
        public string? BannerImageUrl { get; set; }
        public string? Description { get; set; }
    }
}
