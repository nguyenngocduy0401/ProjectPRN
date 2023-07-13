using CoffeeManager;
using ProjectPRN211;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPRN
{
    public partial class FrmManagerAdmin : Form
    {
        public FrmManagerAdmin()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmProduct frmProduct = new FrmProduct();
            frmProduct.ShowDialog();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            FrmCURDCategory frmCURDCategory = new FrmCURDCategory();
            frmCURDCategory.ShowDialog();
        }

        private void Staff_Click(object sender, EventArgs e)
        {
            FrmManageStaff frmManageStaff = new FrmManageStaff();
            frmManageStaff.ShowDialog();
        }

        private void SaleReport_Click(object sender, EventArgs e)
        {
            FrmSaleReport frmSaleReport = new FrmSaleReport();
            frmSaleReport.ShowDialog();
        }
    }
}
