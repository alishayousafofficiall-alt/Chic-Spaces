using System;
using System.ComponentModel.DataAnnotations;

namespace website.Models
{
    public class Newsletter
    {
        public int Id { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; } = "";

        public DateTime SubscribedAt { get; set; } = DateTime.Now;
    }
}
