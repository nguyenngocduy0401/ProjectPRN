namespace ProjectPRN211
{
    partial class FrmManageStaff
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvStaffList = new System.Windows.Forms.DataGridView();
            lbStaffList = new System.Windows.Forms.Label();
            gbInformation = new System.Windows.Forms.GroupBox();
            txtHourlyWage = new System.Windows.Forms.TextBox();
            cbRole = new System.Windows.Forms.ComboBox();
            numShiftOff = new System.Windows.Forms.NumericUpDown();
            dtBirthday = new System.Windows.Forms.DateTimePicker();
            txtPhone = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            lbEmail = new System.Windows.Forms.Label();
            lbRole = new System.Windows.Forms.Label();
            lbShiftOff = new System.Windows.Forms.Label();
            lbHourlyWage = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            lbBirthday = new System.Windows.Forms.Label();
            lbPhone = new System.Windows.Forms.Label();
            lbName = new System.Windows.Forms.Label();
            lbID = new System.Windows.Forms.Label();
            txtID = new System.Windows.Forms.TextBox();
            btnCreate = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            gbFunction = new System.Windows.Forms.GroupBox();
            btnAddShift = new System.Windows.Forms.Button();
            btnShow = new System.Windows.Forms.Button();
            txtFindName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvStaffList).BeginInit();
            gbInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numShiftOff).BeginInit();
            gbFunction.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStaffList
            // 
            dgvStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaffList.Location = new System.Drawing.Point(-12, 309);
            dgvStaffList.Name = "dgvStaffList";
            dgvStaffList.RowHeadersWidth = 51;
            dgvStaffList.RowTemplate.Height = 29;
            dgvStaffList.Size = new System.Drawing.Size(1009, 276);
            dgvStaffList.TabIndex = 0;
            dgvStaffList.CellDoubleClick += dgvStaffList_CellDoubleClick;
            dgvStaffList.EditingControlShowing += dgvStaffList_EditingControlShowing;
            // 
            // lbStaffList
            // 
            lbStaffList.AutoSize = true;
            lbStaffList.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbStaffList.Location = new System.Drawing.Point(438, 271);
            lbStaffList.Name = "lbStaffList";
            lbStaffList.Size = new System.Drawing.Size(143, 35);
            lbStaffList.TabIndex = 1;
            lbStaffList.Text = "STAFF LIST";
            // 
            // gbInformation
            // 
            gbInformation.Controls.Add(txtHourlyWage);
            gbInformation.Controls.Add(cbRole);
            gbInformation.Controls.Add(numShiftOff);
            gbInformation.Controls.Add(dtBirthday);
            gbInformation.Controls.Add(txtPhone);
            gbInformation.Controls.Add(txtEmail);
            gbInformation.Controls.Add(lbEmail);
            gbInformation.Controls.Add(lbRole);
            gbInformation.Controls.Add(lbShiftOff);
            gbInformation.Controls.Add(lbHourlyWage);
            gbInformation.Controls.Add(txtName);
            gbInformation.Controls.Add(lbBirthday);
            gbInformation.Controls.Add(lbPhone);
            gbInformation.Controls.Add(lbName);
            gbInformation.Controls.Add(lbID);
            gbInformation.Controls.Add(txtID);
            gbInformation.Location = new System.Drawing.Point(12, 12);
            gbInformation.Name = "gbInformation";
            gbInformation.Size = new System.Drawing.Size(669, 256);
            gbInformation.TabIndex = 2;
            gbInformation.TabStop = false;
            gbInformation.Text = "Information";
            // 
            // txtHourlyWage
            // 
            txtHourlyWage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtHourlyWage.Location = new System.Drawing.Point(485, 102);
            txtHourlyWage.Name = "txtHourlyWage";
            txtHourlyWage.Size = new System.Drawing.Size(169, 27);
            txtHourlyWage.TabIndex = 20;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new System.Drawing.Point(485, 215);
            cbRole.Name = "cbRole";
            cbRole.Size = new System.Drawing.Size(169, 28);
            cbRole.TabIndex = 19;
            // 
            // numShiftOff
            // 
            numShiftOff.Location = new System.Drawing.Point(485, 161);
            numShiftOff.Name = "numShiftOff";
            numShiftOff.Size = new System.Drawing.Size(169, 27);
            numShiftOff.TabIndex = 18;
            // 
            // dtBirthday
            // 
            dtBirthday.CustomFormat = "";
            dtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtBirthday.Location = new System.Drawing.Point(485, 37);
            dtBirthday.MaxDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            dtBirthday.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            dtBirthday.Name = "dtBirthday";
            dtBirthday.Size = new System.Drawing.Size(169, 27);
            dtBirthday.TabIndex = 17;
            dtBirthday.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // txtPhone
            // 
            txtPhone.BackColor = System.Drawing.SystemColors.Window;
            txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPhone.Location = new System.Drawing.Point(99, 213);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(257, 27);
            txtPhone.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = System.Drawing.SystemColors.Window;
            txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtEmail.Location = new System.Drawing.Point(99, 161);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(257, 27);
            txtEmail.TabIndex = 15;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(10, 163);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(46, 20);
            lbEmail.TabIndex = 12;
            lbEmail.Text = "Email";
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Location = new System.Drawing.Point(376, 216);
            lbRole.Name = "lbRole";
            lbRole.Size = new System.Drawing.Size(39, 20);
            lbRole.TabIndex = 14;
            lbRole.Text = "Role";
            // 
            // lbShiftOff
            // 
            lbShiftOff.AutoSize = true;
            lbShiftOff.Location = new System.Drawing.Point(376, 164);
            lbShiftOff.Name = "lbShiftOff";
            lbShiftOff.Size = new System.Drawing.Size(64, 20);
            lbShiftOff.TabIndex = 13;
            lbShiftOff.Text = "Shift Off";
            // 
            // lbHourlyWage
            // 
            lbHourlyWage.AutoSize = true;
            lbHourlyWage.Location = new System.Drawing.Point(376, 105);
            lbHourlyWage.Name = "lbHourlyWage";
            lbHourlyWage.Size = new System.Drawing.Size(95, 20);
            lbHourlyWage.TabIndex = 11;
            lbHourlyWage.Text = "Hourly Wage";
            // 
            // txtName
            // 
            txtName.BackColor = System.Drawing.SystemColors.Window;
            txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtName.Location = new System.Drawing.Point(99, 102);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(257, 27);
            txtName.TabIndex = 10;
            // 
            // lbBirthday
            // 
            lbBirthday.AutoSize = true;
            lbBirthday.Location = new System.Drawing.Point(376, 42);
            lbBirthday.Name = "lbBirthday";
            lbBirthday.Size = new System.Drawing.Size(68, 20);
            lbBirthday.TabIndex = 9;
            lbBirthday.Text = "Birthday ";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new System.Drawing.Point(10, 215);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new System.Drawing.Size(50, 20);
            lbPhone.TabIndex = 8;
            lbPhone.Text = "Phone";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new System.Drawing.Point(10, 104);
            lbName.Name = "lbName";
            lbName.Size = new System.Drawing.Size(76, 20);
            lbName.TabIndex = 7;
            lbName.Text = "Full Name";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new System.Drawing.Point(10, 41);
            lbID.Name = "lbID";
            lbID.Size = new System.Drawing.Size(24, 20);
            lbID.TabIndex = 6;
            lbID.Text = "ID";
            // 
            // txtID
            // 
            txtID.BackColor = System.Drawing.SystemColors.Window;
            txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtID.Location = new System.Drawing.Point(99, 37);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(257, 27);
            txtID.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(39, 35);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(94, 29);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(198, 33);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(198, 102);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(216, 215);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(94, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // gbFunction
            // 
            gbFunction.Controls.Add(btnAddShift);
            gbFunction.Controls.Add(btnShow);
            gbFunction.Controls.Add(txtFindName);
            gbFunction.Controls.Add(btnCreate);
            gbFunction.Controls.Add(btnSearch);
            gbFunction.Controls.Add(btnDelete);
            gbFunction.Controls.Add(btnUpdate);
            gbFunction.Location = new System.Drawing.Point(687, 12);
            gbFunction.Name = "gbFunction";
            gbFunction.Size = new System.Drawing.Size(334, 256);
            gbFunction.TabIndex = 7;
            gbFunction.TabStop = false;
            gbFunction.Text = "Function";
            // 
            // btnAddShift
            // 
            btnAddShift.Location = new System.Drawing.Point(39, 159);
            btnAddShift.Name = "btnAddShift";
            btnAddShift.Size = new System.Drawing.Size(94, 29);
            btnAddShift.TabIndex = 9;
            btnAddShift.Text = "Add Shift";
            btnAddShift.UseVisualStyleBackColor = true;
            btnAddShift.Click += btnAddShift_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new System.Drawing.Point(39, 101);
            btnShow.Name = "btnShow";
            btnShow.Size = new System.Drawing.Size(94, 29);
            btnShow.TabIndex = 8;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // txtFindName
            // 
            txtFindName.BackColor = System.Drawing.SystemColors.Window;
            txtFindName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtFindName.ForeColor = System.Drawing.SystemColors.WindowText;
            txtFindName.Location = new System.Drawing.Point(16, 216);
            txtFindName.Name = "txtFindName";
            txtFindName.PlaceholderText = "Enter Full Name";
            txtFindName.Size = new System.Drawing.Size(179, 27);
            txtFindName.TabIndex = 7;
            // 
            // Admin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1033, 597);
            Controls.Add(gbFunction);
            Controls.Add(gbInformation);
            Controls.Add(lbStaffList);
            Controls.Add(dgvStaffList);
            Name = "Admin";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)dgvStaffList).EndInit();
            gbInformation.ResumeLayout(false);
            gbInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numShiftOff).EndInit();
            gbFunction.ResumeLayout(false);
            gbFunction.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaffList;
        private System.Windows.Forms.Label lbStaffList;
        private System.Windows.Forms.GroupBox gbInformation;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbShiftOff;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbHourlyWage;
        private System.Windows.Forms.DateTimePicker dtBirthday;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtHourlyWage;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.NumericUpDown numShiftOff;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbFunction;
        private System.Windows.Forms.TextBox txtFindName;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnAddShift;
    }
}
