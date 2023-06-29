
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnCancel = new System.Windows.Forms.Button();
            btnAccept = new System.Windows.Forms.Button();
            btnAddGroup = new System.Windows.Forms.Button();
            cbbGroup = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtDescription = new System.Windows.Forms.TextBox();
            txtUnitPrice = new System.Windows.Forms.TextBox();
            txtUnit = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.SystemColors.Control;
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnAccept);
            groupBox1.Controls.Add(btnAddGroup);
            groupBox1.Controls.Add(cbbGroup);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(txtUnit);
            groupBox1.Controls.Add(txtName);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.Name = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            resources.ApplyResources(btnAccept, "btnAccept");
            btnAccept.Name = "btnAccept";
            btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnAddGroup
            // 
            resources.ApplyResources(btnAddGroup, "btnAddGroup");
            btnAddGroup.Name = "btnAddGroup";
            btnAddGroup.UseVisualStyleBackColor = true;
            // 
            // cbbGroup
            // 
            resources.ApplyResources(cbbGroup, "cbbGroup");
            cbbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbGroup.FormattingEnabled = true;
            cbbGroup.Name = "cbbGroup";
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
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // txtDescription
            // 
            resources.ApplyResources(txtDescription, "txtDescription");
            txtDescription.Name = "txtDescription";
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
            // FrmAddProduct
            // 
            AcceptButton = btnAccept;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            Controls.Add(groupBox1);
            Name = "FrmAddProduct";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbbGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddGroup;
    }
}