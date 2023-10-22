using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM
{
    public abstract class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime Date { get; set; }
        public decimal Ammount { get; set; }
    }
}