using System.ComponentModel.DataAnnotations;

namespace EcomApp.Models
{
    public class ComputerSeries
    {
        [Key]
        public int SeriesId { get; set; } // Primary key
        public string SeriesName { get; set; }


        //public int ComputerCategoryId { get; set; } // Foreign key
        //public ComputerCategory ComputerCategory { get; set; }

        //Relationships
        public List<ComputerCategory> ComputerCategories { get; set; }
    }
}
