using SimpleATM.Forms.Dialog;
using SimpleATM.Model;
using SimpleATM.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleATM.Forms
{
    public partial class DashboardForm : Form
    {

        private readonly BankService _service;
        private UserAccount _userAccount;
        private readonly AuthForm _authForm;
        private readonly MainForm _mainForm;

        public DashboardForm(AuthForm authform, MainForm mainForm, BankService service)
        {
            InitializeComponent();
            _authForm = authform;
            _mainForm = mainForm;
            _service = service;
            _userAccount = _service.GetUserAccount();
            Init();
        }

        private void Init()
        {
            string cardNumber = _userAccount.CardNumber;
            LblName.Text = _userAccount.Name;
            LblCardNumber.Text = "****-****-****-" + cardNumber.Substring(cardNumber.LastIndexOf("-") + 1);
        }

        private void BtnBalance_Click(object sender, EventArgs e)
        {
            var balance = _userAccount.Balance;
            MessageBox.Show(balance.ToString());
        }

        private void BtnWithdraw_Click(object sender, EventArgs e)
        {
            if(_userAccount.Balance == 0)
            {
                MessageBox.Show("Insufficient Funds", "Balance Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            new InputMoneyForm(ActionEnum.Withdraw, _service).ShowDialog();
            _userAccount = _service.GetUserAccount();
        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            new InputMoneyForm(ActionEnum.Deposit, _service).ShowDialog();
            _userAccount = _service.GetUserAccount();
        }

        private void BtnTransactions_Click(object sender, EventArgs e)
        {
            if(_userAccount.Transactions == null)
            {
                return;
            }
            new TransactionForm(_userAccount).ShowDialog();
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            _authForm.Close();
            _mainForm.Show();
        }
    }
}
