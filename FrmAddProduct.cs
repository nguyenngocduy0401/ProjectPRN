using Repository.Models;
using Repository.Services;
using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CoffeeManager
{
    public partial class FrmAddProduct : Form
    {

        private int _imgHeight = 0;
        private int _imgWidth = 0;
        private long _idProduct = 0;
        private long _idGroup = 0;
        private string _name = "";
        private string _unit = "";
        private double _unitPrice = 0;
        private string _description = "";
        private byte[] _img = null;

        ProductServices _productServices = new ProductServices();
        CategoryServices _categoryServices = new CategoryServices();
        public FrmAddProduct()
        {
            InitializeComponent();

            var BN = _productServices.GetAll().Select(p => (p.Brand));
            cbbGroup.Items.AddRange(BN.ToArray());
            var Ct = _categoryServices.GetAll().Select(p => (p.CategoryName)); ;
            txtCate.Items.AddRange(Ct.Cast<object>().ToArray());
            //DGVlist.DataSource = new BindingSource { DataSource = listproduct };
            txtDate.Enabled = false;
            txt_Id.Enabled = false;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String BranchName = cbbGroup.Text;
            int Prices = 0, Unit = 0, cate = 0;

            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter the product name.");
                return;
            }

            if (String.IsNullOrEmpty(BranchName))
            {
                MessageBox.Show("Please select a brand name.");
                return;
            }

            if (!int.TryParse(txtUnitPrice.Text, out Prices) || Prices <= 0)
            {
                MessageBox.Show("Please enter a valid unit price.");
                return;
            }

            if (!int.TryParse(txtUnit.Text, out Unit) || Unit <= 0)
            {
                MessageBox.Show("Please enter a valid unit quantity.");
                return;
            }
            //food=1,drink=2 , cate = 1 or 2
            cate = (txtCate.Text == "Food") ? 1 : 2;
            var pro = new Product
            {
                Name = name,
                Date = DateTime.Now.Date,
                Brand = BranchName,
                Price = Prices,
                Quantity = Unit,
                CategoryId = cate
            };

            _productServices.Create(pro);
            DialogResult result = MessageBox.Show("Product created successfully. Do you want to view its details?", "Success", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Show the product details form with the newly created product
                FrmProduct frm = new FrmProduct();
                frm.ShowDialog();
            }

            // Clear the input fields for creating another product
            txtName.Text = "";
            cbbGroup.Text = "";
            txtUnitPrice.Text = "";
            txtUnit.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtDate.Text = "";
            cbbGroup.Text = "";
            txtUnit.Text = "";
            txtUnitPrice.Text = "";
        }

        public FrmAddProduct(Product product) : this()
        {
            // Sử dụng đối tượng product để khởi tạo các giá trị trong form

            txt_Id.Text = product.ProductId.ToString();
            txtName.Text = product.Name;
            cbbGroup.Text = product.Brand;
            txtUnitPrice.Text = product.Price.ToString();
            txtUnit.Text = product.Quantity.ToString();
            txtDate.Text = product.Date.ToShortTimeString();
            //   txtCate = pro

            btnAccept.Visible = false;
            txtDate.Enabled = true;
            txt_Id.Enabled = false;

        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txt_Id.Text);

                String name = txtName.Text;
                DateTime Date = DateTime.ParseExact(txtDate.Text, "dddd, MMMM d, yyyy", CultureInfo.InvariantCulture);
                String BranchName = cbbGroup.Text;
                int Prices = int.Parse(txtUnitPrice.Text);
                int Unit = int.Parse(txtUnit.Text);
                int cate = (txtCate.Text == "Food") ? 1 : 2;

                var p = _productServices.GetAll().FirstOrDefault(p => p.ProductId.Equals(id));
                if (p != null)
                {
                    p.Name = name;
                    p.Date = Date;
                    p.Brand = BranchName;
                    p.Price = Prices;
                    p.Quantity = Unit;
                    p.CategoryId = cate;

                    _productServices.Update(p);
                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No record found with given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXProduct_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_Id.Text);
            var p = _productServices.GetAll().FirstOrDefault(p => p.ProductId.Equals(id));
            if (p != null)
            {
                _productServices.Delete(p);
                MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmProduct frm = new FrmProduct();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No record found with given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }


}

