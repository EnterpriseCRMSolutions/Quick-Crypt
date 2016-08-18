namespace BradCrypt
{
    partial class Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password));
            this.maskedTextBoxKey = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBoxKey
            // 
            this.maskedTextBoxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxKey.Location = new System.Drawing.Point(12, 146);
            this.maskedTextBoxKey.Name = "maskedTextBoxKey";
            this.maskedTextBoxKey.PasswordChar = '*';
            this.maskedTextBoxKey.Size = new System.Drawing.Size(317, 26);
            this.maskedTextBoxKey.TabIndex = 1;
            this.maskedTextBoxKey.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxKey_MaskInputRejected);
            this.maskedTextBoxKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBoxKey_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 262);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 251);
            this.Controls.Add(this.maskedTextBoxKey);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Password";
            this.Text = "Quick Cyrpt v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox maskedTextBoxKey;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}