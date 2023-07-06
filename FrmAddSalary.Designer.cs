namespace ProjectPRN
{
    partial class FrmAddSalary
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
            label2 = new System.Windows.Forms.Label();
            btnSubmit = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            dtpEarn = new System.Windows.Forms.DateTimePicker();
            nmOnlShift = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nmOnlShift).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(120, 279);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 15);
            label2.TabIndex = 20;
            label2.Text = "OnlShift";
            label2.Click += label2_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnSubmit.Location = new System.Drawing.Point(309, 358);
            btnSubmit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(108, 27);
            btnSubmit.TabIndex = 24;
            btnSubmit.Text = "Submit";
            btnSubmit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Enabled = false;
            label7.Location = new System.Drawing.Point(120, 319);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(54, 15);
            label7.TabIndex = 23;
            label7.Text = "DateEarn";
            label7.Click += label7_Click;
            // 
            // dtpEarn
            // 
            dtpEarn.Location = new System.Drawing.Point(209, 313);
            dtpEarn.Name = "dtpEarn";
            dtpEarn.Size = new System.Drawing.Size(208, 23);
            dtpEarn.TabIndex = 22;
            dtpEarn.ValueChanged += dtpEarn_ValueChanged;
            // 
            // nmOnlShift
            // 
            nmOnlShift.Location = new System.Drawing.Point(209, 274);
            nmOnlShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            nmOnlShift.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmOnlShift.Name = "nmOnlShift";
            nmOnlShift.Size = new System.Drawing.Size(207, 23);
            nmOnlShift.TabIndex = 25;
            nmOnlShift.ValueChanged += nmOnlShift_ValueChanged;
            // 
            // FrmAddSalary
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(537, 626);
            Controls.Add(nmOnlShift);
            Controls.Add(btnSubmit);
            Controls.Add(label7);
            Controls.Add(dtpEarn);
            Controls.Add(label2);
            Name = "FrmAddSalary";
            Text = "FrmAddSalary";
            Load += FrmAddSalary_Load;
            ((System.ComponentModel.ISupportInitialize)nmOnlShift).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpEarn;
        private System.Windows.Forms.NumericUpDown nmOnlShift;
    }
}