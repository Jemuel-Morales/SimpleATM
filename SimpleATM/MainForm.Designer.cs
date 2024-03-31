namespace SimpleATM
{
    partial class MainForm
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
            this.btnAccessCard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cardNumbers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAccessCard
            // 
            this.btnAccessCard.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAccessCard.BackgroundImage = global::SimpleATM.Properties.Resources.insert_card;
            this.btnAccessCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAccessCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccessCard.FlatAppearance.BorderSize = 0;
            this.btnAccessCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAccessCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAccessCard.ForeColor = System.Drawing.Color.Transparent;
            this.btnAccessCard.Location = new System.Drawing.Point(365, 276);
            this.btnAccessCard.Name = "btnAccessCard";
            this.btnAccessCard.Size = new System.Drawing.Size(190, 186);
            this.btnAccessCard.TabIndex = 0;
            this.btnAccessCard.UseVisualStyleBackColor = false;
            this.btnAccessCard.Click += new System.EventHandler(this.btnAccessCard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(218, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Mochi Mochi Bank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(388, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Insert Card";
            // 
            // cardNumbers
            // 
            this.cardNumbers.FormattingEnabled = true;
            this.cardNumbers.Location = new System.Drawing.Point(690, 520);
            this.cardNumbers.Name = "cardNumbers";
            this.cardNumbers.Size = new System.Drawing.Size(196, 21);
            this.cardNumbers.TabIndex = 3;
            this.cardNumbers.Text = "Select Card....";
            this.cardNumbers.SelectedIndexChanged += new System.EventHandler(this.cardNumbers_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.BackgroundImage = global::SimpleATM.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 553);
            this.Controls.Add(this.cardNumbers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccessCard);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccessCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cardNumbers;
    }
}

