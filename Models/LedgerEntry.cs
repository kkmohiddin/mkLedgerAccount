using System.ComponentModel.DataAnnotations;

namespace LedgerApplication.Models
{
    public enum EntryType { Debit, Credit }

    public class LedgerEntry
    {
        public int Id { get; set; }

        public DateTime Date { get; set; } = DateTime.UtcNow;

        [Required, StringLength(250)]
        public string Description { get; set; } = null!;

        public decimal Amount { get; set; }

        public EntryType Type { get; set; }

        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}