using EcomApp.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace EcomApp.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; } // Primary key
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public int TotalPrice { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }

        // Foreign keys
        public int CustomerId { get; set; } // Foreign key
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; } // Navigation property

        public int ComputerModelId { get; set; } // Foreign key
        [ForeignKey("ComputerModelId")]
        public ComputerModel ComputerModel { get; set; } // Navigation property

        // Relationships
        public List<ConfigurationItem> ConfigurationItems { get; set; } // Collection navigation property
        public List<Payment> Payments { get; set; } // Collection navigation property
    }
}
