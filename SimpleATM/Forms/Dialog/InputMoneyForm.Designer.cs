namespace SimpleATM.Forms.Dialog
{
    partial class InputMoneyForm
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
            this.BtnProceed = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtbxAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnProceed
            // 
            this.BtnProceed.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnProceed.Location = new System.Drawing.Point(337, 307);
            this.BtnProceed.Name = "BtnProceed";
            this.BtnProceed.Size = new System.Drawing.Size(115, 43);
            this.BtnProceed.TabIndex = 0;
            this.BtnProceed.Text = "Proceed";
            this.BtnProceed.UseVisualStyleBackColor = true;
            this.BtnProceed.Click += new System.EventHandler(this.BtnProceed_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Location = new System.Drawing.Point(458, 307);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(115, 43);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtbxAmount
            // 
            this.TxtbxAmount.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxAmount.Location = new System.Drawing.Point(101, 144);
            this.TxtbxAmount.Name = "TxtbxAmount";
            this.TxtbxAmount.Size = new System.Drawing.Size(404, 45);
            this.TxtbxAmount.TabIndex = 2;
            this.TxtbxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtbxAmount_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(95, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input Amount";
            // 
            // InputMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimpleATM.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(585, 362);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtbxAmount);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnProceed);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InputMoneyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnProceed;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtbxAmount;
        private System.Windows.Forms.Label label1;
    }
}