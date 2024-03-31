using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleATM.Model
{
    public class SeedData
    {
        public IList<UserAccount> UserAccounts { get; private set; }

        public SeedData() {

            UserAccounts = new List<UserAccount>()
            {
               new UserAccount(id: 1, name: "John Doe", cardNumber: "5567-3434-5356-6455", pinCode: 111222, balance: 10_000.00m, transactions: new List<Transaction>()
               {
                   new Transaction(1, "Deposit", 15000, 15000, DateTime.Now),
                   new Transaction(2, "Withdraw", 5000, 10000, DateTime.Now),
               }),
               new UserAccount(id: 1, name: "Jane Doe", cardNumber: "5567-3434-5356-6456", pinCode: 111222, balance: 4_000.00m, transactions: new List<Transaction>()
               {
                   new Transaction(1, "Deposit", 10000, 10000, DateTime.Now),
                   new Transaction(2, "Withdraw", 5000, 5000, DateTime.Now),
                   new Transaction(3, "Withdraw", 1000, 4000, DateTime.Now),
               }),
               new UserAccount(id: 1, name: "Joseph Doe", cardNumber: "5567-3434-5356-6457", pinCode: 123456, balance: 16_000.00m, transactions: new List<Transaction>()
               {
                   new Transaction(1, "Deposit", 20000, 20000, DateTime.Now),
                   new Transaction(2, "Withdraw", 5000, 15000, DateTime.Now),
                   new Transaction(3, "Deposit", 1000, 16000, DateTime.Now),
               })
            };
        }


    }
}
