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

namespace SimpleATM.Forms.Dialog
{
    public partial class InputMoneyForm : Form
    {
        private readonly ActionEnum _action;
        private readonly BankService _service;
        public InputMoneyForm(ActionEnum action, BankService service)
        {
            InitializeComponent();
            _action = action;
            _service = service;
        }

        private void BtnProceed_Click(object sender, EventArgs e)
        {
            if(ActionEnum.Withdraw == _action)
            {
                if(_service.Withdraw(Convert.ToDecimal(TxtbxAmount.Text)))
                {
                    MessageBox.Show("Withdrawal Complete", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Withdrawal Unsuccessful", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(ActionEnum.Deposit == _action)
            {
                if(_service.Deposit(Convert.ToDecimal(TxtbxAmount.Text)))
                {
                    MessageBox.Show("Deposit Successful", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Deposit Unsuccessful", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Close();

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        //config keypress
        //accept only numbers/decimal
        private void TxtbxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar))
            {

                TextBox textBox = (TextBox)sender;

                if (textBox.Text.IndexOf('.') > -1 &&
                         textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 3)
                {
                    e.Handled = true;
                }

            }
        }
    }
}
