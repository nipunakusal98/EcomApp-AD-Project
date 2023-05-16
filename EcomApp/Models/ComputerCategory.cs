using System.ComponentModel.DataAnnotations;

namespace EcomApp.Models
{
    public class ComputerCategory
    {
        [Key]
        public int CategoryId { get; set; } // Primary key
        public string CategoryName { get; set; }

        
    }
}
