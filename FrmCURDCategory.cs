using Repository.Models;
using Repository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectPRN
{
    public partial class FrmCURDCategory : Form
    {
        private CoffeeManagerContext _context = new CoffeeManagerContext();
        private CategoryServices _categoryservices = new CategoryServices();
        List<Category> listProductsOnOrder = new List<Category>();
        public FrmCURDCategory()
        {
            InitializeComponent();
            var listCatetory = _context.Categories.ToList();
            dgvListCatetory.DataSource = new BindingSource { DataSource = listCatetory };
            txtMaHang.Visible = false;
            blMaHang.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtTenHang.Text = "";
            txtMaHang.Text = "";
            btnAccept.Visible = true;
            txtMaHang.Visible = false;
            blMaHang.Visible = false;
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int CategoryID = int.Parse(txtMaHang.Text);
                String catetoryName = txtTenHang.Text;
                var Category = _categoryservices.GetAll().Where(p => p.CategoryId.Equals(CategoryID)).FirstOrDefault();

                bool flag = false;
                if (string.IsNullOrEmpty(catetoryName))
                {
                    MessageBox.Show("Please enter catetory name", "Notification", MessageBoxButtons.OK);
                    flag = true;
                }

                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                String pattern = @"\s+";
                catetoryName = Regex.Replace(catetoryName, pattern, " ");
                catetoryName = Regex.Replace(catetoryName, pattern, " ");
                catetoryName = textInfo.ToTitleCase(catetoryName);
                catetoryName = textInfo.ToTitleCase(catetoryName);



                if (Category != null && !flag)
                {
                    Category.CategoryName = catetoryName; Category.CategoryId = CategoryID;
                    _categoryservices.Update(Category);
                }
                else
                {
                    MessageBox.Show("No record match!!", "Notification", MessageBoxButtons.OK);
                }
                dgvListCatetory.Refresh();
                txtTenHang.Text = "";
                dgvListCatetory.DataSource = new BindingSource() { DataSource = _categoryservices.GetAll() };

            }
            catch (Exception)
            {
                MessageBox.Show("Choose the line you want to update", "Notification", MessageBoxButtons.OK);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                String catetoryName = txtTenHang.Text;
                bool flag = false;
                if (string.IsNullOrEmpty(catetoryName))
                {
                    MessageBox.Show("Please enter catetory name", "Notification", MessageBoxButtons.OK);
                    flag = true;
                }

                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                String pattern = @"\s+";
                catetoryName = Regex.Replace(catetoryName, pattern, " ");
                catetoryName = Regex.Replace(catetoryName, pattern, " ");
                catetoryName = textInfo.ToTitleCase(catetoryName);
                catetoryName = textInfo.ToTitleCase(catetoryName);



                if (!flag)
                {
                    var catetory = new Category
                    {
                        CategoryName = catetoryName,


                    };
                    _categoryservices.Create(catetory);
                    dgvListCatetory.DataSource = new BindingSource() { DataSource = _categoryservices.GetAll() };


                    txtTenHang.Text = "";


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter the information", "Notification", MessageBoxButtons.OK);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int CategoryID = int.Parse(txtMaHang.Text);
                var Category = _categoryservices.GetAll().Where(p => p.CategoryId.Equals(CategoryID)).FirstOrDefault();

                if (Category != null)
                {
                    DialogResult result = MessageBox.Show("Delete this category?", "Notification", MessageBoxButtons.OKCancel);

                    switch (result)
                    {
                        case DialogResult.None:
                            break;
                        case DialogResult.OK:
                            _categoryservices.Delete(Category);
                            dgvListCatetory.DataSource = new BindingSource() { DataSource = _categoryservices.GetAll() };
                            dgvListCatetory.ClearSelection(); // Bỏ chọn dòng hiện tại trên dgvListCatetory
                            break;
                        case DialogResult.Cancel:
                            break;
                        case DialogResult.Abort:
                            break;
                        case DialogResult.Retry:
                            break;
                        case DialogResult.Ignore:
                            break;
                        case DialogResult.Yes:
                            break;
                        case DialogResult.No:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("No record match!", "Notification", MessageBoxButtons.OK);
                }

                dgvListCatetory.Refresh();

                txtTenHang.Text = "";
                txtMaHang.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Choose the line you want to delete", "Notification", MessageBoxButtons.OK);
            }
        }



        private void dgvListCatetory_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvListCatetory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAccept.Visible = false;
            var CatetoryID = dgvListCatetory.Rows[e.RowIndex].Cells[0].Value;
            var Category = _categoryservices.GetAll().Where(p => p.CategoryId.Equals(CatetoryID)).FirstOrDefault();
            if (Category != null)
            {
                txtTenHang.Text = Category.CategoryName.ToString();
                txtMaHang.Text = Category.CategoryId.ToString();
                blMaHang.Visible = true;
                txtMaHang.Visible = true;
            }
        }



        private void Detail_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
