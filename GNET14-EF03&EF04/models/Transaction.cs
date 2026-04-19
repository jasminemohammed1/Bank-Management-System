using GNET14_EF03_EF04.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNET14_EF03_EF04.models
{
    internal class Transaction
    {
        public int TransactionNumber { get; set; }
        public DateOnly TransactionDate {  get; set; }
        public decimal Amount { get; set; }
        public string ? Note { get; set; }
        public TransactionType TransactionType { get; set; }
        public Account Account { get; set; }
        public int AccountId { get; set; }

    }
}
