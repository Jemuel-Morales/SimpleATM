using SimpleATM.Model;
using SimpleATM.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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

                    printPreviewDialog.Document = printDocument;
                    printPreviewDialog.SetBounds(12, 12, 720, 480);
                    printPreviewDialog.PrintPreviewControl.AutoZoom = false;
                    printPreviewDialog.PrintPreviewControl.Zoom = 1.5;
                    printPreviewDialog.ShowDialog();
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

                    printPreviewDialog.Document = printDocument;
                    printPreviewDialog.SetBounds(12, 12, 720, 480);
                    printPreviewDialog.PrintPreviewControl.AutoZoom = false;
                    printPreviewDialog.PrintPreviewControl.Zoom = 1.5;
                    printPreviewDialog.ShowDialog();
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

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (e.Graphics != null)
            {
                Graphics graphic = e.Graphics;

                int left = 10;
                int offSet = 0;

                Random generator = new Random();
                String r = generator.Next(0, 1000000).ToString("D6");

                var useraccount = _service.GetUserAccount();

                StringFormat stringFormatCenter = new StringFormat();
                stringFormatCenter.Alignment = StringAlignment.Center;
                stringFormatCenter.LineAlignment = StringAlignment.Center;

                StringFormat stringFormatRight = new StringFormat();
                stringFormatRight.Alignment = StringAlignment.Far;
                stringFormatRight.LineAlignment = StringAlignment.Center;

                StringFormat stringFormatLeft = new StringFormat();
                stringFormatLeft.LineAlignment = StringAlignment.Center;

                //Business Logo
                //Bitmap Logo = new Bitmap(Resources.PapaPan);
                graphic.DrawString("Mochi Mochi Bank", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Rectangle(left + 110, offSet, 250, 20));

                graphic.DrawString("Trace:", new Font("Tahoma", 9f, FontStyle.Bold), Brushes.Black, new Rectangle(left, offSet + 30, 150, 20));
                graphic.DrawString(r, new Font("Tahoma", 9f), Brushes.Black, new Rectangle(left + 50, offSet + 30, 150, 20));
                graphic.DrawString("Date: ", new Font("Tahoma", 9f, FontStyle.Bold), Brushes.Black, new Rectangle(left, offSet + 50, 150, 20));
                graphic.DrawString(DateTime.Now.ToString("MM-dd-yyyy"), new Font("Tahoma", 9f), Brushes.Black, new Rectangle(left + 50, offSet + 50, 150, 20));
                graphic.DrawString("Time: ", new Font("Tahoma", 9f, FontStyle.Bold), Brushes.Black, new Rectangle(left, offSet + 70, 150, 20));
                graphic.DrawString(DateTime.Now.ToString("HH:mm:ss"), new Font("Tahoma", 9f), Brushes.Black, new Rectangle(left + 50, offSet + 70, 150, 20));
                graphic.DrawString("Transaction: ", new Font("Tahoma", 9f, FontStyle.Bold), Brushes.Black, new Rectangle(left, offSet + 100, 150, 20));
                graphic.DrawString(_action.ToString(), new Font("Tahoma", 9f), Brushes.Black, new Rectangle(left, offSet + 120, 150, 20));
                graphic.DrawString("Card Number: ", new Font("Tahoma", 9f, FontStyle.Bold), Brushes.Black, new Rectangle(left + 250, offSet + 100, 150, 20));
                graphic.DrawString("****-****-****-" + useraccount.CardNumber.Substring(useraccount.CardNumber.LastIndexOf("-") + 1), new Font("Tahoma", 9f), Brushes.Black, new Rectangle(left + 250, offSet + 120, 150, 20));
                //
                graphic.DrawString("Amount: ", new Font("Tahoma", 9f, FontStyle.Bold), Brushes.Black, new Rectangle(left, offSet + 140, 150, 20));
                graphic.DrawString(TxtbxAmount.Text, new Font("Tahoma", 9f), Brushes.Black, new Rectangle(left, offSet + 160, 150, 20));
                graphic.DrawString("Available Balance: ", new Font("Tahoma", 9f, FontStyle.Bold), Brushes.Black, new Rectangle(left + 250, offSet + 140, 150, 20));
                graphic.DrawString(useraccount.Balance.ToString(), new Font("Tahoma", 9f), Brushes.Black, new Rectangle(left + 250, offSet + 160, 150, 20));

                graphic.DrawString("Debit Card A000000044", new Font("Tahoma", 9f, FontStyle.Regular), Brushes.Black, new Rectangle(left, offSet + 200, 250, 20));

                graphic.DrawString("THANK YOU FOR BANKING WITH US.", new Font("Tahoma", 9f, FontStyle.Regular), Brushes.Black, new Rectangle(left + 70, offSet + 230, 300, 20));
            }
        }
    }
}
