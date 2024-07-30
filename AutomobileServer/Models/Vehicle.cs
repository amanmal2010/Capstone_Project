using System.ComponentModel.DataAnnotations;

namespace AutomobilesServer.Models
{
    public class Vehicle
    {
        [Key]
        public string Number { get; set; } // Vehicle number as the primary key

        [Required]
        public string Model { get; set; }

        [Required]
        public string Customer { get; set; } // Add this field
    }
}
