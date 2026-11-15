using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se4.EFC
{
    internal class Transaction
    {
        public int TransactionNumber { get; set; } 
        public DateTime TransactionDate { get; set; } = DateTime.UtcNow;
        public decimal Amount { get; set; }
        public string? Note { get; set; }
        public string TransactionType { get; set; } = string.Empty;

        public string AccountNumber { get; set; } = string.Empty;
        public Account Account { get; set; } = null!;
    }
}
