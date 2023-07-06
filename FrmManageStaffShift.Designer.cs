namespace ProjectPRN211
{
    partial class FrmManageStaffShift
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
            dgvShiftList = new System.Windows.Forms.DataGridView();
            txtName = new System.Windows.Forms.TextBox();
            lbName = new System.Windows.Forms.Label();
            lbShift = new System.Windows.Forms.Label();
            cbShift = new System.Windows.Forms.ComboBox();
            btnCreate = new System.Windows.Forms.Button();
            lbID = new System.Windows.Forms.Label();
            txtID = new System.Windows.Forms.TextBox();
            lbDay = new System.Windows.Forms.Label();
            cbDay = new System.Windows.Forms.ComboBox();
            btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvShiftList).BeginInit();
            SuspendLayout();
            // 
            // dgvShiftList
            // 
            dgvShiftList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShiftList.Location = new System.Drawing.Point(12, 244);
            dgvShiftList.Name = "dgvShiftList";
            dgvShiftList.RowHeadersWidth = 51;
            dgvShiftList.RowTemplate.Height = 29;
            dgvShiftList.Size = new System.Drawing.Size(558, 194);
            dgvShiftList.TabIndex = 0;
            dgvShiftList.CellContentDoubleClick += dgvShiftList_CellContentDoubleClick;
            dgvShiftList.EditingControlShowing += dgvShiftList_EditingControlShowing;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(173, 96);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new System.Drawing.Size(275, 27);
            txtName.TabIndex = 1;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new System.Drawing.Point(37, 99);
            lbName.Name = "lbName";
            lbName.Size = new System.Drawing.Size(76, 20);
            lbName.TabIndex = 2;
            lbName.Text = "Full Name";
            // 
            // lbShift
            // 
            lbShift.AutoSize = true;
            lbShift.Location = new System.Drawing.Point(85, 171);
            lbShift.Name = "lbShift";
            lbShift.Size = new System.Drawing.Size(39, 20);
            lbShift.TabIndex = 6;
            lbShift.Text = "Shift";
            // 
            // cbShift
            // 
            cbShift.FormattingEnabled = true;
            cbShift.Location = new System.Drawing.Point(130, 168);
            cbShift.Name = "cbShift";
            cbShift.Size = new System.Drawing.Size(112, 28);
            cbShift.TabIndex = 4;
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(465, 139);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(94, 29);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new System.Drawing.Point(37, 43);
            lbID.Name = "lbID";
            lbID.Size = new System.Drawing.Size(55, 20);
            lbID.TabIndex = 7;
            lbID.Text = "StaffID";
            // 
            // txtID
            // 
            txtID.Location = new System.Drawing.Point(173, 40);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new System.Drawing.Size(275, 27);
            txtID.TabIndex = 8;
            // 
            // lbDay
            // 
            lbDay.AutoSize = true;
            lbDay.Location = new System.Drawing.Point(287, 171);
            lbDay.Name = "lbDay";
            lbDay.Size = new System.Drawing.Size(35, 20);
            lbDay.TabIndex = 9;
            lbDay.Text = "Day";
            // 
            // cbDay
            // 
            cbDay.FormattingEnabled = true;
            cbDay.Location = new System.Drawing.Point(328, 168);
            cbDay.Name = "cbDay";
            cbDay.Size = new System.Drawing.Size(112, 28);
            cbDay.TabIndex = 10;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(465, 193);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ShiftManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(582, 450);
            Controls.Add(btnDelete);
            Controls.Add(cbDay);
            Controls.Add(lbDay);
            Controls.Add(txtID);
            Controls.Add(lbID);
            Controls.Add(lbShift);
            Controls.Add(btnCreate);
            Controls.Add(cbShift);
            Controls.Add(lbName);
            Controls.Add(txtName);
            Controls.Add(dgvShiftList);
            Name = "ShiftManagement";
            Text = "ShiftManagement";
            ((System.ComponentModel.ISupportInitialize)dgvShiftList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShiftList;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbShift;
        private System.Windows.Forms.ComboBox cbShift;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.Button btnDelete;
    }
}