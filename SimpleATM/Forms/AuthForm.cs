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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleATM.Forms
{
    public partial class AuthForm : Form
    {
        private readonly string _cardNumber = "";
        private readonly BankService _bankService;
        private readonly MainForm _mainForm;
        public AuthForm(MainForm mainForm, BankService service, string cardNumber)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _bankService = service;
            _cardNumber = cardNumber;
        }

        private void AuthForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.Show();
        }

        private void txtbxPinCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtbxPinCode_TextChanged(object sender, EventArgs e)
        {
            if (txtbxPinCode.Text.Length == 6)
            {
                if(_bankService.IsLogin(_cardNumber, Convert.ToInt32(txtbxPinCode.Text)))
                {
                    Hide();
                    new DashboardForm(this, _mainForm, _bankService).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect pin code. Try Again!", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
