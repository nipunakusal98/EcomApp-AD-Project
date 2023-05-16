using System.ComponentModel.DataAnnotations;

namespace EcomApp.Models
{
    public class RAMBrand
    {
        [Key]
        public int RAMBrandId { get; set; }
        public string RAMBrandName { get; set; }
    }
}
