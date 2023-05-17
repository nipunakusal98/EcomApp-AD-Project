using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcomApp.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; } // Primary key
        public int  Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string CreditCardNumber { get; set; }
        public string CardholderName { get; set; }
        public string CVV { get; set; }
        public string BillingAddress { get; set; }

        // Foreign keys
        public int OrderId { get; set; } // Foreign key
        [ForeignKey("OrderId")]
        public Order Order { get; set; } // Navigation property
    }
}
