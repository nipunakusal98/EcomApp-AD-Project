using System.ComponentModel.DataAnnotations;

namespace EcomApp.Models
{
    public class ProcessorBrand
    {
        [Key]
        public int ProcessorBrandId { get; set; }
        public string ProcessorBrandName { get; set; }
    }
}
