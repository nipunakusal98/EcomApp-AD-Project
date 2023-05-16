using EcomApp.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace EcomApp.Models
{
    public class ComputerModel
    {
        [Key]
        public int Id { get; set; } // Primary key
        public string Name { get; set; }
        public int Price { get; set; }
        public OperatingSystems OperatingSystems { get; set; }
        public AntiVirus AntiVirus { get; set; }

       
        // Relationships
        public List<ComputerSeries> ComputerSeries { get; set; } // Collection navigation property
        public List<ComputerRAM> ComputerRAMs { get; set; } // Collection navigation property
        public List<ComputerProcessor> ComputerProcessors { get; set; } // Collection navigation property
        public List<ComputerVGA> ComputerVGAs { get; set; } // Collection navigation property
    }
}

