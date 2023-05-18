using EcomApp.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcomApp.Models
{
    public class ComputerModel
    {
        [Key]
        public int Id { get; set; } // Primary key
        public string Name { get; set; }
        public int Price { get; set; }
        public string ModelPictuerURL { get; set; }
        public OperatingSystems OperatingSystems { get; set; }
        public AntiVirus AntiVirus { get; set; }

        public int RAMId { get; set; } //Foreign key
        [ForeignKey("RAMId")]
        public ComputerRAM ComputerRAM { get; set; }

        public int ComputerVGAId { get; set; } //Foreign key
        [ForeignKey("ComputerVGAId")]
        public ComputerVGA ComputerVGA { get; set; }

        public int ComputerProcessorId { get; set; } //Foreign key
        [ForeignKey("ComputerProcessorId")]
        public ComputerProcessor ComputerProcessor { get; set; }


        public int ComputerSeriesId { get; set; } // Foreign key
        [ForeignKey("ComputerSeriesId")]
        public ComputerSeries ComputerSeries { get; set; } // Navigation property

        //    public List<ComputerRAM> ComputerRAMs { get; set; } // Collection navigation property
        //    public List<ComputerProcessor> ComputerProcessors { get; set; } // Collection navigation property
        //    public List<ComputerVGA> ComputerVGAs { get; set; } // Collection navigation property
        //    public List<ConfigurationItem> ConfigurationItems { get; set; } // Collection navigation property
        //    public List<Order> Orders { get; set; } // Collection navigation property
        //}
    }
}

