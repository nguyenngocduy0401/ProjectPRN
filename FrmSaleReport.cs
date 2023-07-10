using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Data;
using System.ComponentModel;
using Repository.Service;
using Repository.Models;
using System.Reflection.Metadata.Ecma335;
using System.Linq;
using System.Runtime.Serialization;

namespace CoffeeManager
{
    public partial class FrmSaleReport : Form
    {
        private DateTime _dateFrom = DateTime.Now;
        //private DateTime _dateTo = DateTime.Now.AddDays(1);
        private DateTime _dateTo = DateTime.Now;
        private double _totalMoney = 0;
        private int _modeSearch = 0;
        private string _plusTime = "";
        private DataTable _dataForReport = new DataTable();
        private string _infoStore = "";
        private OrderServices _orderServices = new OrderServices();
        private OrderDetailsServices _orderDetailsServices = new OrderDetailsServices();
        private ProductServices _productServices = new ProductServices();
        public FrmSaleReport()
        {
            InitializeComponent();
            List<Order> ordersList = new List<Order>();
            ordersList = getOrderByDay(DateTime.Now);
            if (ordersList.Count == 0)
            {
                MessageBox.Show("Khong co order", "Notification", MessageBoxButtons.OK);
            }
            else
            {
                foreach (Order order in ordersList)
                {
                    String[] row = new string[]
                    {
                    order.OrderId.ToString(),
                    order.Date.ToShortDateString(),
                    };
                    dgvOrder.Rows.Add(row);

                }
            }

        }

        public List<Order> getOrderByDay(DateTime date)
        {
            List<Order> orders = new List<Order>();
            orders = _orderServices.GetAll().Where(p => p.Date.Equals(date.Date)).ToList();
            return orders;
        }

        private void dgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDetails.Rows.Clear();
            var orderID = dgvOrder.Rows[e.RowIndex].Cells["orderID"].Value;

            int id = int.Parse((string)orderID);
            int total = 0;
            List<OrderDetail> ordersDetail = new List<OrderDetail>();
            ordersDetail = _orderDetailsServices.GetAll().Where(p => id.Equals(p.OrderId)).ToList();
            if (ordersDetail.Count == 0)
            {
                MessageBox.Show("Somethings went wrong!", orderID.ToString(), MessageBoxButtons.OK);
            }
            else
            {
                foreach (OrderDetail detail in ordersDetail)
                {
                    var product = _productServices.GetAll().Where(x => x.ProductId.Equals(detail.ProductId)).FirstOrDefault();
                    if (product != null)
                    {
                        string[] productRow = new string[]{
                        product.ProductId.ToString(),
                        product.Name.ToString(),
                        detail.Price.ToString(),
                        detail.Quantity.ToString()
                        };
                        dgvDetails.Rows.Add(productRow);
                        total = total + detail.Quantity * detail.Price;

                    }
                    txtTotal.Text = total.ToString();

                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvOrder.Rows.Clear();
            int year = int.Parse(dtpYear.Text);
            int month = int.Parse(dtpMonth.Text);
            int day = int.Parse(dtpDay.Text);
            DateTime date = new DateTime(year, month, day);
            List<Order> orders = new List<Order>();
            orders = getOrderByDay(date);
            foreach (Order order in orders)
            {
                String[] row = new string[]
                   {
                    order.OrderId.ToString(),
                    order.Date.ToShortDateString(),
                   };
                dgvOrder.Rows.Add(row);
            }
        }
    }
}
