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
    public partial class FrmUpdateSalary : Form
    {
        private SalaryDetail getSalaryDetail;
        SalaryDetailServices _salaryDetailServices = new SalaryDetailServices();
        StaffServices _staffServices = new StaffServices();
        public SalaryDetail GetSalaryDetail { get => getSalaryDetail; set => getSalaryDetail = value; }

        public FrmUpdateSalary()
        {
            InitializeComponent();
        }

        private void FrmUpdateSalary_Load(object sender, EventArgs e)
        {
            nmOnlShift.Value = getSalaryDetail.OnlShift;
            dtpEarn.Value = (DateTime)getSalaryDetail.Date;
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {   
            int staffID = getSalaryDetail.StaffId;
            var staff = _staffServices.GetAll().Where(s => s.StaffId == staffID).FirstOrDefault();
            var SalaryDetail = new SalaryDetail();
            SalaryDetail.StaffId = getSalaryDetail.StaffId;
            SalaryDetail.SalaryDetailsId = getSalaryDetail.SalaryDetailsId;
            SalaryDetail.OnlShift = (int)nmOnlShift.Value;
            SalaryDetail.TotalSalary = (int)nmOnlShift.Value * staff.Salary * 4;
            SalaryDetail.Date = dtpEarn.Value;

            _salaryDetailServices.Update(SalaryDetail);
            MessageBox.Show("Successful", "Thong bao", MessageBoxButtons.OK);
            DialogResult = DialogResult.OK;
            this.Hide();
            FrmSalary frmSalary = new FrmSalary()
            {
                GetStaff = _staffServices.GetAll().Where(p => p.StaffId == staffID).FirstOrDefault() 
                
            };
            
            frmSalary.ShowDialog();
        }
    }
}
