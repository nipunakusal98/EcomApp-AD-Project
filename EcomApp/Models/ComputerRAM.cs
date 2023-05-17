using System.ComponentModel.DataAnnotations;

namespace EcomApp.Models
{
    public class ComputerRAM
    {
        [Key]
        public int RAMId { get; set; }
        public string RAMDescription { get; set; }
        public string RAMSize { get; set; }
        public string RAMPictuerURL { get; set; }
        public int RAMPrice { get; set; }

        // Relationships
        public List<ComputerModel> ComputerModels { get; set; } // Collection navigation property
    
}
}
