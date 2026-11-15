using se4.EFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se4.EFC
{
    internal class CustomerAccount
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        public string AccountNumber { get; set; } = string.Empty;
        public Account Account { get; set; } = null!;

        public OwnershipRole OwnershipType { get; set; }
        public DateTime OwnershipStartDate { get; set; } = DateTime.UtcNow;
        public AccountStatus AccountStatus { get; set; } = AccountStatus.Active;
    }
}
