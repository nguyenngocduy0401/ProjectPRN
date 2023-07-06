namespace ProjectPRN
{
    partial class FrmUpdateSalary
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
            nmOnlShift = new System.Windows.Forms.NumericUpDown();
            btnSubmit = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            dtpEarn = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)nmOnlShift).BeginInit();
            SuspendLayout();
            // 
            // nmOnlShift
            // 
            nmOnlShift.Location = new System.Drawing.Point(167, 184);
            nmOnlShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            nmOnlShift.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmOnlShift.Name = "nmOnlShift";
            nmOnlShift.Size = new System.Drawing.Size(207, 23);
            nmOnlShift.TabIndex = 30;
            // 
            // btnSubmit
            // 
            btnSubmit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnSubmit.Location = new System.Drawing.Point(267, 268);
            btnSubmit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(108, 27);
            btnSubmit.TabIndex = 29;
            btnSubmit.Text = "Submit";
            btnSubmit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Enabled = false;
            label7.Location = new System.Drawing.Point(78, 229);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(54, 15);
            label7.TabIndex = 28;
            label7.Text = "DateEarn";
            // 
            // dtpEarn
            // 
            dtpEarn.Location = new System.Drawing.Point(167, 223);
            dtpEarn.Name = "dtpEarn";
            dtpEarn.Size = new System.Drawing.Size(208, 23);
            dtpEarn.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(78, 189);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 15);
            label2.TabIndex = 26;
            label2.Text = "OnlShift";
            // 
            // FrmUpdateSalary
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(453, 479);
            Controls.Add(nmOnlShift);
            Controls.Add(btnSubmit);
            Controls.Add(label7);
            Controls.Add(dtpEarn);
            Controls.Add(label2);
            Name = "FrmUpdateSalary";
            Text = "FrmUpdateSalary";
            Load += FrmUpdateSalary_Load;
            ((System.ComponentModel.ISupportInitialize)nmOnlShift).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmOnlShift;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpEarn;
        private System.Windows.Forms.Label label2;
    }
}