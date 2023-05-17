using System.ComponentModel.DataAnnotations;

namespace EcomApp.Models
{
    public class ComputerProcessor
    {
        [Key]
        public int ComputerProcessorId { get; set; }
        public string ProcessorDescription { get; set; }
        public string ProcessorPictuerURL { get; set; }
        public int ProcessorPrice { get; set; }

        // Relationships
        public List<ComputerModel> ComputerModels { get; set; } // Collection navigation property
    }
}
