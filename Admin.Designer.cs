namespace ProjectPRN211
{
    partial class Admin
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
            dtBirthday = new System.Windows.Forms.DateTimePicker();
            txtPhone = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            lbEmail = new System.Windows.Forms.Label();
            lbRole = new System.Windows.Forms.Label();
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
            btnSalary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvStaffList).BeginInit();
            gbInformation.SuspendLayout();
            gbFunction.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStaffList
            // 
            dgvStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaffList.Location = new System.Drawing.Point(-10, 232);
            dgvStaffList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvStaffList.Name = "dgvStaffList";
            dgvStaffList.RowHeadersWidth = 51;
            dgvStaffList.RowTemplate.Height = 29;
            dgvStaffList.Size = new System.Drawing.Size(883, 207);
            dgvStaffList.TabIndex = 0;
            dgvStaffList.CellContentClick += dgvStaffList_CellContentClick;
            dgvStaffList.CellDoubleClick += dgvStaffList_CellDoubleClick;
            dgvStaffList.EditingControlShowing += dgvStaffList_EditingControlShowing;
            // 
            // lbStaffList
            // 
            lbStaffList.AutoSize = true;
            lbStaffList.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbStaffList.Location = new System.Drawing.Point(383, 203);
            lbStaffList.Name = "lbStaffList";
            lbStaffList.Size = new System.Drawing.Size(113, 28);
            lbStaffList.TabIndex = 1;
            lbStaffList.Text = "STAFF LIST";
            // 
            // gbInformation
            // 
            gbInformation.Controls.Add(txtHourlyWage);
            gbInformation.Controls.Add(cbRole);
            gbInformation.Controls.Add(dtBirthday);
            gbInformation.Controls.Add(txtPhone);
            gbInformation.Controls.Add(txtEmail);
            gbInformation.Controls.Add(lbEmail);
            gbInformation.Controls.Add(lbRole);
            gbInformation.Controls.Add(lbHourlyWage);
            gbInformation.Controls.Add(txtName);
            gbInformation.Controls.Add(lbBirthday);
            gbInformation.Controls.Add(lbPhone);
            gbInformation.Controls.Add(lbName);
            gbInformation.Controls.Add(lbID);
            gbInformation.Controls.Add(txtID);
            gbInformation.Location = new System.Drawing.Point(10, 9);
            gbInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gbInformation.Name = "gbInformation";
            gbInformation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gbInformation.Size = new System.Drawing.Size(585, 192);
            gbInformation.TabIndex = 2;
            gbInformation.TabStop = false;
            gbInformation.Text = "Information";
            // 
            // txtHourlyWage
            // 
            txtHourlyWage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtHourlyWage.Location = new System.Drawing.Point(424, 76);
            txtHourlyWage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtHourlyWage.Name = "txtHourlyWage";
            txtHourlyWage.Size = new System.Drawing.Size(148, 23);
            txtHourlyWage.TabIndex = 20;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new System.Drawing.Point(424, 122);
            cbRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbRole.Name = "cbRole";
            cbRole.Size = new System.Drawing.Size(148, 23);
            cbRole.TabIndex = 19;
            // 
            // dtBirthday
            // 
            dtBirthday.CustomFormat = "";
            dtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtBirthday.Location = new System.Drawing.Point(424, 28);
            dtBirthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dtBirthday.MaxDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            dtBirthday.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            dtBirthday.Name = "dtBirthday";
            dtBirthday.Size = new System.Drawing.Size(148, 23);
            dtBirthday.TabIndex = 17;
            dtBirthday.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // txtPhone
            // 
            txtPhone.BackColor = System.Drawing.SystemColors.Window;
            txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPhone.Location = new System.Drawing.Point(87, 160);
            txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(225, 23);
            txtPhone.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = System.Drawing.SystemColors.Window;
            txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtEmail.Location = new System.Drawing.Point(87, 121);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(225, 23);
            txtEmail.TabIndex = 15;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(9, 122);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(36, 15);
            lbEmail.TabIndex = 12;
            lbEmail.Text = "Email";
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Location = new System.Drawing.Point(329, 126);
            lbRole.Name = "lbRole";
            lbRole.Size = new System.Drawing.Size(30, 15);
            lbRole.TabIndex = 14;
            lbRole.Text = "Role";
            // 
            // lbHourlyWage
            // 
            lbHourlyWage.AutoSize = true;
            lbHourlyWage.Location = new System.Drawing.Point(329, 79);
            lbHourlyWage.Name = "lbHourlyWage";
            lbHourlyWage.Size = new System.Drawing.Size(76, 15);
            lbHourlyWage.TabIndex = 11;
            lbHourlyWage.Text = "Hourly Wage";
            // 
            // txtName
            // 
            txtName.BackColor = System.Drawing.SystemColors.Window;
            txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtName.Location = new System.Drawing.Point(87, 76);
            txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(225, 23);
            txtName.TabIndex = 10;
            // 
            // lbBirthday
            // 
            lbBirthday.AutoSize = true;
            lbBirthday.Location = new System.Drawing.Point(329, 32);
            lbBirthday.Name = "lbBirthday";
            lbBirthday.Size = new System.Drawing.Size(54, 15);
            lbBirthday.TabIndex = 9;
            lbBirthday.Text = "Birthday ";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new System.Drawing.Point(9, 161);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new System.Drawing.Size(41, 15);
            lbPhone.TabIndex = 8;
            lbPhone.Text = "Phone";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new System.Drawing.Point(9, 78);
            lbName.Name = "lbName";
            lbName.Size = new System.Drawing.Size(61, 15);
            lbName.TabIndex = 7;
            lbName.Text = "Full Name";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new System.Drawing.Point(9, 31);
            lbID.Name = "lbID";
            lbID.Size = new System.Drawing.Size(18, 15);
            lbID.TabIndex = 6;
            lbID.Text = "ID";
            // 
            // txtID
            // 
            txtID.BackColor = System.Drawing.SystemColors.Window;
            txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtID.Location = new System.Drawing.Point(87, 28);
            txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(225, 23);
            txtID.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(34, 26);
            btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(82, 22);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(173, 25);
            btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(82, 22);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(173, 76);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(82, 22);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(189, 161);
            btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(82, 22);
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
            gbFunction.Controls.Add(btnDelete);
            gbFunction.Controls.Add(btnUpdate);
            gbFunction.Location = new System.Drawing.Point(601, 9);
            gbFunction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gbFunction.Name = "gbFunction";
            gbFunction.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gbFunction.Size = new System.Drawing.Size(292, 192);
            gbFunction.TabIndex = 7;
            gbFunction.TabStop = false;
            gbFunction.Text = "Function";
            gbFunction.Enter += gbFunction_Enter;
            // 
            // btnAddShift
            // 
            btnAddShift.Location = new System.Drawing.Point(34, 119);
            btnAddShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnAddShift.Name = "btnAddShift";
            btnAddShift.Size = new System.Drawing.Size(82, 22);
            btnAddShift.TabIndex = 9;
            btnAddShift.Text = "Add Shift";
            btnAddShift.UseVisualStyleBackColor = true;
            btnAddShift.Click += btnAddShift_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new System.Drawing.Point(34, 76);
            btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnShow.Name = "btnShow";
            btnShow.Size = new System.Drawing.Size(82, 22);
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
            txtFindName.Location = new System.Drawing.Point(14, 162);
            txtFindName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtFindName.Name = "txtFindName";
            txtFindName.PlaceholderText = "Enter Full Name";
            txtFindName.Size = new System.Drawing.Size(157, 23);
            txtFindName.TabIndex = 7;
            // 
            // btnSalary
            // 
            btnSalary.Location = new System.Drawing.Point(173, 118);
            btnSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSalary.Name = "btnSalary";
            btnSalary.Size = new System.Drawing.Size(82, 22);
            btnSalary.TabIndex = 10;
            btnSalary.Text = "Salary";
            btnSalary.UseVisualStyleBackColor = true;
            btnSalary.Click += btnSalary_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(904, 448);
            Controls.Add(gbFunction);
            Controls.Add(gbInformation);
            Controls.Add(lbStaffList);
            Controls.Add(dgvStaffList);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Admin";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)dgvStaffList).EndInit();
            gbInformation.ResumeLayout(false);
            gbInformation.PerformLayout();
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
        private System.Windows.Forms.Button btnSalary;
    }
}
