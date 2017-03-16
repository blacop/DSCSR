namespace BitArrayCh.Algo {
    partial class BitOperations {
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
            this.btnAnd = new System.Windows.Forms.Button();
            this.btnOr = new System.Windows.Forms.Button();
            this.btnXor = new System.Windows.Forms.Button();
            this.label_Integer1 = new System.Windows.Forms.Label();
            this.label_Integer2 = new System.Windows.Forms.Label();
            this.txtInt1 = new System.Windows.Forms.TextBox();
            this.txtInt2 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label_Bits = new System.Windows.Forms.Label();
            this.lblInt1Bits = new System.Windows.Forms.Label();
            this.lblInt2Bits = new System.Windows.Forms.Label();
            this.lblBitResult = new System.Windows.Forms.Label();
            this.label_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnd
            // 
            this.btnAnd.Location = new System.Drawing.Point(125, 186);
            this.btnAnd.Name = "btnAnd";
            this.btnAnd.Size = new System.Drawing.Size(75, 23);
            this.btnAnd.TabIndex = 0;
            this.btnAnd.Text = "And";
            this.btnAnd.UseVisualStyleBackColor = true;
            this.btnAnd.Click += new System.EventHandler(this.btnAnd_Click);
            // 
            // btnOr
            // 
            this.btnOr.Location = new System.Drawing.Point(217, 186);
            this.btnOr.Name = "btnOr";
            this.btnOr.Size = new System.Drawing.Size(75, 23);
            this.btnOr.TabIndex = 1;
            this.btnOr.Text = "Or";
            this.btnOr.UseVisualStyleBackColor = true;
            this.btnOr.Click += new System.EventHandler(this.btnOr_Click);
            // 
            // btnXor
            // 
            this.btnXor.Location = new System.Drawing.Point(309, 186);
            this.btnXor.Name = "btnXor";
            this.btnXor.Size = new System.Drawing.Size(75, 23);
            this.btnXor.TabIndex = 2;
            this.btnXor.Text = "Xor";
            this.btnXor.UseVisualStyleBackColor = true;
            this.btnXor.Click += new System.EventHandler(this.btnXor_Click);
            // 
            // label_Integer1
            // 
            this.label_Integer1.AutoSize = true;
            this.label_Integer1.Location = new System.Drawing.Point(23, 31);
            this.label_Integer1.Name = "label_Integer1";
            this.label_Integer1.Size = new System.Drawing.Size(53, 12);
            this.label_Integer1.TabIndex = 3;
            this.label_Integer1.Text = "Integer1";
            // 
            // label_Integer2
            // 
            this.label_Integer2.AutoSize = true;
            this.label_Integer2.Location = new System.Drawing.Point(23, 63);
            this.label_Integer2.Name = "label_Integer2";
            this.label_Integer2.Size = new System.Drawing.Size(53, 12);
            this.label_Integer2.TabIndex = 4;
            this.label_Integer2.Text = "Integer2";
            // 
            // txtInt1
            // 
            this.txtInt1.Location = new System.Drawing.Point(82, 28);
            this.txtInt1.Name = "txtInt1";
            this.txtInt1.Size = new System.Drawing.Size(30, 21);
            this.txtInt1.TabIndex = 5;
            // 
            // txtInt2
            // 
            this.txtInt2.Location = new System.Drawing.Point(82, 63);
            this.txtInt2.Name = "txtInt2";
            this.txtInt2.Size = new System.Drawing.Size(30, 21);
            this.txtInt2.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(19, 140);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(19, 186);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // label_Bits
            // 
            this.label_Bits.AutoSize = true;
            this.label_Bits.Location = new System.Drawing.Point(233, 9);
            this.label_Bits.Name = "label_Bits";
            this.label_Bits.Size = new System.Drawing.Size(29, 12);
            this.label_Bits.TabIndex = 9;
            this.label_Bits.Text = "Bits";
            // 
            // lblInt1Bits
            // 
            this.lblInt1Bits.AutoSize = true;
            this.lblInt1Bits.Location = new System.Drawing.Point(200, 31);
            this.lblInt1Bits.Name = "lblInt1Bits";
            this.lblInt1Bits.Size = new System.Drawing.Size(71, 12);
            this.lblInt1Bits.TabIndex = 3;
            this.lblInt1Bits.Text = "lblInt1Bits";
            // 
            // lblInt2Bits
            // 
            this.lblInt2Bits.AutoSize = true;
            this.lblInt2Bits.Location = new System.Drawing.Point(200, 66);
            this.lblInt2Bits.Name = "lblInt2Bits";
            this.lblInt2Bits.Size = new System.Drawing.Size(71, 12);
            this.lblInt2Bits.TabIndex = 4;
            this.lblInt2Bits.Text = "lblInt2Bits";
            // 
            // lblBitResult
            // 
            this.lblBitResult.AutoSize = true;
            this.lblBitResult.Location = new System.Drawing.Point(200, 108);
            this.lblBitResult.Name = "lblBitResult";
            this.lblBitResult.Size = new System.Drawing.Size(77, 12);
            this.lblBitResult.TabIndex = 4;
            this.lblBitResult.Text = "lblBitResult";
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Location = new System.Drawing.Point(23, 108);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(95, 12);
            this.label_Result.TabIndex = 10;
            this.label_Result.Text = "Compute Result:";
            // 
            // BitOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 239);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.label_Bits);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtInt2);
            this.Controls.Add(this.txtInt1);
            this.Controls.Add(this.lblBitResult);
            this.Controls.Add(this.lblInt2Bits);
            this.Controls.Add(this.label_Integer2);
            this.Controls.Add(this.lblInt1Bits);
            this.Controls.Add(this.label_Integer1);
            this.Controls.Add(this.btnXor);
            this.Controls.Add(this.btnOr);
            this.Controls.Add(this.btnAnd);
            this.Name = "BitOperations";
            this.Text = "BitOperations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnd;
        private System.Windows.Forms.Button btnOr;
        private System.Windows.Forms.Button btnXor;
        private System.Windows.Forms.Label label_Integer1;
        private System.Windows.Forms.Label label_Integer2;
        private System.Windows.Forms.TextBox txtInt1;
        private System.Windows.Forms.TextBox txtInt2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label_Bits;
        private System.Windows.Forms.Label lblInt1Bits;
        private System.Windows.Forms.Label lblInt2Bits;
        private System.Windows.Forms.Label lblBitResult;
        private System.Windows.Forms.Label label_Result;
    }
}