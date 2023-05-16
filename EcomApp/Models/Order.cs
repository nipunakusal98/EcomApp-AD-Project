using EcomApp.Data.Enums;
using System.ComponentModel.DataAnnotations;
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

        //Relationships
        public int CustomerId { get; set; } // Foreign key
        public Customer Customer { get; set; } // Navigation property

        public int ComputerModelId { get; set; } // Foreign key
        public ComputerModel ComputerModel { get; set; } // Navigation property

        public List<ConfigurationItem> ConfigurationItems { get; set; }


    }
}
