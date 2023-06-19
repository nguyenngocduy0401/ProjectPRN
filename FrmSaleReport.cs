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
        public FrmSaleReport()
        {
            InitializeComponent();
        }
    }
}
