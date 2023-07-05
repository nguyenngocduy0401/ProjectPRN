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
    public partial class FrmManagerShift : Form
    {
        ShiftServices _shiftServices = new ShiftServices();
        DayServices _dayServices = new DayServices();
        CoffeeManagerContext _context = new CoffeeManagerContext();
        public FrmManagerShift()
        {
            InitializeComponent();
            var listShift = _context.Shifts.ToList();
            dgvListShift.DataSource = new BindingSource { DataSource = listShift };
        }

        private void dgvListShift_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {
                var ShiftID = dgvListShift.Rows[e.RowIndex].Cells[0].Value;
                var Shift = _shiftServices.GetAll().Where(p => p.ShiftId.Equals(ShiftID)).FirstOrDefault();


                txtShiftID.Text = Shift.ShiftId.ToString();
                txtShiftName.Text = Shift.NameShift.ToString();
                txtStartTime.Text = Shift.StartTime.ToString() + 'h';
                txtEndTime.Text = Shift.EndTime.ToString() + 'h';

            }
            catch (Exception)
            {
                dgvListShift.DataSource = new BindingSource { DataSource = _shiftServices.GetAll() };
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var Shift = _shiftServices.GetAll().Where(p => p.ShiftId == int.Parse(txtShiftID.Text)).FirstOrDefault();
                if (Shift != null)
                {
                    if (MessageBox.Show("Do you want to Delete this account", "Delete account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _shiftServices.Delete(Shift);
                        dgvListShift.DataSource = new BindingSource { DataSource = _shiftServices.GetAll() };
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

        /* private void cbbMenu_SelectedIndexChanged(object sender, EventArgs e)
         {
             string selectedItem = cbbMenu.SelectedItem.ToString();
             string[] selectedParts = selectedItem.Split(new string[] { " | " }, StringSplitOptions.None);
             string dayID = selectedParts[0];
             if (dayID.Equals("ALL"))
             {
                 var listShift = _context.Shifts.ToList();
                 dgvListShift.DataSource = new BindingSource { DataSource = listShift };
             }
             else
             {
                 var listShift = _shiftServices.GetAll().Where(p => p.DayId == int.Parse(dayID));
                 dgvListShift.DataSource = new BindingSource { DataSource = listShift };
             }

         }

         private void FrmManagerShift_Load(object sender, EventArgs e)
         {
             var days = _dayServices.GetAll();
             cbbMenu.Items.Add("ALL");

             foreach (var day in days)
             {
                 cbbMenu.Items.Add(day.DayId + " | " + day.Day1);


             }
             cbbMenu.SelectedIndex = 0;

         }*/

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var search = txtSearch.Text;
            var listShift = _shiftServices.GetAll().Where(p => p.NameShift.ToLower().Contains(search.ToLower()));
            dgvListShift.DataSource = new BindingSource { DataSource = listShift };
        }

        private void dgvListShift_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
