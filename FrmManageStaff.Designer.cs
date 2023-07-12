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
            cbStatus = new System.Windows.Forms.ComboBox();
            txtPhone = new System.Windows.Forms.TextBox();
            lbStatus = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            txtHourlyWage = new System.Windows.Forms.TextBox();
            lbEmail = new System.Windows.Forms.Label();
            cbRole = new System.Windows.Forms.ComboBox();
            txtName = new System.Windows.Forms.TextBox();
            numShiftOff = new System.Windows.Forms.NumericUpDown();
            lbPhone = new System.Windows.Forms.Label();
            dtBirthday = new System.Windows.Forms.DateTimePicker();
            lbName = new System.Windows.Forms.Label();
            lbRole = new System.Windows.Forms.Label();
            lbID = new System.Windows.Forms.Label();
            lbShiftOff = new System.Windows.Forms.Label();
            txtID = new System.Windows.Forms.TextBox();
            lbHourlyWage = new System.Windows.Forms.Label();
            lbBirthday = new System.Windows.Forms.Label();
            btnCreate = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            gbFunction = new System.Windows.Forms.GroupBox();
            btnSalary = new System.Windows.Forms.Button();
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
            dgvStaffList.Location = new System.Drawing.Point(12, 309);
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
            gbInformation.Controls.Add(cbStatus);
            gbInformation.Controls.Add(txtPhone);
            gbInformation.Controls.Add(lbStatus);
            gbInformation.Controls.Add(txtEmail);
            gbInformation.Controls.Add(txtHourlyWage);
            gbInformation.Controls.Add(lbEmail);
            gbInformation.Controls.Add(cbRole);
            gbInformation.Controls.Add(txtName);
            gbInformation.Controls.Add(numShiftOff);
            gbInformation.Controls.Add(lbPhone);
            gbInformation.Controls.Add(dtBirthday);
            gbInformation.Controls.Add(lbName);
            gbInformation.Controls.Add(lbRole);
            gbInformation.Controls.Add(lbID);
            gbInformation.Controls.Add(lbShiftOff);
            gbInformation.Controls.Add(txtID);
            gbInformation.Controls.Add(lbHourlyWage);
            gbInformation.Controls.Add(lbBirthday);
            gbInformation.Location = new System.Drawing.Point(12, 12);
            gbInformation.Name = "gbInformation";
            gbInformation.Size = new System.Drawing.Size(669, 256);
            gbInformation.TabIndex = 2;
            gbInformation.TabStop = false;
            gbInformation.Text = "Information";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new System.Drawing.Point(490, 211);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new System.Drawing.Size(169, 28);
            cbStatus.TabIndex = 42;
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
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new System.Drawing.Point(381, 219);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new System.Drawing.Size(49, 20);
            lbStatus.TabIndex = 41;
            lbStatus.Text = "Status";
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
            // txtHourlyWage
            // 
            txtHourlyWage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtHourlyWage.Location = new System.Drawing.Point(490, 74);
            txtHourlyWage.Name = "txtHourlyWage";
            txtHourlyWage.Size = new System.Drawing.Size(169, 27);
            txtHourlyWage.TabIndex = 40;
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
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new System.Drawing.Point(490, 168);
            cbRole.Name = "cbRole";
            cbRole.Size = new System.Drawing.Size(169, 28);
            cbRole.TabIndex = 39;
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
            // numShiftOff
            // 
            numShiftOff.Location = new System.Drawing.Point(490, 123);
            numShiftOff.Name = "numShiftOff";
            numShiftOff.Size = new System.Drawing.Size(169, 27);
            numShiftOff.TabIndex = 38;
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
            // dtBirthday
            // 
            dtBirthday.CustomFormat = "";
            dtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtBirthday.Location = new System.Drawing.Point(490, 28);
            dtBirthday.MaxDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            dtBirthday.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            dtBirthday.Name = "dtBirthday";
            dtBirthday.Size = new System.Drawing.Size(169, 27);
            dtBirthday.TabIndex = 37;
            dtBirthday.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
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
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Location = new System.Drawing.Point(381, 173);
            lbRole.Name = "lbRole";
            lbRole.Size = new System.Drawing.Size(39, 20);
            lbRole.TabIndex = 36;
            lbRole.Text = "Role";
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
            // lbShiftOff
            // 
            lbShiftOff.AutoSize = true;
            lbShiftOff.Location = new System.Drawing.Point(381, 126);
            lbShiftOff.Name = "lbShiftOff";
            lbShiftOff.Size = new System.Drawing.Size(64, 20);
            lbShiftOff.TabIndex = 35;
            lbShiftOff.Text = "Shift Off";
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
            // lbHourlyWage
            // 
            lbHourlyWage.AutoSize = true;
            lbHourlyWage.Location = new System.Drawing.Point(381, 77);
            lbHourlyWage.Name = "lbHourlyWage";
            lbHourlyWage.Size = new System.Drawing.Size(95, 20);
            lbHourlyWage.TabIndex = 34;
            lbHourlyWage.Text = "Hourly Wage";
            // 
            // lbBirthday
            // 
            lbBirthday.AutoSize = true;
            lbBirthday.Location = new System.Drawing.Point(381, 33);
            lbBirthday.Name = "lbBirthday";
            lbBirthday.Size = new System.Drawing.Size(68, 20);
            lbBirthday.TabIndex = 33;
            lbBirthday.Text = "Birthday ";
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
            gbFunction.Controls.Add(btnSalary);
            gbFunction.Controls.Add(btnAddShift);
            gbFunction.Controls.Add(btnShow);
            gbFunction.Controls.Add(txtFindName);
            gbFunction.Controls.Add(btnCreate);
            gbFunction.Controls.Add(btnSearch);
            gbFunction.Controls.Add(btnUpdate);
            gbFunction.Location = new System.Drawing.Point(687, 12);
            gbFunction.Name = "gbFunction";
            gbFunction.Size = new System.Drawing.Size(334, 256);
            gbFunction.TabIndex = 7;
            gbFunction.TabStop = false;
            gbFunction.Text = "Function";
            // 
            // btnSalary
            // 
            btnSalary.Location = new System.Drawing.Point(198, 101);
            btnSalary.Name = "btnSalary";
            btnSalary.Size = new System.Drawing.Size(94, 29);
            btnSalary.TabIndex = 11;
            btnSalary.Text = "Salary";
            btnSalary.UseVisualStyleBackColor = true;
            btnSalary.Click += btnSalary_Click;
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
            // FrmManageStaff
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1033, 597);
            Controls.Add(gbFunction);
            Controls.Add(gbInformation);
            Controls.Add(lbStaffList);
            Controls.Add(dgvStaffList);
            Name = "FrmManageStaff";
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
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbFunction;
        private System.Windows.Forms.TextBox txtFindName;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnAddShift;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox txtHourlyWage;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.NumericUpDown numShiftOff;
        private System.Windows.Forms.DateTimePicker dtBirthday;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbShiftOff;
        private System.Windows.Forms.Label lbHourlyWage;
        private System.Windows.Forms.Label lbBirthday;
    }
}
