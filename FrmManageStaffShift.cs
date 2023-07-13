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

namespace ProjectPRN211
{
    public partial class FrmManageStaffShift : Form
    {
        ShiftDetailServices _shiftDetailServices = new ShiftDetailServices();
        ShiftServices _shiftServices = new ShiftServices();
        StaffServices _staffServices = new StaffServices();
        DayServices _dayServices = new DayServices();
        public FrmManageStaffShift(string staffId, string name)
        {
            InitializeComponent();
            txtName.Text = name;
            txtID.Text = staffId;
            resetState();
            var listShift = _shiftServices.GetAll().Select(p => new
            {
                Value = p.ShiftId,
                Text = p.NameShift
            }).ToList();
            cbShift.ValueMember = "Value";
            cbShift.DisplayMember = "Text";
            cbShift.DataSource = listShift;

            var listDay = _dayServices.GetAll().Select(p => new
            {
                Value = p.DayId,
                Text = p.Day1
            }).ToList();

            cbDay.ValueMember = "Value";
            cbDay.DisplayMember = "Text";
            cbDay.DataSource = listDay;
        }
        private void resetState()
        {   
            btnCreate.Enabled = true;
            var listShiftDetail = _shiftDetailServices
                .GetAll()
                .Where(
                        p => p.StaffId.Equals(int.Parse(txtID.Text))
                        )
                .Join(_shiftServices.GetAll(),
                      p => p.ShiftId,
                      ss => ss.ShiftId,
                      (p, ss) => new
                      {
                          p.StaffId,
                          p.DayId,
                          ss.NameShift,
                          ss.StartTime,
                          ss.EndTime
                      })
                .Join(_dayServices.GetAll(),
                      p => p.DayId,
                      ds => ds.DayId,
                      (p, ds) => new
                      {
                          p.NameShift,
                          ds.Day1,
                          p.StartTime,
                          p.EndTime
                      })
                .ToList();
            dgvShiftList.DataSource = new BindingSource { DataSource = listShiftDetail };
            btnDelete.Enabled = false;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var shiftDetail = new ShiftDetail();
            _shiftDetailServices = new ShiftDetailServices();
            try
            {
                shiftDetail.StaffId = int.Parse(txtID.Text);
                shiftDetail.ShiftId = int.Parse(cbShift.SelectedValue.ToString());
                shiftDetail.DayId = int.Parse(cbDay.SelectedValue.ToString());
                _shiftDetailServices.Create(shiftDetail);
                resetState();
                MessageBox.Show("Create successful!", "Announcement", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("The shift selected is a duplicate!", "Announcement", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var obj = _shiftDetailServices
                .GetAll()
                .Where(
                        p => p.StaffId.Equals(int.Parse(txtID.Text)) &&
                             p.DayId.Equals(int.Parse(cbDay.SelectedValue.ToString())) &&
                             p.ShiftId.Equals(int.Parse(cbShift.SelectedValue.ToString()))
                        )
                .FirstOrDefault();
            if (obj != null)
            {
                _shiftDetailServices.Delete(obj);
                MessageBox.Show("Delete successful!", "Announcement", MessageBoxButtons.OK);
            }
            resetState();
        }

        private void dgvShiftList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCreate.Enabled = false;
            btnDelete.Enabled = true;
            var staffId = int.Parse(txtID.Text);
            var shift = dgvShiftList.Rows[e.RowIndex].Cells[0].Value;
            var day = dgvShiftList.Rows[e.RowIndex].Cells[1].Value;
            var obj = _shiftDetailServices
                .GetAll()
                .Join(_dayServices.GetAll(),
                      p => p.DayId,
                      ds => ds.DayId,
                      (p, ds) => new
                      {   
                          p.ShiftId,
                          ds.DayId,
                          ds.Day1,
                          p.StaffId
                      })
                .Join(_shiftServices.GetAll(),
                      p => p.ShiftId,
                      ss => ss.ShiftId,
                      (p, ss) => new
                      {   
                          p.ShiftId,
                          p.DayId,
                          p.Day1,
                          p.StaffId,
                          ss.NameShift,
                      })
                .Where(
                       p => p.StaffId.Equals(staffId) &&
                            p.NameShift.Equals(shift) &&
                            p.Day1.Equals(day)
                      )
                .FirstOrDefault();
            if (obj != null)
            {
                cbDay.SelectedValue = obj.DayId;
                cbShift.SelectedValue = obj.ShiftId;
            }
        }

        private void dgvShiftList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            e.Control.Enabled = false;
        }
    }
}
