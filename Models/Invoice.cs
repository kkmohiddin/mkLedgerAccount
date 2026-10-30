using System.ComponentModel.DataAnnotations;

namespace LedgerApplication.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        public int SaleId { get; set; }
        public Sale? Sale { get; set; }

        [Required, StringLength(50)]
        public string InvoiceNumber { get; set; } = null!;

        public DateTime IssuedOn { get; set; } = DateTime.UtcNow;

        public decimal Amount => Sale?.Total ?? 0m;
    }
}