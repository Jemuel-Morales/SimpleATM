namespace SimpleATM.Forms
{
    partial class TransactionForm
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
            this.DGVTransactionLists = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTransactionLists)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVTransactionLists
            // 
            this.DGVTransactionLists.AllowUserToAddRows = false;
            this.DGVTransactionLists.AllowUserToDeleteRows = false;
            this.DGVTransactionLists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVTransactionLists.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVTransactionLists.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DGVTransactionLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTransactionLists.Location = new System.Drawing.Point(12, 12);
            this.DGVTransactionLists.Name = "DGVTransactionLists";
            this.DGVTransactionLists.ReadOnly = true;
            this.DGVTransactionLists.Size = new System.Drawing.Size(874, 529);
            this.DGVTransactionLists.TabIndex = 0;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.BackgroundImage = global::SimpleATM.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 553);
            this.Controls.Add(this.DGVTransactionLists);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.DGVTransactionLists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVTransactionLists;
    }
}