namespace SimpleATM.Forms
{
    partial class AuthForm
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
            this.txtbxPinCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbxPinCode
            // 
            this.txtbxPinCode.BackColor = System.Drawing.Color.GhostWhite;
            this.txtbxPinCode.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtbxPinCode.Location = new System.Drawing.Point(264, 253);
            this.txtbxPinCode.Margin = new System.Windows.Forms.Padding(5);
            this.txtbxPinCode.MaxLength = 6;
            this.txtbxPinCode.Name = "txtbxPinCode";
            this.txtbxPinCode.PasswordChar = '*';
            this.txtbxPinCode.Size = new System.Drawing.Size(370, 36);
            this.txtbxPinCode.TabIndex = 0;
            this.txtbxPinCode.Text = "123456";
            this.txtbxPinCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbxPinCode.UseSystemPasswordChar = true;
            this.txtbxPinCode.WordWrap = false;
            this.txtbxPinCode.TextChanged += new System.EventHandler(this.txtbxPinCode_TextChanged);
            this.txtbxPinCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxPinCode_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(257, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Pin Number";
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.BackgroundImage = global::SimpleATM.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxPinCode);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxPinCode;
        private System.Windows.Forms.Label label1;
    }
}

