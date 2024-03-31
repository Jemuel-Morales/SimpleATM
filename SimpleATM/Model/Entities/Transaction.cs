using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleATM.Model
{
    public class Transaction
    {
        public Transaction(int id, string action, decimal amount, decimal remainingBalance, DateTime date_Transaction)
        {
            Id = id;
            Action = action;
            Amount = amount;
            RemainingBalance = remainingBalance;
            Date_Transaction = date_Transaction;
        }

        public int Id { get; private set; }
        public string Action { get; private set; }
        public decimal Amount { get; private set; }
        public decimal RemainingBalance { get; private set; }
        public DateTime Date_Transaction { get; private set; }

    }
}
