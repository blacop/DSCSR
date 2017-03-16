namespace BitArrayCh.Algo {
    partial class BitMove {
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtBitShift = new System.Windows.Forms.TextBox();
            this.txtInt1 = new System.Windows.Forms.TextBox();
            this.lblInt1Bits = new System.Windows.Forms.Label();
            this.label_Bits_to_shift = new System.Windows.Forms.Label();
            this.lblOrigBits = new System.Windows.Forms.Label();
            this.label_Integer_to_shift = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(194, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(90, 226);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtBitShift
            // 
            this.txtBitShift.Location = new System.Drawing.Point(247, 49);
            this.txtBitShift.Name = "txtBitShift";
            this.txtBitShift.Size = new System.Drawing.Size(77, 21);
            this.txtBitShift.TabIndex = 20;
            // 
            // txtInt1
            // 
            this.txtInt1.Location = new System.Drawing.Point(34, 49);
            this.txtInt1.Name = "txtInt1";
            this.txtInt1.Size = new System.Drawing.Size(77, 21);
            this.txtInt1.TabIndex = 19;
            // 
            // lblInt1Bits
            // 
            this.lblInt1Bits.AutoSize = true;
            this.lblInt1Bits.Location = new System.Drawing.Point(135, 149);
            this.lblInt1Bits.Name = "lblInt1Bits";
            this.lblInt1Bits.Size = new System.Drawing.Size(71, 12);
            this.lblInt1Bits.TabIndex = 17;
            this.lblInt1Bits.Text = "lblInt1Bits";
            // 
            // label_Bits_to_shift
            // 
            this.label_Bits_to_shift.AutoSize = true;
            this.label_Bits_to_shift.Location = new System.Drawing.Point(245, 21);
            this.label_Bits_to_shift.Name = "label_Bits_to_shift";
            this.label_Bits_to_shift.Size = new System.Drawing.Size(83, 12);
            this.label_Bits_to_shift.TabIndex = 18;
            this.label_Bits_to_shift.Text = "Bits to shift";
            // 
            // lblOrigBits
            // 
            this.lblOrigBits.AutoSize = true;
            this.lblOrigBits.Location = new System.Drawing.Point(135, 110);
            this.lblOrigBits.Name = "lblOrigBits";
            this.lblOrigBits.Size = new System.Drawing.Size(71, 12);
            this.lblOrigBits.TabIndex = 14;
            this.lblOrigBits.Text = "lblOrigBits";
            // 
            // label_Integer_to_shift
            // 
            this.label_Integer_to_shift.AutoSize = true;
            this.label_Integer_to_shift.Location = new System.Drawing.Point(32, 21);
            this.label_Integer_to_shift.Name = "label_Integer_to_shift";
            this.label_Integer_to_shift.Size = new System.Drawing.Size(101, 12);
            this.label_Integer_to_shift.TabIndex = 15;
            this.label_Integer_to_shift.Text = "Integer to shift";
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(90, 197);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 21;
            this.btnLeft.Text = "<<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(194, 197);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 22;
            this.btnRight.Text = ">>";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // BitMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 261);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtBitShift);
            this.Controls.Add(this.txtInt1);
            this.Controls.Add(this.lblInt1Bits);
            this.Controls.Add(this.label_Bits_to_shift);
            this.Controls.Add(this.lblOrigBits);
            this.Controls.Add(this.label_Integer_to_shift);
            this.Name = "BitMove";
            this.Text = "BitMove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtBitShift;
        private System.Windows.Forms.TextBox txtInt1;
        private System.Windows.Forms.Label lblInt1Bits;
        private System.Windows.Forms.Label label_Bits_to_shift;
        private System.Windows.Forms.Label lblOrigBits;
        private System.Windows.Forms.Label label_Integer_to_shift;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
    }
}