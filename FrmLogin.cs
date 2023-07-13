using CoffeeManager;
using Repository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPRN
{
    public partial class FrmLogin : Form
    {   
        UserServices _userServices = new UserServices();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            var user = _userServices.GetAll().Where(p => p.Username.Equals(Username) && p.Password.Equals(Password)).FirstOrDefault();
            if (user.Role == 1) { 
                FrmManagerAdmin frmManagerAdmin = new FrmManagerAdmin();
                frmManagerAdmin.ShowDialog();
            }
            else if (user.Role == 2)
            {
                FrmMain frmMain = new FrmMain();
                frmMain.ShowDialog();
            }
        }
    }
}
