using System.ComponentModel.DataAnnotations;

namespace EcomApp.Models
{
    public class ComputerVGA
    {
        [Key]
        public int ComputerVGAId { get; set; }
        public string ComputerVGADescription { get; set; }
        public int ComputerVGAPrice { get; set; }

        public string VGAPictuerURL { get; set; }

        // Relationships
        public List<ComputerModel> ComputerModels { get; set; } // Collection navigation property
    }
}
