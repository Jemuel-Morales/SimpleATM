namespace SimpleATM.Forms
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblCardNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnTransactions = new System.Windows.Forms.Button();
            this.BtnDeposit = new System.Windows.Forms.Button();
            this.BtnWithdraw = new System.Windows.Forms.Button();
            this.BtnBalance = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.LblCardNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LblName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 91);
            this.panel1.TabIndex = 0;
            // 
            // LblCardNumber
            // 
            this.LblCardNumber.AutoSize = true;
            this.LblCardNumber.ForeColor = System.Drawing.Color.LightCoral;
            this.LblCardNumber.Location = new System.Drawing.Point(135, 55);
            this.LblCardNumber.Name = "LblCardNumber";
            this.LblCardNumber.Size = new System.Drawing.Size(252, 19);
            this.LblCardNumber.TabIndex = 3;
            this.LblCardNumber.Text = "****-****-****-[lastnumber]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Card Number:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Consolas", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblName.Location = new System.Drawing.Point(11, 27);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(90, 28);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "[Name]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BtnTransactions, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnDeposit, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnWithdraw, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnBalance, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 91);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(898, 462);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // BtnTransactions
            // 
            this.BtnTransactions.BackColor = System.Drawing.Color.Lavender;
            this.BtnTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTransactions.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTransactions.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnTransactions.Image = global::SimpleATM.Properties.Resources.bill_line;
            this.BtnTransactions.Location = new System.Drawing.Point(499, 281);
            this.BtnTransactions.Margin = new System.Windows.Forms.Padding(50);
            this.BtnTransactions.Name = "BtnTransactions";
            this.BtnTransactions.Size = new System.Drawing.Size(349, 131);
            this.BtnTransactions.TabIndex = 5;
            this.BtnTransactions.Text = "Transactions";
            this.BtnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnTransactions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnTransactions.UseVisualStyleBackColor = false;
            this.BtnTransactions.Click += new System.EventHandler(this.BtnTransactions_Click);
            // 
            // BtnDeposit
            // 
            this.BtnDeposit.BackColor = System.Drawing.Color.Lavender;
            this.BtnDeposit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDeposit.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeposit.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnDeposit.Image = global::SimpleATM.Properties.Resources.money_regular;
            this.BtnDeposit.Location = new System.Drawing.Point(50, 281);
            this.BtnDeposit.Margin = new System.Windows.Forms.Padding(50);
            this.BtnDeposit.Name = "BtnDeposit";
            this.BtnDeposit.Size = new System.Drawing.Size(349, 131);
            this.BtnDeposit.TabIndex = 4;
            this.BtnDeposit.Text = "Deposit";
            this.BtnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDeposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDeposit.UseVisualStyleBackColor = false;
            this.BtnDeposit.Click += new System.EventHandler(this.BtnDeposit_Click);
            // 
            // BtnWithdraw
            // 
            this.BtnWithdraw.BackColor = System.Drawing.Color.Lavender;
            this.BtnWithdraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnWithdraw.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWithdraw.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnWithdraw.Image = global::SimpleATM.Properties.Resources.money_withdraw;
            this.BtnWithdraw.Location = new System.Drawing.Point(499, 50);
            this.BtnWithdraw.Margin = new System.Windows.Forms.Padding(50);
            this.BtnWithdraw.Name = "BtnWithdraw";
            this.BtnWithdraw.Size = new System.Drawing.Size(349, 131);
            this.BtnWithdraw.TabIndex = 3;
            this.BtnWithdraw.Text = "Withdraw";
            this.BtnWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnWithdraw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnWithdraw.UseVisualStyleBackColor = false;
            this.BtnWithdraw.Click += new System.EventHandler(this.BtnWithdraw_Click);
            // 
            // BtnBalance
            // 
            this.BtnBalance.BackColor = System.Drawing.Color.Lavender;
            this.BtnBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBalance.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBalance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnBalance.Image = global::SimpleATM.Properties.Resources.bank_solid;
            this.BtnBalance.Location = new System.Drawing.Point(50, 50);
            this.BtnBalance.Margin = new System.Windows.Forms.Padding(50);
            this.BtnBalance.Name = "BtnBalance";
            this.BtnBalance.Size = new System.Drawing.Size(349, 131);
            this.BtnBalance.TabIndex = 2;
            this.BtnBalance.Text = "Balance Inquiry";
            this.BtnBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBalance.UseVisualStyleBackColor = false;
            this.BtnBalance.Click += new System.EventHandler(this.BtnBalance_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.BackgroundImage = global::SimpleATM.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashboardForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblCardNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnTransactions;
        private System.Windows.Forms.Button BtnDeposit;
        private System.Windows.Forms.Button BtnWithdraw;
        private System.Windows.Forms.Button BtnBalance;
    }
}