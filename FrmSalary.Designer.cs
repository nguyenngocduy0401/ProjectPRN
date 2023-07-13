namespace ProjectPRN
{
    partial class FrmSalary
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
            dgvListSalary = new System.Windows.Forms.DataGridView();
            pnlRight = new System.Windows.Forms.Panel();
            Detail = new System.Windows.Forms.Panel();
            dtpDateEarn = new System.Windows.Forms.DateTimePicker();
            label3 = new System.Windows.Forms.Label();
            txtStaffID = new System.Windows.Forms.TextBox();
            txtSalaryDetailsID = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtTotalSalary = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtOnlShift = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            groupBox7 = new System.Windows.Forms.GroupBox();
            btnSearch = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            dtpTo = new System.Windows.Forms.DateTimePicker();
            dtpFrom = new System.Windows.Forms.DateTimePicker();
            groupBox5 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            btnPrint = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            pnlCenter.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListSalary).BeginInit();
            pnlRight.SuspendLayout();
            Detail.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
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
            pnlCenter.Size = new System.Drawing.Size(645, 580);
            pnlCenter.TabIndex = 6;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dgvListSalary);
            groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox6.ForeColor = System.Drawing.Color.Blue;
            groupBox6.Location = new System.Drawing.Point(0, 0);
            groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox6.Size = new System.Drawing.Size(645, 461);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "Salary";
            // 
            // dgvListSalary
            // 
            dgvListSalary.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dgvListSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListSalary.Location = new System.Drawing.Point(0, 29);
            dgvListSalary.Name = "dgvListSalary";
            dgvListSalary.RowTemplate.Height = 25;
            dgvListSalary.Size = new System.Drawing.Size(645, 389);
            dgvListSalary.TabIndex = 0;
            dgvListSalary.CellContentClick += dgvListSalary_CellContentClick;
            dgvListSalary.CellDoubleClick += dgvListSalary_CellDoubleClick;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            pnlRight.Controls.Add(Detail);
            pnlRight.Controls.Add(groupBox3);
            pnlRight.Controls.Add(groupBox7);
            pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            pnlRight.Location = new System.Drawing.Point(645, 0);
            pnlRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlRight.MaximumSize = new System.Drawing.Size(817, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new System.Drawing.Size(415, 580);
            pnlRight.TabIndex = 5;
            // 
            // Detail
            // 
            Detail.BackColor = System.Drawing.Color.Silver;
            Detail.Controls.Add(dtpDateEarn);
            Detail.Controls.Add(label3);
            Detail.Controls.Add(txtStaffID);
            Detail.Controls.Add(txtSalaryDetailsID);
            Detail.Controls.Add(label1);
            Detail.Controls.Add(txtTotalSalary);
            Detail.Controls.Add(label2);
            Detail.Controls.Add(label4);
            Detail.Controls.Add(txtOnlShift);
            Detail.Controls.Add(label5);
            Detail.Location = new System.Drawing.Point(0, 150);
            Detail.Name = "Detail";
            Detail.Size = new System.Drawing.Size(415, 430);
            Detail.TabIndex = 5;
            // 
            // dtpDateEarn
            // 
            dtpDateEarn.Location = new System.Drawing.Point(147, 226);
            dtpDateEarn.Name = "dtpDateEarn";
            dtpDateEarn.Size = new System.Drawing.Size(208, 23);
            dtpDateEarn.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Location = new System.Drawing.Point(58, 112);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 15);
            label3.TabIndex = 21;
            label3.Text = "SalaryDetailsID";
            // 
            // txtStaffID
            // 
            txtStaffID.Location = new System.Drawing.Point(147, 149);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new System.Drawing.Size(208, 23);
            txtStaffID.TabIndex = 16;
            // 
            // txtSalaryDetailsID
            // 
            txtSalaryDetailsID.Location = new System.Drawing.Point(147, 109);
            txtSalaryDetailsID.Name = "txtSalaryDetailsID";
            txtSalaryDetailsID.Size = new System.Drawing.Size(208, 23);
            txtSalaryDetailsID.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(58, 152);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(42, 15);
            label1.TabIndex = 12;
            label1.Text = "StaffID";
            // 
            // txtTotalSalary
            // 
            txtTotalSalary.Location = new System.Drawing.Point(147, 261);
            txtTotalSalary.Name = "txtTotalSalary";
            txtTotalSalary.Size = new System.Drawing.Size(208, 23);
            txtTotalSalary.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(58, 189);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 15);
            label2.TabIndex = 13;
            label2.Text = "OnlShift";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(58, 226);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(54, 15);
            label4.TabIndex = 14;
            label4.Text = "DateEarn";
            // 
            // txtOnlShift
            // 
            txtOnlShift.Location = new System.Drawing.Point(147, 186);
            txtOnlShift.Name = "txtOnlShift";
            txtOnlShift.Size = new System.Drawing.Size(208, 23);
            txtOnlShift.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(58, 264);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(63, 15);
            label5.TabIndex = 15;
            label5.Text = "TotalSalary";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = System.Drawing.Color.Silver;
            groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox3.ForeColor = System.Drawing.Color.Blue;
            groupBox3.Location = new System.Drawing.Point(0, 150);
            groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Size = new System.Drawing.Size(415, 32);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
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
            groupBox7.Size = new System.Drawing.Size(415, 150);
            groupBox7.TabIndex = 0;
            groupBox7.TabStop = false;
            groupBox7.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnSearch.Location = new System.Drawing.Point(305, 106);
            btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(100, 29);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Enabled = false;
            label7.Location = new System.Drawing.Point(28, 74);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(27, 20);
            label7.TabIndex = 18;
            label7.Text = "To";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Location = new System.Drawing.Point(28, 33);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(46, 20);
            label6.TabIndex = 17;
            label6.Text = "From";
            // 
            // dtpTo
            // 
            dtpTo.Location = new System.Drawing.Point(80, 74);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new System.Drawing.Size(275, 26);
            dtpTo.TabIndex = 16;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new System.Drawing.Point(80, 29);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new System.Drawing.Size(275, 26);
            dtpFrom.TabIndex = 15;
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
            groupBox5.Size = new System.Drawing.Size(645, 108);
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
            flowLayoutPanel1.Controls.Add(btnPrint);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(4, 22);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flowLayoutPanel1.MinimumSize = new System.Drawing.Size(700, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(700, 83);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // btnPrint
            // 
            btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnPrint.Location = new System.Drawing.Point(407, 3);
            btnPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new System.Drawing.Size(128, 73);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "Print All";
            btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
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
            // panel1
            // 
            panel1.Controls.Add(groupBox5);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 461);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(645, 119);
            panel1.TabIndex = 1;
            // 
            // FrmSalary
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1060, 580);
            Controls.Add(pnlCenter);
            Controls.Add(pnlRight);
            Name = "FrmSalary";
            Text = "FrmSalary";
            Load += FrmSalary_Load;
            pnlCenter.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListSalary).EndInit();
            pnlRight.ResumeLayout(false);
            Detail.ResumeLayout(false);
            Detail.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox5.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvListSalary;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel Detail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DateTimePicker dtpDateEarn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtSalaryDetailsID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOnlShift;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPrint;
    }
}