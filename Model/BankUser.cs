using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Banking_CapStone.Model
{
    public class BankUser : UserBase
    {
        [NotMapped]
        public int BankUserId { get; set; }

        [Required, StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [ForeignKey("Bank")]
        public int BankId { get; set; }

        public Bank? Bank { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<Payment>? Payments { get; set; }
        public ICollection<Transaction>? Transactions { get; set; }
        public virtual ICollection<SalaryDisbursement>? ApprovedSalaryDisbursement { get; set; }
    }
}