using Repository.Models;
using Repository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPRN
{
    public partial class FrmAddSalary : Form
    {
        public int staffid;
        SalaryDetailServices _salaryDetailServices = new SalaryDetailServices();
        StaffServices _staffServices = new StaffServices();
        public FrmAddSalary()
        {
            InitializeComponent();
        }

        private void txtOnlShift_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var salaryDetail = new SalaryDetail();
            var staff = _staffServices.GetAll().Where(s => s.StaffId == staffid).FirstOrDefault();
            if (staff != null)
            {
                salaryDetail.StaffId = staffid;
                salaryDetail.Date = dtpEarn.Value;
                salaryDetail.OnlShift = (int)nmOnlShift.Value;
                salaryDetail.TotalSalary = staff.Salary * (int)nmOnlShift.Value * 4;
            }

            if (salaryDetail.OnlShift == null)
            {
                MessageBox.Show("OnlShift must be not null", "Thong bao", MessageBoxButtons.OK);
            }


            else
            {
                _salaryDetailServices.Create(salaryDetail);
                MessageBox.Show("Successful", "Thong bao", MessageBoxButtons.OK);
                DialogResult = DialogResult.OK;

            }

        }

        private void FrmAddSalary_Load(object sender, EventArgs e)
        {
            var SalaryDetails = _salaryDetailServices.GetAll().Where(p => p.StaffId == staffid).FirstOrDefault();

            SalaryDetails.StaffId.ToString();
        }

        private void nmOnlShift_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpEarn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
