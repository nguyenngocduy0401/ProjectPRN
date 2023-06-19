using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CoffeeManager
{
    public partial class FrmProduct : Form
    {
        private long _idProduct = 0;

        public FrmProduct()
        {
            InitializeComponent();
            SetToolTip();
        }

        private void SetToolTip()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            //toolTip.InitialDelay = 1000;
            //toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
        }

        
    }
}
