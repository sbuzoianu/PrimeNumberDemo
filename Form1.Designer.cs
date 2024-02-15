namespace PrimeNumberDemo {
    partial class PrimeNumberForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.CheckButton = new System.Windows.Forms.Button();
            this.PrimeNumberTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(312, 249);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(167, 67);
            this.CheckButton.TabIndex = 0;
            this.CheckButton.Text = "CHECK";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // PrimeNumberTxtBox
            // 
            this.PrimeNumberTxtBox.Location = new System.Drawing.Point(347, 187);
            this.PrimeNumberTxtBox.Name = "PrimeNumberTxtBox";
            this.PrimeNumberTxtBox.Size = new System.Drawing.Size(100, 22);
            this.PrimeNumberTxtBox.TabIndex = 1;
            // 
            // PrimeNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrimeNumberTxtBox);
            this.Controls.Add(this.CheckButton);
            this.Name = "PrimeNumberForm";
            this.Text = "Prime_Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.TextBox PrimeNumberTxtBox;
    }
}

