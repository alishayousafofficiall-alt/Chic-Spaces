using System;

namespace website.Models
{
    public class Cart
    {
        public int Id { get; set; }

        // ===== FOREIGN KEYS =====
        public int UserId { get; set; }
        public Users User { get; set; } = null!;

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public int Quantity { get; set; }

        public DateTime AddedAt { get; set; } = DateTime.Now;
    }
}
