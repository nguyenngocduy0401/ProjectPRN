
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
            GrbDateTime = new System.Windows.Forms.GroupBox();
            btnSearch = new System.Windows.Forms.Button();
            year = new System.Windows.Forms.Label();
            month = new System.Windows.Forms.Label();
            day = new System.Windows.Forms.Label();
            lbViewBy = new System.Windows.Forms.Label();
            dtpDay = new System.Windows.Forms.DateTimePicker();
            dtpMonth = new System.Windows.Forms.DateTimePicker();
            dtpYear = new System.Windows.Forms.DateTimePicker();
            panel1 = new System.Windows.Forms.Panel();
            dgvOrder = new System.Windows.Forms.DataGridView();
            orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgvDetails = new System.Windows.Forms.DataGridView();
            productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ldDetails = new System.Windows.Forms.Label();
            lbTotal = new System.Windows.Forms.Label();
            txtTotal = new System.Windows.Forms.TextBox();
            GrbDateTime.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).BeginInit();
            SuspendLayout();
            // 
            // GrbDateTime
            // 
            GrbDateTime.Controls.Add(btnSearch);
            GrbDateTime.Controls.Add(year);
            GrbDateTime.Controls.Add(month);
            GrbDateTime.Controls.Add(day);
            GrbDateTime.Controls.Add(lbViewBy);
            GrbDateTime.Controls.Add(dtpDay);
            GrbDateTime.Controls.Add(dtpMonth);
            GrbDateTime.Controls.Add(dtpYear);
            resources.ApplyResources(GrbDateTime, "GrbDateTime");
            GrbDateTime.Name = "GrbDateTime";
            GrbDateTime.TabStop = false;
            // 
            // btnSearch
            // 
            resources.ApplyResources(btnSearch, "btnSearch");
            btnSearch.Name = "btnSearch";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // year
            // 
            resources.ApplyResources(year, "year");
            year.Name = "year";
            // 
            // month
            // 
            resources.ApplyResources(month, "month");
            month.Name = "month";
            // 
            // day
            // 
            resources.ApplyResources(day, "day");
            day.Name = "day";
            // 
            // lbViewBy
            // 
            resources.ApplyResources(lbViewBy, "lbViewBy");
            lbViewBy.Name = "lbViewBy";
            // 
            // dtpDay
            // 
            resources.ApplyResources(dtpDay, "dtpDay");
            dtpDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpDay.Name = "dtpDay";
            dtpDay.ShowUpDown = true;
            // 
            // dtpMonth
            // 
            resources.ApplyResources(dtpMonth, "dtpMonth");
            dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpMonth.Name = "dtpMonth";
            dtpMonth.ShowUpDown = true;
            // 
            // dtpYear
            // 
            resources.ApplyResources(dtpYear, "dtpYear");
            dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpYear.Name = "dtpYear";
            dtpYear.ShowUpDown = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(GrbDateTime);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { orderID, date });
            resources.ApplyResources(dgvOrder, "dgvOrder");
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowTemplate.Height = 25;
            dgvOrder.CellDoubleClick += dgvOrder_CellDoubleClick;
            // 
            // orderID
            // 
            resources.ApplyResources(orderID, "orderID");
            orderID.Name = "orderID";
            orderID.ReadOnly = true;
            // 
            // date
            // 
            resources.ApplyResources(date, "date");
            date.Name = "date";
            date.ReadOnly = true;
            // 
            // dgvDetails
            // 
            dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { productId, name, price, quantity });
            resources.ApplyResources(dgvDetails, "dgvDetails");
            dgvDetails.Name = "dgvDetails";
            dgvDetails.ReadOnly = true;
            dgvDetails.RowTemplate.Height = 25;
            // 
            // productId
            // 
            resources.ApplyResources(productId, "productId");
            productId.Name = "productId";
            productId.ReadOnly = true;
            // 
            // name
            // 
            resources.ApplyResources(name, "name");
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // price
            // 
            resources.ApplyResources(price, "price");
            price.Name = "price";
            price.ReadOnly = true;
            // 
            // quantity
            // 
            resources.ApplyResources(quantity, "quantity");
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            // 
            // ldDetails
            // 
            resources.ApplyResources(ldDetails, "ldDetails");
            ldDetails.Name = "ldDetails";
            // 
            // lbTotal
            // 
            resources.ApplyResources(lbTotal, "lbTotal");
            lbTotal.Name = "lbTotal";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(txtTotal, "txtTotal");
            txtTotal.Name = "txtTotal";
            // 
            // FrmSaleReport
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(txtTotal);
            Controls.Add(lbTotal);
            Controls.Add(ldDetails);
            Controls.Add(dgvDetails);
            Controls.Add(dgvOrder);
            Controls.Add(panel1);
            Name = "FrmSaleReport";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            GrbDateTime.ResumeLayout(false);
            GrbDateTime.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.GroupBox GrbDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDay;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.DateTimePicker dtpYear;
        private System.Windows.Forms.Label lblShowErr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.Label ldDetails;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.Label day;
        private System.Windows.Forms.Label lbViewBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Button btnSearch;
    }
}