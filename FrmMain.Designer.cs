
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
            this.pnlRight = new System.Windows.Forms.Panel();
            this.flpRight = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnAddPr = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbbMenu = new System.Windows.Forms.ComboBox();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.drink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intoMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtMoneyReturn = new System.Windows.Forms.Label();
            this.txtTotalMoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMoneyPay = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.pnlRight.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRight
            // 
            resources.ApplyResources(this.pnlRight, "pnlRight");
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlRight.Controls.Add(this.flpRight);
            this.pnlRight.Controls.Add(this.groupBox3);
            this.pnlRight.Controls.Add(this.groupBox7);
            this.pnlRight.Name = "pnlRight";
            // 
            // flpRight
            // 
            resources.ApplyResources(this.flpRight, "flpRight");
            this.flpRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.flpRight.Name = "flpRight";
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.BtnAddPr);
            this.groupBox3.Controls.Add(this.btnX);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // BtnAddPr
            // 
            resources.ApplyResources(this.BtnAddPr, "BtnAddPr");
            this.BtnAddPr.Name = "BtnAddPr";
            this.BtnAddPr.UseVisualStyleBackColor = true;
            // 
            // btnX
            // 
            resources.ApplyResources(this.btnX, "btnX");
            this.btnX.ForeColor = System.Drawing.Color.Red;
            this.btnX.Name = "btnX";
            this.btnX.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            // 
            // groupBox7
            // 
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Controls.Add(this.cbbMenu);
            this.groupBox7.ForeColor = System.Drawing.Color.Blue;
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // cbbMenu
            // 
            resources.ApplyResources(this.cbbMenu, "cbbMenu");
            this.cbbMenu.BackColor = System.Drawing.Color.White;
            this.cbbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMenu.FormattingEnabled = true;
            this.cbbMenu.Name = "cbbMenu";
            // 
            // pnlCenter
            // 
            resources.ApplyResources(this.pnlCenter, "pnlCenter");
            this.pnlCenter.Controls.Add(this.groupBox6);
            this.pnlCenter.Controls.Add(this.panel1);
            this.pnlCenter.Name = "pnlCenter";
            // 
            // groupBox6
            // 
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Controls.Add(this.dgvMain);
            this.groupBox6.ForeColor = System.Drawing.Color.Blue;
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // dgvMain
            // 
            resources.ApplyResources(this.dgvMain, "dgvMain");
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drink,
            this.id,
            this.unitPrice,
            this.quantily,
            this.idBill,
            this.idProduct,
            this.intoMoney,
            this.description});
            this.dgvMain.GridColor = System.Drawing.Color.White;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowTemplate.Height = 30;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // drink
            // 
            this.drink.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.drink.DataPropertyName = "drink";
            resources.ApplyResources(this.drink, "drink");
            this.drink.Name = "drink";
            this.drink.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            // 
            // unitPrice
            // 
            this.unitPrice.DataPropertyName = "unitPrice";
            resources.ApplyResources(this.unitPrice, "unitPrice");
            this.unitPrice.Name = "unitPrice";
            // 
            // quantily
            // 
            this.quantily.DataPropertyName = "quantity";
            resources.ApplyResources(this.quantily, "quantily");
            this.quantily.Name = "quantily";
            this.quantily.ReadOnly = true;
            // 
            // idBill
            // 
            this.idBill.DataPropertyName = "idBill";
            resources.ApplyResources(this.idBill, "idBill");
            this.idBill.Name = "idBill";
            // 
            // idProduct
            // 
            this.idProduct.DataPropertyName = "idProduct";
            resources.ApplyResources(this.idProduct, "idProduct");
            this.idProduct.Name = "idProduct";
            // 
            // intoMoney
            // 
            this.intoMoney.DataPropertyName = "intoMoney";
            resources.ApplyResources(this.intoMoney, "intoMoney");
            this.intoMoney.Name = "intoMoney";
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            resources.ApplyResources(this.description, "description");
            this.description.Name = "description";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Name = "panel1";
            // 
            // groupBox8
            // 
            resources.ApplyResources(this.groupBox8, "groupBox8");
            this.groupBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox8.Controls.Add(this.txtDescription);
            this.groupBox8.Controls.Add(this.txtMoneyReturn);
            this.groupBox8.Controls.Add(this.txtTotalMoney);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.txtMoneyPay);
            this.groupBox8.ForeColor = System.Drawing.Color.Blue;
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.TabStop = false;
            // 
            // txtDescription
            // 
            resources.ApplyResources(this.txtDescription, "txtDescription");
            this.txtDescription.Name = "txtDescription";
            // 
            // txtMoneyReturn
            // 
            resources.ApplyResources(this.txtMoneyReturn, "txtMoneyReturn");
            this.txtMoneyReturn.ForeColor = System.Drawing.Color.Red;
            this.txtMoneyReturn.Name = "txtMoneyReturn";
            // 
            // txtTotalMoney
            // 
            resources.ApplyResources(this.txtTotalMoney, "txtTotalMoney");
            this.txtTotalMoney.ForeColor = System.Drawing.Color.Red;
            this.txtTotalMoney.Name = "txtTotalMoney";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtMoneyPay
            // 
            resources.ApplyResources(this.txtMoneyPay, "txtMoneyPay");
            this.txtMoneyPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoneyPay.ForeColor = System.Drawing.Color.Blue;
            this.txtMoneyPay.Name = "txtMoneyPay";
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.flowLayoutPanel1);
            this.groupBox5.ForeColor = System.Drawing.Color.Blue;
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.btnPay);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            resources.ApplyResources(this.btnPay, "btnPay");
            this.btnPay.Name = "btnPay";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlRight);
            this.Name = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlRight.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

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

