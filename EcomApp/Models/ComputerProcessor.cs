using System.ComponentModel.DataAnnotations;

namespace EcomApp.Models
{
    public class ComputerProcessor
    {
        [Key]
        public int ComputerProcessorId { get; set; }
        public string ProcessorDescription { get; set; }
        public string ProcessorPrice { get; set; }
    }
}
