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
    public partial class FrmSalary : Form
    {
        private Staff getStaff;
        SalaryDetailServices _salaryDetailServices = new SalaryDetailServices();
        StaffServices _staffServices = new StaffServices();
        CoffeeManagerContext _context = new CoffeeManagerContext();
        public Staff GetStaff { get => getStaff; set => getStaff = value; }
        public FrmSalary()
        {
            InitializeComponent();

        }



        private void FrmSalary_Load(object sender, EventArgs e)
        {
            if (getStaff != null)
            {
                var listSalary = _salaryDetailServices.GetAll().Where(p => p.StaffId == int.Parse(getStaff.StaffId.ToString()));
                dgvListSalary.DataSource = new BindingSource { DataSource = listSalary };
            }

        }

        private void dgvListSalary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var SalaryDetailsID = dgvListSalary.Rows[e.RowIndex].Cells[0].Value;
                var SalaryDetails = _salaryDetailServices.GetAll().Where(p => p.SalaryDetailsId.Equals(SalaryDetailsID)).FirstOrDefault();


                txtSalaryDetailsID.Text = SalaryDetails.SalaryDetailsId.ToString();
                txtStaffID.Text = SalaryDetails.StaffId.ToString();
                txtOnlShift.Text = SalaryDetails.OnlShift.ToString();
                dtpDateEarn.Value = (DateTime)SalaryDetails.Date;
                txtTotalSalary.Text = SalaryDetails.TotalSalary.ToString();

            }
            catch (Exception)
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddSalary frmAddSalary = new FrmAddSalary
            {
                staffid = getStaff.StaffId,
            };
            if (frmAddSalary.ShowDialog() == DialogResult.OK)
            {
                frmAddSalary.Hide();

                var listSalary = _salaryDetailServices.GetAll().Where(p => p.StaffId == int.Parse(getStaff.StaffId.ToString()));
                dgvListSalary.DataSource = new BindingSource { DataSource = listSalary };
            }

        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpFrom.Value.Date;
            DateTime toDate = dtpTo.Value.Date;
            var listSalary = _salaryDetailServices.GetAll().Where(p => p.StaffId == int.Parse(getStaff.StaffId.ToString()) &&
                p.Date >= fromDate && p.Date <= toDate).ToList(); ;
            dgvListSalary.DataSource = new BindingSource { DataSource = listSalary };
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var listSalary = _salaryDetailServices.GetAll().Where(p => p.StaffId == int.Parse(getStaff.StaffId.ToString()));
            dgvListSalary.DataSource = new BindingSource { DataSource = listSalary };
        }

        private void dgvListSalary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var detail = _salaryDetailServices.GetAll().Where(p => p.SalaryDetailsId == int.Parse(txtSalaryDetailsID.Text)).FirstOrDefault();
                if (detail != null)
                {
                    if (MessageBox.Show("Do you want to Delete this", "Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _salaryDetailServices.Delete(detail);

                        var listSalary = _salaryDetailServices.GetAll().Where(p => p.StaffId == int.Parse(getStaff.StaffId.ToString()));
                        dgvListSalary.DataSource = new BindingSource { DataSource = listSalary };
                    }
                    else
                    {
                        MessageBox.Show("account not Deleted", "Delete account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui long chon dong muon xoa", "Thong bao", MessageBoxButtons.OK);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvListSalary.CurrentRow.Index;
            var listSalary = _salaryDetailServices.GetAll().Where(p => p.StaffId == int.Parse(getStaff.StaffId.ToString()));
            var salary = listSalary.ElementAtOrDefault(rowIndex);
            FrmUpdateSalary frmUpdateSalary = new FrmUpdateSalary()
            {
                GetSalaryDetail = salary,
            };
            
            if (frmUpdateSalary.ShowDialog() == DialogResult.OK)
            {
                this.Hide();

                dgvListSalary.DataSource = new BindingSource { DataSource = _salaryDetailServices.GetAll().Where(p => p.StaffId == int.Parse(getStaff.StaffId.ToString())) };
            }
        }
    }
}
