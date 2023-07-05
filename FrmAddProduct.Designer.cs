
using System.Windows.Forms;

namespace CoffeeManager
{
    partial class FrmAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddProduct));
            groupBox1 = new GroupBox();
            btnXProduct = new Button();
            btnAccept = new Button();
            lok = new Label();
            txt_Id = new TextBox();
            txtCate = new ComboBox();
            label133 = new Label();
            txtDate = new DateTimePicker();
            btnCancel = new Button();
            cbbGroup = new ComboBox();
            dat = new Label();
            pri = new Label();
            Q = new Label();
            Gr = new Label();
            ten = new Label();
            txtUnitPrice = new TextBox();
            txtUnit = new TextBox();
            txtName = new TextBox();
            btnRegis = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.SystemColors.Control;
            groupBox1.Controls.Add(btnXProduct);
            groupBox1.Controls.Add(btnAccept);
            groupBox1.Controls.Add(lok);
            groupBox1.Controls.Add(txt_Id);
            groupBox1.Controls.Add(txtCate);
            groupBox1.Controls.Add(label133);
            groupBox1.Controls.Add(txtDate);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(cbbGroup);
            groupBox1.Controls.Add(dat);
            groupBox1.Controls.Add(pri);
            groupBox1.Controls.Add(Q);
            groupBox1.Controls.Add(Gr);
            groupBox1.Controls.Add(ten);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(txtUnit);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(btnRegis);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnXProduct
            // 
            resources.ApplyResources(btnXProduct, "btnXProduct");
            btnXProduct.ForeColor = System.Drawing.Color.Red;
            btnXProduct.Name = "btnXProduct";
            btnXProduct.UseVisualStyleBackColor = true;
            btnXProduct.Click += btnXProduct_Click;
            // 
            // btnAccept
            // 
            resources.ApplyResources(btnAccept, "btnAccept");
            btnAccept.Name = "btnAccept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // lok
            // 
            resources.ApplyResources(lok, "lok");
            lok.Name = "lok";
            // 
            // txt_Id
            // 
            resources.ApplyResources(txt_Id, "txt_Id");
            txt_Id.Name = "txt_Id";
            // 
            // txtCate
            // 
            resources.ApplyResources(txtCate, "txtCate");
            txtCate.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCate.FormattingEnabled = true;
            txtCate.Name = "txtCate";
            // 
            // label133
            // 
            resources.ApplyResources(label133, "label133");
            label133.Name = "label133";
            // 
            // txtDate
            // 
            resources.ApplyResources(txtDate, "txtDate");
            txtDate.Name = "txtDate";
            // 
            // btnCancel
            // 
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.Name = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cbbGroup
            // 
            resources.ApplyResources(cbbGroup, "cbbGroup");
            cbbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbGroup.FormattingEnabled = true;
            cbbGroup.Name = "cbbGroup";
            // 
            // dat
            // 
            resources.ApplyResources(dat, "dat");
            dat.Name = "dat";
            // 
            // pri
            // 
            resources.ApplyResources(pri, "pri");
            pri.Name = "pri";
            // 
            // Q
            // 
            resources.ApplyResources(Q, "Q");
            Q.Name = "Q";
            // 
            // Gr
            // 
            resources.ApplyResources(Gr, "Gr");
            Gr.Name = "Gr";
            // 
            // ten
            // 
            resources.ApplyResources(ten, "ten");
            ten.Name = "ten";
            // 
            // txtUnitPrice
            // 
            resources.ApplyResources(txtUnitPrice, "txtUnitPrice");
            txtUnitPrice.Name = "txtUnitPrice";
            // 
            // txtUnit
            // 
            resources.ApplyResources(txtUnit, "txtUnit");
            txtUnit.Name = "txtUnit";
            // 
            // txtName
            // 
            resources.ApplyResources(txtName, "txtName");
            txtName.Name = "txtName";
            // 
            // btnRegis
            // 
            resources.ApplyResources(btnRegis, "btnRegis");
            btnRegis.Name = "btnRegis";
            btnRegis.UseVisualStyleBackColor = true;
            btnRegis.Click += btnRegis_Click;
            // 
            // FrmAddProduct
            // 
            AcceptButton = btnAccept;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            Controls.Add(groupBox1);
            Name = "FrmAddProduct";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label dat;
        private System.Windows.Forms.Label pri;
        private System.Windows.Forms.Label Q;
        private System.Windows.Forms.Label ten;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbbGroup;
        private System.Windows.Forms.Label Gr;
        private DateTimePicker txtDate;
        private Label label133;
        private ComboBox txtCate;
        private Button btnRegis;
        private TextBox txt_Id;
        private Label lok;
        private Button btnXProduct;
    }
}