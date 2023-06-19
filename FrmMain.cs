using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CoffeeManager
{
    public partial class FrmMain : Form
    {
        private DataTable _dt = null;

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
        // Hình thức mua tại chỗ hay đem về
        private int _modeInplaceOrBring = 0;
        private int _buttonProdutHeight = 70;
        private int _buttonProdutWidth = 80;
        private int _buttonTableHeight = 50;
        private int _buttonTableWidth = 80;
        private int _fontSizePr = 14;
        private int _fontSizeTb = 16;
        private int _modeGetTable = 1;

        private bool _isLogOut = false;
        private bool _loadComplete = false;
        private bool _isSave = true;
        private bool _needLoad = true;
        private bool _isRestart = false;

        public FrmMain()
        {

            InitializeComponent();
        }



    }
}
