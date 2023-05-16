using System.ComponentModel.DataAnnotations;

namespace EcomApp.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; } // Primary key
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
