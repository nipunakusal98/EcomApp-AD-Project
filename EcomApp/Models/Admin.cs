using System.ComponentModel.DataAnnotations;

namespace EcomApp.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string AdminFirstName { get; set; }
        public string AminLastName { get; set; }
        public string AdminEmail { get; set; }
        public string AdminPassword { get; set; }
        public string AdminPhoneNumber { get; set; }
    }
}
