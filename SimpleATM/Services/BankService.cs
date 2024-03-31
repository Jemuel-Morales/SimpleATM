using SimpleATM.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleATM.Services
{
    public class BankService
    {
        private readonly SeedData _data;
        private UserAccount _account;
        public BankService() {
            _data = new SeedData();

        }

        public bool IsLogin(string cardNumber, int pinCode)
        {
            _account = null;
            foreach(UserAccount user in _data.UserAccounts)
            {
                if(user.CardNumber == cardNumber && user.PinCode == pinCode) {
                    _account = new UserAccount(
                        user.Id, user.Name, user.CardNumber, user.PinCode, user.Balance, user.Transactions
                        );
                }
            }

            if(_account == null)
            {
                return false;
            }

            return true;
        }

        public UserAccount GetUserAccount()
        {
            return _account;
        }

        public List<string> GetCardNumbers()
        {
            List<string> Cards = new List<string>();

            foreach(UserAccount user in _data.UserAccounts)
            {
                Cards.Add(user.CardNumber);
            }

            return Cards;
        }


        public bool Withdraw(decimal amount)
        {
            if(_account.Balance < amount){
                return false;
            }
            for(int i = 0; i < _data.UserAccounts.Count; i++)
            {
                if (_data.UserAccounts[i].Id == _account.Id)
                {
                    _data.UserAccounts[i].RemoveBalance(amount);
                    _data.UserAccounts[i].StoreTransaction(new Transaction(
                        _data.UserAccounts[i].Transactions.Count + 1,
                        "Withdraw",
                        amount,
                        _data.UserAccounts[i].Balance,
                        DateTime.Now
                        ));
                    _account = _data.UserAccounts[i];
                    return true;
                }
            }

            return false;
        }

        public bool Deposit(decimal amount)
        {
            if(amount == 0)
            {
                return false;
            }
            for (int i = 0; i < _data.UserAccounts.Count; i++)
            {
                if (_data.UserAccounts[i].Id == _account.Id)
                {
                    _data.UserAccounts[i].AddBalance(amount);
                    _data.UserAccounts[i].StoreTransaction(new Transaction(
                        _data.UserAccounts[i].Transactions.Count + 1,
                        "Deposit",
                        amount,
                        _data.UserAccounts[i].Balance,
                        DateTime.Now
                        ));
                    _account = _data.UserAccounts[i];
                    return true;
                }
            }

            return false;
        }
    }
}
