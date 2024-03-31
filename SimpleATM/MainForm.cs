using SimpleATM.Forms;
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

namespace SimpleATM
{
    public partial class MainForm : Form
    {
        private BankService _service;
        private string _cardNumber = "";
        public MainForm(BankService service)
        {
            
            InitializeComponent();
            _service = service;
            cardNumbers.Items.AddRange(_service.GetCardNumbers().ToArray());
        }

        private void btnAccessCard_Click(object sender, EventArgs e)
        {
            if(_cardNumber == string.Empty)
            {
                return;
            }
            Hide();

            new AuthForm(this, _service, _cardNumber).ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cardNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cardNumbers.SelectedIndex != -1)
            {
                _cardNumber = cardNumbers.Text;
            }
        }
    }
}
