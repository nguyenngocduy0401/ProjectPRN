namespace ProjectPRN
{
    partial class FrmManagerShift
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
            pnlCenter = new System.Windows.Forms.Panel();
            groupBox6 = new System.Windows.Forms.GroupBox();
            dgvListShift = new System.Windows.Forms.DataGridView();
            panel1 = new System.Windows.Forms.Panel();
            groupBox5 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            btnDelete = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            groupBox7 = new System.Windows.Forms.GroupBox();
            btnSearch = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            dtpTo = new System.Windows.Forms.DateTimePicker();
            dtpFrom = new System.Windows.Forms.DateTimePicker();
            groupBox3 = new System.Windows.Forms.GroupBox();
            pnlRight = new System.Windows.Forms.Panel();
            Detail = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            txtSalaryDetailsID = new System.Windows.Forms.TextBox();
            txtEndTime = new System.Windows.Forms.TextBox();
            txtStartTime = new System.Windows.Forms.TextBox();
            txtShiftName = new System.Windows.Forms.TextBox();
            txtShiftID = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pnlCenter.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListShift).BeginInit();
            panel1.SuspendLayout();
            groupBox5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox7.SuspendLayout();
            pnlRight.SuspendLayout();
            Detail.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCenter
            // 
            pnlCenter.Controls.Add(groupBox6);
            pnlCenter.Controls.Add(panel1);
            pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlCenter.Location = new System.Drawing.Point(0, 0);
            pnlCenter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlCenter.Name = "pnlCenter";
            pnlCenter.Size = new System.Drawing.Size(689, 543);
            pnlCenter.TabIndex = 4;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dgvListShift);
            groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox6.ForeColor = System.Drawing.Color.Blue;
            groupBox6.Location = new System.Drawing.Point(0, 0);
            groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox6.Size = new System.Drawing.Size(689, 424);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "Shift";
            // 
            // dgvListShift
            // 
            dgvListShift.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dgvListShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListShift.Location = new System.Drawing.Point(0, 29);
            dgvListShift.Name = "dgvListShift";
            dgvListShift.RowTemplate.Height = 25;
            dgvListShift.Size = new System.Drawing.Size(689, 389);
            dgvListShift.TabIndex = 0;
            dgvListShift.CellContentClick += dgvListShift_CellContentClick;
            dgvListShift.CellDoubleClick += dgvListShift_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox5);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 424);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(689, 119);
            panel1.TabIndex = 1;
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
            groupBox5.Size = new System.Drawing.Size(689, 108);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Manipulation:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Controls.Add(btnUpdate);
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(4, 22);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flowLayoutPanel1.MinimumSize = new System.Drawing.Size(700, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(700, 83);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // btnDelete
            // 
            btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnDelete.Location = new System.Drawing.Point(4, 3);
            btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(115, 73);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnUpdate.Location = new System.Drawing.Point(127, 3);
            btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(136, 73);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Update";
            btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnAdd.Location = new System.Drawing.Point(271, 3);
            btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(128, 73);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox7
            // 
            groupBox7.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            groupBox7.Controls.Add(btnSearch);
            groupBox7.Controls.Add(label7);
            groupBox7.Controls.Add(label6);
            groupBox7.Controls.Add(dtpTo);
            groupBox7.Controls.Add(dtpFrom);
            groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox7.ForeColor = System.Drawing.Color.Blue;
            groupBox7.Location = new System.Drawing.Point(0, 0);
            groupBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox7.Size = new System.Drawing.Size(415, 143);
            groupBox7.TabIndex = 0;
            groupBox7.TabStop = false;
            groupBox7.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnSearch.Location = new System.Drawing.Point(286, 102);
            btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(100, 29);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Enabled = false;
            label7.Location = new System.Drawing.Point(9, 70);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(27, 20);
            label7.TabIndex = 13;
            label7.Text = "To";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Location = new System.Drawing.Point(9, 29);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(46, 20);
            label6.TabIndex = 12;
            label6.Text = "From";
            label6.Click += label6_Click;
            // 
            // dtpTo
            // 
            dtpTo.Location = new System.Drawing.Point(61, 70);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new System.Drawing.Size(275, 26);
            dtpTo.TabIndex = 2;
            dtpTo.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new System.Drawing.Point(61, 25);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new System.Drawing.Size(275, 26);
            dtpFrom.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = System.Drawing.Color.Silver;
            groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox3.ForeColor = System.Drawing.Color.Blue;
            groupBox3.Location = new System.Drawing.Point(0, 143);
            groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Size = new System.Drawing.Size(415, 10);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            pnlRight.Controls.Add(Detail);
            pnlRight.Controls.Add(groupBox3);
            pnlRight.Controls.Add(groupBox7);
            pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            pnlRight.Location = new System.Drawing.Point(689, 0);
            pnlRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlRight.MaximumSize = new System.Drawing.Size(817, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new System.Drawing.Size(415, 543);
            pnlRight.TabIndex = 3;
            // 
            // Detail
            // 
            Detail.BackColor = System.Drawing.Color.LightGray;
            Detail.Controls.Add(label3);
            Detail.Controls.Add(txtSalaryDetailsID);
            Detail.Controls.Add(txtEndTime);
            Detail.Controls.Add(txtStartTime);
            Detail.Controls.Add(txtShiftName);
            Detail.Controls.Add(txtShiftID);
            Detail.Controls.Add(label5);
            Detail.Controls.Add(label4);
            Detail.Controls.Add(label2);
            Detail.Controls.Add(label1);
            Detail.Location = new System.Drawing.Point(0, 141);
            Detail.Name = "Detail";
            Detail.Size = new System.Drawing.Size(415, 402);
            Detail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Location = new System.Drawing.Point(61, 101);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 15);
            label3.TabIndex = 11;
            label3.Text = "SalaryDetailsID";
            // 
            // txtSalaryDetailsID
            // 
            txtSalaryDetailsID.Location = new System.Drawing.Point(150, 98);
            txtSalaryDetailsID.Name = "txtSalaryDetailsID";
            txtSalaryDetailsID.Size = new System.Drawing.Size(208, 23);
            txtSalaryDetailsID.TabIndex = 10;
            // 
            // txtEndTime
            // 
            txtEndTime.Location = new System.Drawing.Point(150, 250);
            txtEndTime.Name = "txtEndTime";
            txtEndTime.Size = new System.Drawing.Size(208, 23);
            txtEndTime.TabIndex = 9;
            // 
            // txtStartTime
            // 
            txtStartTime.Location = new System.Drawing.Point(150, 212);
            txtStartTime.Name = "txtStartTime";
            txtStartTime.Size = new System.Drawing.Size(208, 23);
            txtStartTime.TabIndex = 8;
            // 
            // txtShiftName
            // 
            txtShiftName.Location = new System.Drawing.Point(150, 175);
            txtShiftName.Name = "txtShiftName";
            txtShiftName.Size = new System.Drawing.Size(208, 23);
            txtShiftName.TabIndex = 6;
            // 
            // txtShiftID
            // 
            txtShiftID.Location = new System.Drawing.Point(150, 138);
            txtShiftID.Name = "txtShiftID";
            txtShiftID.Size = new System.Drawing.Size(208, 23);
            txtShiftID.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(61, 253);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(63, 15);
            label5.TabIndex = 4;
            label5.Text = "TotalSalary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(61, 215);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "DateEarn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(61, 178);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "OnlShift";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(61, 141);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "StaffID";
            // 
            // FrmManagerShift
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1104, 543);
            Controls.Add(pnlCenter);
            Controls.Add(pnlRight);
            Name = "FrmManagerShift";
            Text = "FrmManagerShift";
            Load += FrmManagerShift_Load;
            pnlCenter.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListShift).EndInit();
            panel1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            pnlRight.ResumeLayout(false);
            Detail.ResumeLayout(false);
            Detail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvListShift;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cbbMenu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtShiftName;
        private System.Windows.Forms.TextBox txtShiftID;
        private System.Windows.Forms.Panel Detail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalaryDetailsID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
    }
}