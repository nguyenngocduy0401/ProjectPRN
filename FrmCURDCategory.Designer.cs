namespace ProjectPRN
{
    partial class FrmCURDCategory
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
            dgvListCatetory = new System.Windows.Forms.DataGridView();
            blMaHang = new System.Windows.Forms.Label();
            txtMaHang = new System.Windows.Forms.TextBox();
            lbTenHang = new System.Windows.Forms.Label();
            txtTenHang = new System.Windows.Forms.TextBox();
            btnAccept = new System.Windows.Forms.Button();
            btCapNhat = new System.Windows.Forms.Button();
            btXoa = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvListCatetory).BeginInit();
            SuspendLayout();
            // 
            // dgvListCatetory
            // 
            dgvListCatetory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListCatetory.Location = new System.Drawing.Point(12, 98);
            dgvListCatetory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvListCatetory.Name = "dgvListCatetory";
            dgvListCatetory.RowHeadersWidth = 51;
            dgvListCatetory.RowTemplate.Height = 25;
            dgvListCatetory.Size = new System.Drawing.Size(347, 260);
            dgvListCatetory.TabIndex = 34;
            dgvListCatetory.CellDoubleClick += dgvListCatetory_CellDoubleClick;
            // 
            // blMaHang
            // 
            blMaHang.AutoSize = true;
            blMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            blMaHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            blMaHang.Location = new System.Drawing.Point(391, 98);
            blMaHang.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            blMaHang.Name = "blMaHang";
            blMaHang.Size = new System.Drawing.Size(111, 25);
            blMaHang.TabIndex = 36;
            blMaHang.Text = "Type code:";
            // 
            // txtMaHang
            // 
            txtMaHang.Location = new System.Drawing.Point(391, 154);
            txtMaHang.Name = "txtMaHang";
            txtMaHang.Size = new System.Drawing.Size(122, 27);
            txtMaHang.TabIndex = 37;
            // 
            // lbTenHang
            // 
            lbTenHang.AutoSize = true;
            lbTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbTenHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lbTenHang.Location = new System.Drawing.Point(391, 211);
            lbTenHang.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbTenHang.Name = "lbTenHang";
            lbTenHang.Size = new System.Drawing.Size(117, 25);
            lbTenHang.TabIndex = 38;
            lbTenHang.Text = "Type name:";
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new System.Drawing.Point(391, 266);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new System.Drawing.Size(184, 27);
            txtTenHang.TabIndex = 39;
            // 
            // btnAccept
            // 
            btnAccept.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAccept.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnAccept.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnAccept.Location = new System.Drawing.Point(647, 98);
            btnAccept.Margin = new System.Windows.Forms.Padding(5);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new System.Drawing.Size(139, 36);
            btnAccept.TabIndex = 40;
            btnAccept.Text = "Create";
            btnAccept.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btCapNhat
            // 
            btCapNhat.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btCapNhat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btCapNhat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btCapNhat.Location = new System.Drawing.Point(647, 190);
            btCapNhat.Margin = new System.Windows.Forms.Padding(5);
            btCapNhat.Name = "btCapNhat";
            btCapNhat.Size = new System.Drawing.Size(139, 36);
            btCapNhat.TabIndex = 41;
            btCapNhat.Text = "Update";
            btCapNhat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btCapNhat.UseVisualStyleBackColor = true;
            btCapNhat.Click += btCapNhat_Click;
            // 
            // btXoa
            // 
            btXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btXoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btXoa.Location = new System.Drawing.Point(647, 266);
            btXoa.Margin = new System.Windows.Forms.Padding(5);
            btXoa.Name = "btXoa";
            btXoa.Size = new System.Drawing.Size(139, 36);
            btXoa.TabIndex = 42;
            btXoa.Text = "Delete";
            btXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnCancel.Location = new System.Drawing.Point(391, 322);
            btnCancel.Margin = new System.Windows.Forms.Padding(5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(139, 36);
            btnCancel.TabIndex = 43;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FrmCURDCategory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btXoa);
            Controls.Add(btCapNhat);
            Controls.Add(btnAccept);
            Controls.Add(txtTenHang);
            Controls.Add(lbTenHang);
            Controls.Add(txtMaHang);
            Controls.Add(blMaHang);
            Controls.Add(dgvListCatetory);
            Name = "FrmCURDCategory";
            Text = "FrmCURDCategory";
            ((System.ComponentModel.ISupportInitialize)dgvListCatetory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListCatetory;
        private System.Windows.Forms.Label blMaHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label lbTenHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btnCancel;
    }
}