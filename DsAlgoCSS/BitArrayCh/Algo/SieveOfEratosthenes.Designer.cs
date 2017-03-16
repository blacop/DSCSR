namespace BitArrayCh.Algo {
    partial class SieveOfEratosthenes {
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
            this.btnPrime = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblPrime = new System.Windows.Forms.Label();
            this.labelPrimes = new System.Windows.Forms.Label();
            this.txtPrimes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPrime
            // 
            this.btnPrime.Location = new System.Drawing.Point(138, 21);
            this.btnPrime.Name = "btnPrime";
            this.btnPrime.Size = new System.Drawing.Size(75, 23);
            this.btnPrime.TabIndex = 0;
            this.btnPrime.Text = "btnPrime";
            this.btnPrime.UseVisualStyleBackColor = true;
            this.btnPrime.Click += new System.EventHandler(this.btnPrime_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(22, 23);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 21);
            this.txtValue.TabIndex = 1;
            // 
            // lblPrime
            // 
            this.lblPrime.AutoSize = true;
            this.lblPrime.Location = new System.Drawing.Point(20, 47);
            this.lblPrime.Name = "lblPrime";
            this.lblPrime.Size = new System.Drawing.Size(53, 12);
            this.lblPrime.TabIndex = 2;
            this.lblPrime.Text = "lblPrime";
            // 
            // labelPrimes
            // 
            this.labelPrimes.AutoSize = true;
            this.labelPrimes.Location = new System.Drawing.Point(142, 82);
            this.labelPrimes.Name = "labelPrimes";
            this.labelPrimes.Size = new System.Drawing.Size(71, 12);
            this.labelPrimes.TabIndex = 3;
            this.labelPrimes.Text = "labelPrimes";
            // 
            // txtPrimes
            // 
            this.txtPrimes.Location = new System.Drawing.Point(22, 97);
            this.txtPrimes.Multiline = true;
            this.txtPrimes.Name = "txtPrimes";
            this.txtPrimes.Size = new System.Drawing.Size(296, 146);
            this.txtPrimes.TabIndex = 4;
            // 
            // SieveOfEratosthenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 265);
            this.Controls.Add(this.txtPrimes);
            this.Controls.Add(this.labelPrimes);
            this.Controls.Add(this.lblPrime);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnPrime);
            this.Name = "SieveOfEratosthenes";
            this.Text = "SieveOfEratosthenes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrime;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblPrime;
        private System.Windows.Forms.Label labelPrimes;
        private System.Windows.Forms.TextBox txtPrimes;
    }
}