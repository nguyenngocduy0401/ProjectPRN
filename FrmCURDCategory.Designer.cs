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
            btnAccept = new System.Windows.Forms.Button();
            btCapNhat = new System.Windows.Forms.Button();
            btXoa = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            Detail = new System.Windows.Forms.Panel();
            lbTenHang = new System.Windows.Forms.Label();
            txtTenHang = new System.Windows.Forms.TextBox();
            blMaHang = new System.Windows.Forms.Label();
            txtMaHang = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            groupBox5 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvListCatetory).BeginInit();
            Detail.SuspendLayout();
            panel1.SuspendLayout();
            groupBox5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // dgvListCatetory
            // 
            dgvListCatetory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListCatetory.Location = new System.Drawing.Point(7, 25);
            dgvListCatetory.Name = "dgvListCatetory";
            dgvListCatetory.RowHeadersWidth = 51;
            dgvListCatetory.RowTemplate.Height = 25;
            dgvListCatetory.Size = new System.Drawing.Size(581, 433);
            dgvListCatetory.TabIndex = 34;
            dgvListCatetory.CellDoubleClick += dgvListCatetory_CellDoubleClick;
            // 
            // btnAccept
            // 
            btnAccept.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAccept.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnAccept.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnAccept.Location = new System.Drawing.Point(264, 4);
            btnAccept.Margin = new System.Windows.Forms.Padding(4);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new System.Drawing.Size(122, 71);
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
            btCapNhat.Location = new System.Drawing.Point(394, 4);
            btCapNhat.Margin = new System.Windows.Forms.Padding(4);
            btCapNhat.Name = "btCapNhat";
            btCapNhat.Size = new System.Drawing.Size(122, 71);
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
            btXoa.Location = new System.Drawing.Point(4, 4);
            btXoa.Margin = new System.Windows.Forms.Padding(4);
            btXoa.Name = "btXoa";
            btXoa.Size = new System.Drawing.Size(122, 71);
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
            btnCancel.Location = new System.Drawing.Point(134, 4);
            btnCancel.Margin = new System.Windows.Forms.Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(122, 71);
            btnCancel.TabIndex = 43;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Detail
            // 
            Detail.BackColor = System.Drawing.Color.Silver;
            Detail.Controls.Add(lbTenHang);
            Detail.Controls.Add(txtTenHang);
            Detail.Controls.Add(blMaHang);
            Detail.Controls.Add(txtMaHang);
            Detail.Location = new System.Drawing.Point(586, 25);
            Detail.Name = "Detail";
            Detail.Size = new System.Drawing.Size(331, 648);
            Detail.TabIndex = 44;
            Detail.Paint += Detail_Paint;
            // 
            // lbTenHang
            // 
            lbTenHang.AutoSize = true;
            lbTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbTenHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lbTenHang.Location = new System.Drawing.Point(21, 255);
            lbTenHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbTenHang.Name = "lbTenHang";
            lbTenHang.Size = new System.Drawing.Size(91, 20);
            lbTenHang.TabIndex = 47;
            lbTenHang.Text = "Type name:";
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new System.Drawing.Point(119, 252);
            txtTenHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new System.Drawing.Size(200, 26);
            txtTenHang.TabIndex = 48;
            // 
            // blMaHang
            // 
            blMaHang.AutoSize = true;
            blMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            blMaHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            blMaHang.Location = new System.Drawing.Point(26, 197);
            blMaHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            blMaHang.Name = "blMaHang";
            blMaHang.Size = new System.Drawing.Size(86, 20);
            blMaHang.TabIndex = 45;
            blMaHang.Text = "Type code:";
            // 
            // txtMaHang
            // 
            txtMaHang.Location = new System.Drawing.Point(119, 197);
            txtMaHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtMaHang.Name = "txtMaHang";
            txtMaHang.Size = new System.Drawing.Size(200, 26);
            txtMaHang.TabIndex = 46;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox5);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 557);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(917, 119);
            panel1.TabIndex = 45;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(flowLayoutPanel1);
            groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox5.ForeColor = System.Drawing.Color.Blue;
            groupBox5.Location = new System.Drawing.Point(0, 11);
            groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox5.Size = new System.Drawing.Size(917, 108);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Manipulation:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            flowLayoutPanel1.Controls.Add(btXoa);
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Controls.Add(btnAccept);
            flowLayoutPanel1.Controls.Add(btCapNhat);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(4, 22);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flowLayoutPanel1.MinimumSize = new System.Drawing.Size(700, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(909, 83);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dgvListCatetory);
            groupBox6.Controls.Add(Detail);
            groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox6.ForeColor = System.Drawing.Color.Blue;
            groupBox6.Location = new System.Drawing.Point(0, 0);
            groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox6.Size = new System.Drawing.Size(917, 557);
            groupBox6.TabIndex = 46;
            groupBox6.TabStop = false;
            groupBox6.Text = "Salary";
            // 
            // FrmCURDCategory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(917, 676);
            Controls.Add(groupBox6);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "FrmCURDCategory";
            Text = "FrmCURDCategory";
            ((System.ComponentModel.ISupportInitialize)dgvListCatetory).EndInit();
            Detail.ResumeLayout(false);
            Detail.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListCatetory;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel Detail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label lbTenHang;
        private System.Windows.Forms.Label blMaHang;
        private System.Windows.Forms.TextBox txtMaHang;
    }
}