using System.ComponentModel.DataAnnotations;

namespace LedgerApplication.Models
{
    public class SaleItem
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; } = null!;

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public decimal LineTotal => UnitPrice * Quantity;

        public int SaleId { get; set; }
        public Sale? Sale { get; set; }
    }
}