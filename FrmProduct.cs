using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CoffeeManager
{
    public partial class FrmProduct : Form
    {
        private long _idProduct = 0;
        ProductServices _productServices = new ProductServices();

        public FrmProduct()
        {
            InitializeComponent();
            SetToolTip();

            var listproduct = _productServices.GetAll();
            dgvMain.DataSource = new BindingSource { DataSource = listproduct };
        }

        private void SetToolTip()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            //toolTip.InitialDelay = 1000;
            //toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form mana = new FrmAddProduct();
            mana.ShowDialog();
        }

        private void dgvMain_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var Product = _productServices.GetAll();
            var selectedAccount = Product[e.RowIndex];

            int id = int.Parse(selectedAccount.ProductId.ToString());
            String _Name = selectedAccount.Name.ToString();
            int _Price = int.Parse(selectedAccount.Price.ToString());
            int _Quantity = int.Parse(selectedAccount.Quantity.ToString());
            String _Brand = selectedAccount.Brand.ToString();
            DateTime _Date = selectedAccount.Date;
            String _CategoryId = selectedAccount.ProductId.ToString();

            var pro = new Product()
            {
                ProductId = id,
                Name = _Name,
                Price = _Price,
                Quantity = _Quantity,
                Brand = _Brand,
                Date = _Date,

            };

            if (pro != null)
            {
                Form mana = new FrmAddProduct(pro); // Truyền đối tượng pro vào constructor của FrmAddProduct
                mana.ShowDialog();
            }




        }

        private void btnXProduct_Click(object sender, EventArgs e)
        {

            String name = txtSearch.Text;
            var searchList = _productServices.GetAll().Where(a => a.Name.ToLower().Contains(name)).ToList();
            dgvMain.DataSource = new BindingSource { DataSource = searchList };

        }


    }
}
