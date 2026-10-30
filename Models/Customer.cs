using System.ComponentModel.DataAnnotations;

namespace LedgerApplication.Models
{       
    public class Customer
    {
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string Name { get; set; } = null!;

        [StringLength(250)]
        public string? Address { get; set; }

        [Phone]
        public string? Phone { get; set; }

        [EmailAddress]
        public string? Email { get; set; }
    }
}