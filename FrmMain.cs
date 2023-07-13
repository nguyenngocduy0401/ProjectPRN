using Microsoft.Identity.Client;
using Microsoft.VisualBasic.ApplicationServices;
using Repository.Models;
using Repository.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CoffeeManager
{
    public partial class FrmMain : Form
    {
        private string _nameTable = "";
        private string _nameProduct = "";
        private static string _userFullName = "";
        private static string _userName = "";
        private const string _defaultSettings = "14;70;80";
        private const string _defaultSettingsTb = "16;50;80";

        private double _unitPrice = 0;
        private long _idBill = 0;
        private long _idCustomer = 0;
        private long _idEmployees = 0;
        private long _idTable = 0;
        private long _idProduct = 0;
        private long _idLogin = 0;
        private int _buttonProdutHeight = 70;
        private int _buttonProdutWidth = 120;
        private int _fontSizePr = 14;
        private CoffeeManagerContext _context = new CoffeeManagerContext();
        private ProductServices _productServices = new ProductServices();
        private List<Product> listProductsOnOrder = new List<Product>();
        private OrderServices _orderServices = new OrderServices();
        private CategoryServices _categoryServices = new CategoryServices();
        private OrderDetailServices _orderDetailsServices = new OrderDetailServices();

        public FrmMain()
        {
            InitializeComponent();
            LoadProduct();
            LoadCategory();
        }

        private string LoadCategory()
        {
            string message = "";
            try
            {
                List<Category> listsCate = new List<Category>();
                listsCate = _categoryServices.GetAll().ToList();

                var listCate = _categoryServices.GetAll().Select(p => new { Value = p.CategoryId, Text = p.CategoryName }).ToList();
                var cateAll = new {
                    Value = 0,
                    Text = "All"
                };
                listCate.Insert(0,cateAll);
                cbbMenu.ValueMember = ("Value");
                cbbMenu.DisplayMember = ("Text");
                cbbMenu.DataSource = listCate;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                goto TheEnd;
            }

        TheEnd:
            return message;
        }

        private string LoadProduct()
        {
            string message = "chay";
            try
            {
                List<Product> listProducts = new List<Product>();
                listProducts = _productServices.GetAll().ToList();
                flpRight.Controls.Clear();

                foreach (Product row in listProducts)
                {
                    Button bt = new Button
                    {
                        Text = row.Name.ToString(),
                        Name = row.ProductId.ToString(),
                        Tag = row.Price.ToString(),
                        ImageAlign = ContentAlignment.TopCenter,
                        Height = _buttonProdutHeight,
                        Width = _buttonProdutWidth,
                        BackColor = Color.White,
                        TextAlign = ContentAlignment.BottomCenter,
                        Font = new Font("Arial", _fontSizePr, FontStyle.Regular)
                    };
                    flpRight.Controls.Add(bt);
                    bt.Click += btn_Product;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                goto TheEnd;
            }
        TheEnd:
            return message;
        }

        private string LoadProductByID(int id)
        {
            string message = "chay";
            try
            {
                List<Product> listProducts = new List<Product>();
                listProducts = _productServices.GetAll().Where(p => p.CategoryId == id).ToList();
                flpRight.Controls.Clear();

                foreach (Product row in listProducts)
                {
                    Button bt = new Button
                    {
                        Text = row.Name.ToString(),
                        Name = row.ProductId.ToString(),
                        Tag = row.Price.ToString(),
                        ImageAlign = ContentAlignment.TopCenter,
                        Height = _buttonProdutHeight,
                        Width = _buttonProdutWidth,
                        BackColor = Color.White,
                        TextAlign = ContentAlignment.BottomCenter,
                        Font = new Font("Arial", _fontSizePr, FontStyle.Regular)
                    };
                    flpRight.Controls.Add(bt);
                    bt.Click += btn_Product;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                goto TheEnd;
            }
        TheEnd:
            return message;
        }

            public void btn_Product(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            var _productId = int.Parse(btn.Name);
            _nameProduct = btn.Text;
            var product = _productServices.GetAll().Where(p => p.ProductId.Equals(_productId)).FirstOrDefault();
            if (product != null)
            {
                if (!listProductsOnOrder.Contains(product))
                {
                    product.Quantity = 1;
                    listProductsOnOrder.Add(product);
                }
                else
                {
                    product.Quantity++;
                }
                dgvMain.Rows.Clear();
                int total = 0;
                foreach (var item in listProductsOnOrder)
                {
                    String[] row = new String[] { item.Name, item.Price.ToString(), item.Quantity.ToString(), item.Brand.ToString(), "" };
                    dgvMain.Rows.Add(row);
                    total = total + item.Price * item.Quantity;
                }
                txtTotalMoney.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Womething went wrong!", "Notification", MessageBoxButtons.OK);
            }

            dgvMain.ClearSelection();

        }

        private void txtMoneyPay_TextChanged(object sender, EventArgs e)
        {
            int excess;
            int moneyPay;
            if (string.IsNullOrEmpty(txtMoneyPay.Text))
            {
                moneyPay = 0;
            }
            else
            {
                moneyPay = int.Parse(txtMoneyPay.Text);
            }
            int total = int.Parse(txtTotalMoney.Text);
            excess = moneyPay - total;
            if (excess > 0)
            {
                txtMoneyReturn.Text = excess.ToString();
            }
        }

        private void txtTotalMoney_TextChanged(object sender, EventArgs e)
        {
            int excess;
            int moneyPay;
            if (string.IsNullOrEmpty(txtMoneyPay.Text))
            {
                moneyPay = 0;
            }
            else
            {
                moneyPay = int.Parse(txtMoneyPay.Text);
            }
            int total = int.Parse(txtTotalMoney.Text);
            excess = moneyPay - total;
            if (excess > 0)
            {
                txtMoneyReturn.Text = excess.ToString();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            var date = DateTime.Now;
            Order order = new Order();
            order.Date = date;
            _orderServices.Create(order);
            List<Order> listOrders = new List<Order>();
            listOrders = _orderServices.GetAll().ToList();
            int count = listOrders.Count;
            int orderId = listOrders[listOrders.Count - 1].OrderId;

            foreach (var item in listProductsOnOrder)
            {
                OrderDetail orderDetail = new OrderDetail()
                {
                    OrderId = orderId,
                    Quantity = item.Quantity,
                    Price = item.Price,
                    ProductId = item.ProductId
                };
                _orderDetailsServices.Create(orderDetail);
            }
            MessageBox.Show("Paying Successfully!", "Notification", MessageBoxButtons.OK);
            listProductsOnOrder.Clear();
            dgvMain.Rows.Clear();
            txtTotalMoney.Text = "0";
            txtMoneyReturn.Text = "0";
            txtMoneyPay.Text = "0";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FrmSaleReport form = new FrmSaleReport();
            this.Hide();
            form.ShowDialog();
            this.Close();

        }

        private void cbbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cateID = cbbMenu.SelectedValue.ToString();
            int id;
            if (string.IsNullOrEmpty(cateID))
            {
                id = 0;
            }
            else
            {
                id = int.Parse(cateID);
            }
            if (id == 0) {
                LoadProduct();
            } else
            {
                LoadProductByID(id);
            }
        }
    }
}
