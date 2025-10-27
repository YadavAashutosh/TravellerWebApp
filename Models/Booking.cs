using System;
using System.ComponentModel.DataAnnotations;

namespace TravellerWebApp.Models
{
    public class Booking
    {
        public int Id { get; set; }
        [Required] public string CustomerName { get; set; } = string.Empty;
        [Required, EmailAddress] public string CustomerEmail { get; set; } = string.Empty;
        [Required] public int DestinationId { get; set; }
        public Destination? Destination { get; set; }
        [Required] public DateTime TravelDate { get; set; } = DateTime.Today;
        [Range(1, 50)] public int Travelers { get; set; } = 1;
        public decimal TotalPrice { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
