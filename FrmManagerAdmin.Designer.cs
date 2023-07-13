namespace ProjectPRN
{
    partial class FrmManagerAdmin
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
            btnProduct = new System.Windows.Forms.Button();
            btnCategory = new System.Windows.Forms.Button();
            Staff = new System.Windows.Forms.Button();
            SaleReport = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnProduct
            // 
            btnProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnProduct.Location = new System.Drawing.Point(243, 121);
            btnProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new System.Drawing.Size(115, 73);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnCategory
            // 
            btnCategory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnCategory.Location = new System.Drawing.Point(413, 121);
            btnCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new System.Drawing.Size(115, 73);
            btnCategory.TabIndex = 3;
            btnCategory.Text = "Category";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // Staff
            // 
            Staff.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            Staff.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            Staff.Location = new System.Drawing.Point(243, 230);
            Staff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Staff.Name = "Staff";
            Staff.Size = new System.Drawing.Size(115, 73);
            Staff.TabIndex = 4;
            Staff.Text = "Staff";
            Staff.UseVisualStyleBackColor = true;
            Staff.Click += Staff_Click;
            // 
            // SaleReport
            // 
            SaleReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            SaleReport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            SaleReport.Location = new System.Drawing.Point(413, 230);
            SaleReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SaleReport.Name = "SaleReport";
            SaleReport.Size = new System.Drawing.Size(115, 73);
            SaleReport.TabIndex = 5;
            SaleReport.Text = "Sale report";
            SaleReport.UseVisualStyleBackColor = true;
            SaleReport.Click += SaleReport_Click;
            // 
            // FrmManagerAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(SaleReport);
            Controls.Add(Staff);
            Controls.Add(btnCategory);
            Controls.Add(btnProduct);
            Name = "FrmManagerAdmin";
            Text = "Manager";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button Staff;
        private System.Windows.Forms.Button SaleReport;
    }
}