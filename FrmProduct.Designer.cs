
namespace CoffeeManager
{
    partial class FrmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduct));
            panel1 = new System.Windows.Forms.Panel();
            groupBox2 = new System.Windows.Forms.GroupBox();
            dgvMain = new System.Windows.Forms.DataGridView();
            id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idGroupProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txt_ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txt_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txt_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txt_Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txt_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txt_CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel3 = new System.Windows.Forms.Panel();
            create = new System.Windows.Forms.Button();
            btnAddPr = new System.Windows.Forms.Button();
            panel5 = new System.Windows.Forms.Panel();
            btnXProduct = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            grbGroup = new System.Windows.Forms.GroupBox();
            dgvGroup = new System.Windows.Forms.DataGridView();
            idGr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameGr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descriptionGr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel2 = new System.Windows.Forms.Panel();
            btnAddGroup = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            btnX = new System.Windows.Forms.Button();
            txtSearchGroup = new System.Windows.Forms.TextBox();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            grbGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGroup).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(grbGroup);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvMain);
            groupBox2.Controls.Add(panel3);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.ForeColor = System.Drawing.Color.Blue;
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // dgvMain
            // 
            dgvMain.AllowUserToAddRows = false;
            dgvMain.BackgroundColor = System.Drawing.Color.White;
            dgvMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { id, idGroupProduct, txt_ProductId, txt_name, txt_Price, Quantity, txt_Brand, txt_Date, txt_CategoryId });
            resources.ApplyResources(dgvMain, "dgvMain");
            dgvMain.Name = "dgvMain";
            dgvMain.ReadOnly = true;
            dgvMain.RowHeadersVisible = false;
            dgvMain.RowTemplate.Height = 40;
            dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            dgvMain.CellContentDoubleClick += dgvMain_CellContentDoubleClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            resources.ApplyResources(id, "id");
            id.Name = "id";
            id.ReadOnly = true;
            id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // idGroupProduct
            // 
            resources.ApplyResources(idGroupProduct, "idGroupProduct");
            idGroupProduct.Name = "idGroupProduct";
            idGroupProduct.ReadOnly = true;
            idGroupProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txt_ProductId
            // 
            txt_ProductId.DataPropertyName = "ProductId";
            resources.ApplyResources(txt_ProductId, "txt_ProductId");
            txt_ProductId.Name = "txt_ProductId";
            txt_ProductId.ReadOnly = true;
            txt_ProductId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txt_name
            // 
            txt_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            txt_name.DataPropertyName = "Name";
            resources.ApplyResources(txt_name, "txt_name");
            txt_name.Name = "txt_name";
            txt_name.ReadOnly = true;
            txt_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txt_Price
            // 
            txt_Price.DataPropertyName = "Price";
            resources.ApplyResources(txt_Price, "txt_Price");
            txt_Price.Name = "txt_Price";
            txt_Price.ReadOnly = true;
            txt_Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            resources.ApplyResources(Quantity, "Quantity");
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txt_Brand
            // 
            txt_Brand.DataPropertyName = "Brand";
            resources.ApplyResources(txt_Brand, "txt_Brand");
            txt_Brand.Name = "txt_Brand";
            txt_Brand.ReadOnly = true;
            txt_Brand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txt_Date
            // 
            txt_Date.DataPropertyName = "Date";
            resources.ApplyResources(txt_Date, "txt_Date");
            txt_Date.Name = "txt_Date";
            txt_Date.ReadOnly = true;
            txt_Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txt_CategoryId
            // 
            txt_CategoryId.DataPropertyName = "CategoryId";
            resources.ApplyResources(txt_CategoryId, "txt_CategoryId");
            txt_CategoryId.Name = "txt_CategoryId";
            txt_CategoryId.ReadOnly = true;
            txt_CategoryId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel3.Controls.Add(create);
            panel3.Controls.Add(btnAddPr);
            panel3.Controls.Add(panel5);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // create
            // 
            resources.ApplyResources(create, "create");
            create.Name = "create";
            create.UseVisualStyleBackColor = true;
            create.Click += button1_Click;
            // 
            // btnAddPr
            // 
            resources.ApplyResources(btnAddPr, "btnAddPr");
            btnAddPr.Name = "btnAddPr";
            btnAddPr.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            panel5.Controls.Add(btnXProduct);
            panel5.Controls.Add(txtSearch);
            resources.ApplyResources(panel5, "panel5");
            panel5.Name = "panel5";
            // 
            // btnXProduct
            // 
            resources.ApplyResources(btnXProduct, "btnXProduct");
            btnXProduct.ForeColor = System.Drawing.Color.Red;
            btnXProduct.Name = "btnXProduct";
            btnXProduct.UseVisualStyleBackColor = true;
            btnXProduct.Click += btnXProduct_Click;
            // 
            // txtSearch
            // 
            resources.ApplyResources(txtSearch, "txtSearch");
            txtSearch.Name = "txtSearch";
            // 
            // grbGroup
            // 
            grbGroup.Controls.Add(dgvGroup);
            grbGroup.Controls.Add(panel2);
            resources.ApplyResources(grbGroup, "grbGroup");
            grbGroup.ForeColor = System.Drawing.Color.Blue;
            grbGroup.Name = "grbGroup";
            grbGroup.TabStop = false;
            // 
            // dgvGroup
            // 
            dgvGroup.AllowUserToAddRows = false;
            dgvGroup.BackgroundColor = System.Drawing.Color.White;
            dgvGroup.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dgvGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idGr, nameGr, descriptionGr });
            resources.ApplyResources(dgvGroup, "dgvGroup");
            dgvGroup.Name = "dgvGroup";
            dgvGroup.ReadOnly = true;
            dgvGroup.RowHeadersVisible = false;
            dgvGroup.RowTemplate.Height = 40;
            dgvGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // idGr
            // 
            idGr.DataPropertyName = "idGr";
            resources.ApplyResources(idGr, "idGr");
            idGr.Name = "idGr";
            idGr.ReadOnly = true;
            // 
            // nameGr
            // 
            nameGr.DataPropertyName = "nameGr";
            resources.ApplyResources(nameGr, "nameGr");
            nameGr.Name = "nameGr";
            nameGr.ReadOnly = true;
            // 
            // descriptionGr
            // 
            descriptionGr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            descriptionGr.DataPropertyName = "descriptionGr";
            resources.ApplyResources(descriptionGr, "descriptionGr");
            descriptionGr.Name = "descriptionGr";
            descriptionGr.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel2.Controls.Add(btnAddGroup);
            panel2.Controls.Add(panel4);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // btnAddGroup
            // 
            resources.ApplyResources(btnAddGroup, "btnAddGroup");
            btnAddGroup.Name = "btnAddGroup";
            btnAddGroup.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            panel4.Controls.Add(btnX);
            panel4.Controls.Add(txtSearchGroup);
            resources.ApplyResources(panel4, "panel4");
            panel4.Name = "panel4";
            // 
            // btnX
            // 
            resources.ApplyResources(btnX, "btnX");
            btnX.ForeColor = System.Drawing.Color.Red;
            btnX.Name = "btnX";
            btnX.UseVisualStyleBackColor = true;
            // 
            // txtSearchGroup
            // 
            resources.ApplyResources(txtSearchGroup, "txtSearchGroup");
            txtSearchGroup.Name = "txtSearchGroup";
            // 
            // FrmProduct
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "FrmProduct";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            grbGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGroup).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grbGroup;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvGroup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSearchGroup;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnXProduct;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnAddPr;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGr;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGr;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionGr;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGroupProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_CategoryId;
    }
}