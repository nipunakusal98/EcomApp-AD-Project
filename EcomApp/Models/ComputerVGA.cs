using System.ComponentModel.DataAnnotations;

namespace EcomApp.Models
{
    public class ComputerVGA
    {
        [Key]
        public int ComputerVGAId { get; set; }
        public int ComputerVGASize { get; set; }
        public int ComputerVGAPrice { get; set; }
    }
}
