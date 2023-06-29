
namespace CoffeeManager
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            pnlRight = new System.Windows.Forms.Panel();
            flpRight = new System.Windows.Forms.FlowLayoutPanel();
            groupBox3 = new System.Windows.Forms.GroupBox();
            BtnAddPr = new System.Windows.Forms.Button();
            btnX = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            groupBox7 = new System.Windows.Forms.GroupBox();
            cbbMenu = new System.Windows.Forms.ComboBox();
            pnlCenter = new System.Windows.Forms.Panel();
            groupBox6 = new System.Windows.Forms.GroupBox();
            dgvMain = new System.Windows.Forms.DataGridView();
            drink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            quantily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            intoMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1 = new System.Windows.Forms.Panel();
            groupBox8 = new System.Windows.Forms.GroupBox();
            txtDescription = new System.Windows.Forms.TextBox();
            txtMoneyReturn = new System.Windows.Forms.Label();
            txtTotalMoney = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtMoneyPay = new System.Windows.Forms.TextBox();
            groupBox5 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            btnSave = new System.Windows.Forms.Button();
            btnPay = new System.Windows.Forms.Button();
            pnlRight.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox7.SuspendLayout();
            pnlCenter.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            panel1.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRight
            // 
            resources.ApplyResources(pnlRight, "pnlRight");
            pnlRight.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            pnlRight.Controls.Add(flpRight);
            pnlRight.Controls.Add(groupBox3);
            pnlRight.Controls.Add(groupBox7);
            pnlRight.Name = "pnlRight";
            // 
            // flpRight
            // 
            resources.ApplyResources(flpRight, "flpRight");
            flpRight.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            flpRight.Name = "flpRight";
            // 
            // groupBox3
            // 
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.BackColor = System.Drawing.Color.Silver;
            groupBox3.Controls.Add(BtnAddPr);
            groupBox3.Controls.Add(btnX);
            groupBox3.Controls.Add(txtSearch);
            groupBox3.ForeColor = System.Drawing.Color.Blue;
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            // 
            // BtnAddPr
            // 
            resources.ApplyResources(BtnAddPr, "BtnAddPr");
            BtnAddPr.Name = "BtnAddPr";
            BtnAddPr.UseVisualStyleBackColor = true;
            // 
            // btnX
            // 
            resources.ApplyResources(btnX, "btnX");
            btnX.ForeColor = System.Drawing.Color.Red;
            btnX.Name = "btnX";
            btnX.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            resources.ApplyResources(txtSearch, "txtSearch");
            txtSearch.Name = "txtSearch";
            // 
            // groupBox7
            // 
            resources.ApplyResources(groupBox7, "groupBox7");
            groupBox7.Controls.Add(cbbMenu);
            groupBox7.ForeColor = System.Drawing.Color.Blue;
            groupBox7.Name = "groupBox7";
            groupBox7.TabStop = false;
            // 
            // cbbMenu
            // 
            resources.ApplyResources(cbbMenu, "cbbMenu");
            cbbMenu.BackColor = System.Drawing.Color.White;
            cbbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbMenu.FormattingEnabled = true;
            cbbMenu.Name = "cbbMenu";
            // 
            // pnlCenter
            // 
            resources.ApplyResources(pnlCenter, "pnlCenter");
            pnlCenter.Controls.Add(groupBox6);
            pnlCenter.Controls.Add(panel1);
            pnlCenter.Name = "pnlCenter";
            // 
            // groupBox6
            // 
            resources.ApplyResources(groupBox6, "groupBox6");
            groupBox6.Controls.Add(dgvMain);
            groupBox6.ForeColor = System.Drawing.Color.Blue;
            groupBox6.Name = "groupBox6";
            groupBox6.TabStop = false;
            // 
            // dgvMain
            // 
            resources.ApplyResources(dgvMain, "dgvMain");
            dgvMain.BackgroundColor = System.Drawing.Color.White;
            dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { drink, id, unitPrice, quantily, idBill, idProduct, intoMoney, description });
            dgvMain.GridColor = System.Drawing.Color.White;
            dgvMain.Name = "dgvMain";
            dgvMain.RowHeadersVisible = false;
            dgvMain.RowTemplate.Height = 30;
            dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // drink
            // 
            drink.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            drink.DataPropertyName = "drink";
            resources.ApplyResources(drink, "drink");
            drink.Name = "drink";
            drink.ReadOnly = true;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            resources.ApplyResources(id, "id");
            id.Name = "id";
            // 
            // unitPrice
            // 
            unitPrice.DataPropertyName = "unitPrice";
            resources.ApplyResources(unitPrice, "unitPrice");
            unitPrice.Name = "unitPrice";
            // 
            // quantily
            // 
            quantily.DataPropertyName = "quantity";
            resources.ApplyResources(quantily, "quantily");
            quantily.Name = "quantily";
            quantily.ReadOnly = true;
            // 
            // idBill
            // 
            idBill.DataPropertyName = "idBill";
            resources.ApplyResources(idBill, "idBill");
            idBill.Name = "idBill";
            // 
            // idProduct
            // 
            idProduct.DataPropertyName = "idProduct";
            resources.ApplyResources(idProduct, "idProduct");
            idProduct.Name = "idProduct";
            // 
            // intoMoney
            // 
            intoMoney.DataPropertyName = "intoMoney";
            resources.ApplyResources(intoMoney, "intoMoney");
            intoMoney.Name = "intoMoney";
            // 
            // description
            // 
            description.DataPropertyName = "description";
            resources.ApplyResources(description, "description");
            description.Name = "description";
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(groupBox8);
            panel1.Controls.Add(groupBox5);
            panel1.Name = "panel1";
            // 
            // groupBox8
            // 
            resources.ApplyResources(groupBox8, "groupBox8");
            groupBox8.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            groupBox8.Controls.Add(txtDescription);
            groupBox8.Controls.Add(txtMoneyReturn);
            groupBox8.Controls.Add(txtTotalMoney);
            groupBox8.Controls.Add(label1);
            groupBox8.Controls.Add(label4);
            groupBox8.Controls.Add(label2);
            groupBox8.Controls.Add(label3);
            groupBox8.Controls.Add(txtMoneyPay);
            groupBox8.ForeColor = System.Drawing.Color.Blue;
            groupBox8.Name = "groupBox8";
            groupBox8.TabStop = false;
            // 
            // txtDescription
            // 
            resources.ApplyResources(txtDescription, "txtDescription");
            txtDescription.Name = "txtDescription";
            // 
            // txtMoneyReturn
            // 
            resources.ApplyResources(txtMoneyReturn, "txtMoneyReturn");
            txtMoneyReturn.ForeColor = System.Drawing.Color.Red;
            txtMoneyReturn.Name = "txtMoneyReturn";
            // 
            // txtTotalMoney
            // 
            resources.ApplyResources(txtTotalMoney, "txtTotalMoney");
            txtTotalMoney.ForeColor = System.Drawing.Color.Red;
            txtTotalMoney.Name = "txtTotalMoney";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // txtMoneyPay
            // 
            resources.ApplyResources(txtMoneyPay, "txtMoneyPay");
            txtMoneyPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtMoneyPay.ForeColor = System.Drawing.Color.Blue;
            txtMoneyPay.Name = "txtMoneyPay";
            // 
            // groupBox5
            // 
            resources.ApplyResources(groupBox5, "groupBox5");
            groupBox5.Controls.Add(flowLayoutPanel1);
            groupBox5.ForeColor = System.Drawing.Color.Blue;
            groupBox5.Name = "groupBox5";
            groupBox5.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Controls.Add(btnPay);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // btnSave
            // 
            resources.ApplyResources(btnSave, "btnSave");
            btnSave.Name = "btnSave";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            resources.ApplyResources(btnPay, "btnPay");
            btnPay.Name = "btnPay";
            btnPay.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pnlCenter);
            Controls.Add(pnlRight);
            Name = "FrmMain";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            pnlRight.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox7.ResumeLayout(false);
            pnlCenter.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            panel1.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox5.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cbbMenu;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMoneyPay;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label txtTotalMoney;
        private System.Windows.Forms.Label txtMoneyReturn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.FlowLayoutPanel flpRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn drink;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantily;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn intoMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Button BtnAddPr;
    }
}

