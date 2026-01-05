using System;

namespace website.Models
{
    public class Review
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public int Rating { get; set; }

        public string Message { get; set; } = "";

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
