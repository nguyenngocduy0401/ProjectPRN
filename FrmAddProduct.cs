using System;
using System.Data;
using System.Drawing;
using System.IO;
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

        public FrmAddProduct()
        {
            InitializeComponent();
        }
    }
}
