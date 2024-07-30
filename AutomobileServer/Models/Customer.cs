using System.ComponentModel.DataAnnotations;

namespace AutomobilesServer.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required] // Ensure this field is required if it cannot be null
        public string PhoneNumber { get; set; }
    }
}
