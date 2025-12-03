using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Banking_CapStone.Model
{
    public class Client : UserBase
    {
        [NotMapped]
        public int ClientId { get; set; }

        [Required, StringLength(100)]
        public string ClientName { get; set; }

        [Required]
        [StringLength(20)]
        public string AccountNumber { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal AccountBalance { get; set; } = 0;

        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        [Required]
        [StringLength(10)]
        public string PanNumber { get; set; }

        [StringLength(15)]
        public string? GstNumber { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey("Bank")]
        public int BankId { get; set; }
        public Bank? Bank { get; set; }

        public ICollection<Employee>? Employees { get; set; }
        public ICollection<Payment>? Payments { get; set; }
        public ICollection<Transaction>? Transactions { get; set; }
        public ICollection<Document>? Documents { get; set; }
        public virtual ICollection<Account>? Accounts { get; set; }
        public virtual ICollection<Beneficiary>? Beneficiaries { get; set; }
        public virtual ICollection<SalaryDisbursement>? SalaryDisbursements { get; set; }
    }
}