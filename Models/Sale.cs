using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace LedgerApplication.Models
{
    public class Sale
    {
        public int Id { get; set; }

        public DateTime Date { get; set; } = DateTime.UtcNow;

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public ICollection<SaleItem> Items { get; set; } = new List<SaleItem>();

        public decimal Total => Items.Sum(i => i.LineTotal);
    }
}