using EcomApp.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcomApp.Models
{
    public class ConfigurationItem
    {
        [Key]
        public int ConfigId { get; set; } // Primary key
        public int Price { get; set; }
        public OperatingSystems OperatingSystems { get; set; }
        public AntiVirus AntiVirus { get; set; }
        public ConfigurationType ConfigurationType { get; set; }

        //Relationships
        public int ComputerModelId { get; set; } // Foreign key
        [ForeignKey("ComputerModelId")]
        public ComputerModel ComputerModel { get; set; }
     
        public List<ComputerRAM> ComputerRAMs { get; set; }
        public List<ComputerVGA> ComputerVGAs { get; set; }
        public List<ComputerProcessor> ComputerProcessors { get; set; }

    }
}
