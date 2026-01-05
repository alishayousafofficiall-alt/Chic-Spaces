using System.Collections.Generic;

namespace website.Models
{
    public class ViewModel
    {
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Slider> Sliders { get; set; } = new List<Slider>();
        public List<Product> TrendingProducts { get; set; } = new List<Product>();
        public List<NewAddition> NewAdditions { get; set; } = new List<NewAddition>();
        public List<PageContent> Pages { get; set; } = new List<PageContent>();
    }
}
