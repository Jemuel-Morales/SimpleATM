using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleATM.Model
{
    public class UserAccount
    {

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string CardNumber { get; private set; }
        public int PinCode { get; private set; }
        public decimal Balance { get; private set; }

        public IList<Transaction> Transactions { get; private set; }

        public UserAccount(int id, string name, string cardNumber, int pinCode, decimal balance, IList<Transaction> transactions)
        {
            Id = id;
            Name = name;
            CardNumber = cardNumber;
            PinCode = pinCode;
            Balance = balance;
            Transactions = transactions;
        }

        

        public void AddBalance(decimal balance)
        {
            Balance += balance;
        }

        public void RemoveBalance(decimal balance)
        {
            Balance -= balance;
        }

        public void StoreTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
        }
    }
}
