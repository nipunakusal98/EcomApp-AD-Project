using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcomApp.Models
{
    public class ComputerSeries
    {
        [Key]
        public int SeriesId { get; set; } // Primary key
        public string SeriesName { get; set; }

        public string SeriesIconURL { get; set; }

        public int ComputerCategoryId { get; set; } // Foreign key
        [ForeignKey("ComputerCategoryId")]
        public ComputerCategory ComputerCategory { get; set; }

        //Relationships
        public List<ComputerModel> ComputerModels { get; set; } // Collection navigation property

    }
}
