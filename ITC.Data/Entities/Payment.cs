using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITC.Data.Entities
{
    public class Payment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string? PaymentTo { get; set; }
        public string? BankAccountBeneficiary { get; set; }
        public string? BankAccountNumber { get; set; }
        public string? BankName { get; set; }
        public string? SwiftCode { get; set; }
        public string? BankBranch { get; set; }
        public string? BankAddress { get; set; }

    }
}
