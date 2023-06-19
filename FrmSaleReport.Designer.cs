
namespace CoffeeManager
{
    partial class FrmSaleReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaleReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            BtnClear = new System.Windows.Forms.Button();
            GrbDateTime = new System.Windows.Forms.GroupBox();
            lblShowErr = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            DtpDayFrom = new System.Windows.Forms.DateTimePicker();
            DtpMonthFrom = new System.Windows.Forms.DateTimePicker();
            DtpYearFrom = new System.Windows.Forms.DateTimePicker();
            label9 = new System.Windows.Forms.Label();
            TxtProduct = new System.Windows.Forms.TextBox();
            DgvMain = new System.Windows.Forms.DataGridView();
            idBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColNameTb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColCusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            drink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            intoMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel2 = new System.Windows.Forms.Panel();
            PrbWait = new System.Windows.Forms.ProgressBar();
            BtnOk = new System.Windows.Forms.Button();
            label10 = new System.Windows.Forms.Label();
            TxtTotalMoney = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            panel1.SuspendLayout();
            GrbDateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvMain).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnClear);
            panel1.Controls.Add(GrbDateTime);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(TxtProduct);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // BtnClear
            // 
            resources.ApplyResources(BtnClear, "BtnClear");
            BtnClear.Name = "BtnClear";
            BtnClear.UseVisualStyleBackColor = true;
            // 
            // GrbDateTime
            // 
            GrbDateTime.Controls.Add(label1);
            GrbDateTime.Controls.Add(label5);
            GrbDateTime.Controls.Add(label6);
            GrbDateTime.Controls.Add(dateTimePicker1);
            GrbDateTime.Controls.Add(dateTimePicker2);
            GrbDateTime.Controls.Add(dateTimePicker3);
            GrbDateTime.Controls.Add(lblShowErr);
            GrbDateTime.Controls.Add(label4);
            GrbDateTime.Controls.Add(label3);
            GrbDateTime.Controls.Add(label2);
            GrbDateTime.Controls.Add(DtpDayFrom);
            GrbDateTime.Controls.Add(DtpMonthFrom);
            GrbDateTime.Controls.Add(DtpYearFrom);
            resources.ApplyResources(GrbDateTime, "GrbDateTime");
            GrbDateTime.Name = "GrbDateTime";
            GrbDateTime.TabStop = false;
            // 
            // lblShowErr
            // 
            resources.ApplyResources(lblShowErr, "lblShowErr");
            lblShowErr.ForeColor = System.Drawing.Color.Red;
            lblShowErr.Name = "lblShowErr";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // DtpDayFrom
            // 
            resources.ApplyResources(DtpDayFrom, "DtpDayFrom");
            DtpDayFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            DtpDayFrom.Name = "DtpDayFrom";
            DtpDayFrom.ShowUpDown = true;
            // 
            // DtpMonthFrom
            // 
            resources.ApplyResources(DtpMonthFrom, "DtpMonthFrom");
            DtpMonthFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            DtpMonthFrom.Name = "DtpMonthFrom";
            DtpMonthFrom.ShowUpDown = true;
            // 
            // DtpYearFrom
            // 
            resources.ApplyResources(DtpYearFrom, "DtpYearFrom");
            DtpYearFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            DtpYearFrom.Name = "DtpYearFrom";
            DtpYearFrom.ShowUpDown = true;
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // TxtProduct
            // 
            resources.ApplyResources(TxtProduct, "TxtProduct");
            TxtProduct.Name = "TxtProduct";
            // 
            // DgvMain
            // 
            DgvMain.AllowUserToAddRows = false;
            DgvMain.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            DgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idBill, ColNameTb, ColCusName, drink, ColFullName, ColDate, unitPrice, quantity, intoMoney });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            DgvMain.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(DgvMain, "DgvMain");
            DgvMain.GridColor = System.Drawing.Color.White;
            DgvMain.Name = "DgvMain";
            DgvMain.RowHeadersVisible = false;
            DgvMain.RowTemplate.Height = 30;
            DgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // idBill
            // 
            idBill.DataPropertyName = "id";
            resources.ApplyResources(idBill, "idBill");
            idBill.Name = "idBill";
            // 
            // ColNameTb
            // 
            ColNameTb.DataPropertyName = "nameTb";
            resources.ApplyResources(ColNameTb, "ColNameTb");
            ColNameTb.Name = "ColNameTb";
            // 
            // ColCusName
            // 
            ColCusName.DataPropertyName = "nameCus";
            resources.ApplyResources(ColCusName, "ColCusName");
            ColCusName.Name = "ColCusName";
            // 
            // drink
            // 
            drink.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            drink.DataPropertyName = "name";
            resources.ApplyResources(drink, "drink");
            drink.Name = "drink";
            drink.ReadOnly = true;
            // 
            // ColFullName
            // 
            ColFullName.DataPropertyName = "fullName";
            resources.ApplyResources(ColFullName, "ColFullName");
            ColFullName.Name = "ColFullName";
            // 
            // ColDate
            // 
            ColDate.DataPropertyName = "billDate";
            resources.ApplyResources(ColDate, "ColDate");
            ColDate.Name = "ColDate";
            // 
            // unitPrice
            // 
            unitPrice.DataPropertyName = "unitPrice";
            resources.ApplyResources(unitPrice, "unitPrice");
            unitPrice.Name = "unitPrice";
            // 
            // quantity
            // 
            quantity.DataPropertyName = "quantity";
            resources.ApplyResources(quantity, "quantity");
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            // 
            // intoMoney
            // 
            intoMoney.DataPropertyName = "intoMoney";
            resources.ApplyResources(intoMoney, "intoMoney");
            intoMoney.Name = "intoMoney";
            // 
            // panel2
            // 
            panel2.Controls.Add(PrbWait);
            panel2.Controls.Add(BtnOk);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(TxtTotalMoney);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // PrbWait
            // 
            resources.ApplyResources(PrbWait, "PrbWait");
            PrbWait.Name = "PrbWait";
            // 
            // BtnOk
            // 
            BtnOk.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(BtnOk, "BtnOk");
            BtnOk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            BtnOk.Name = "BtnOk";
            BtnOk.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // TxtTotalMoney
            // 
            resources.ApplyResources(TxtTotalMoney, "TxtTotalMoney");
            TxtTotalMoney.ForeColor = System.Drawing.Color.Red;
            TxtTotalMoney.Name = "TxtTotalMoney";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(dateTimePicker1, "dateTimePicker1");
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            // 
            // dateTimePicker2
            // 
            resources.ApplyResources(dateTimePicker2, "dateTimePicker2");
            dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            // 
            // dateTimePicker3
            // 
            resources.ApplyResources(dateTimePicker3, "dateTimePicker3");
            dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.ShowUpDown = true;
            // 
            // FrmSaleReport
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(DgvMain);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmSaleReport";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            GrbDateTime.ResumeLayout(false);
            GrbDateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvMain).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtProduct;
        private System.Windows.Forms.DataGridView DgvMain;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox GrbDateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpDayFrom;
        private System.Windows.Forms.DateTimePicker DtpMonthFrom;
        private System.Windows.Forms.DateTimePicker DtpYearFrom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtTotalMoney;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label lblShowErr;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNameTb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn drink;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn intoMoney;
        private System.Windows.Forms.ProgressBar PrbWait;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
    }
}