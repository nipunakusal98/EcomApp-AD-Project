using System.ComponentModel.DataAnnotations;

namespace EcomApp.Models
{
    public class VGABrand
    {
        [Key]
        public int VGABrandId { get; set; }
        public string VGABrandName { get; set; }
    }
}
