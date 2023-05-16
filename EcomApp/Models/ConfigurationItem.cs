using EcomApp.Data.Enums;
using System.ComponentModel.DataAnnotations;

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
        public ComputerModel ComputerModel { get; set; }
        public List<ComputerModel> ComputerModels { get; set; }
        public List<ComputerRAM> ComputerRAMs { get; set; }
        public List<ComputerVGA> ComputerVGAs { get; set; }
        public List<ComputerProcessor> ComputerProcessors { get; set; }

    }
}
