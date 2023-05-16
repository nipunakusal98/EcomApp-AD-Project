using System.ComponentModel.DataAnnotations;

namespace EcomApp.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; } // Primary key
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int OrderId { get; set; }
    }
}
