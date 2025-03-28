﻿using ProjectPRN;
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
    public partial class FrmManageStaff : Form
    {
        StaffServices _staffServices = new StaffServices();
        StaffRoleServices _staffRoleServices = new StaffRoleServices();
        public FrmManageStaff()
        {
            InitializeComponent();
            txtID.Enabled = false;
            btnUpdate.Enabled = false;
            btnAddShift.Enabled = false;
            var listStaff = _staffServices
                .GetAll()
                .Join(_staffRoleServices.GetAll(),
                      p => p.RoleId,
                      sr => sr.RoleId,
                      (p, sr) => new
                      {
                          p.StaffId,
                          p.Name,
                          p.Email,
                          p.BirthDay,
                          p.Salary,
                          sr.RoleName,
                          p.Phone,
                          p.Status
                      }
                      )
                //.Select(p => new
                //{
                //    p.StaffId,
                //    p.Name,
                //    p.Email,
                //    p.BirthDay,
                //    p.Phone,
                //    p.Salary,
                //    p.RoleName,
                //    p.OffShift
                //})
                .ToList();

            dgvStaffList.DataSource = new BindingSource { DataSource = listStaff };

            var listStaffRole = _staffRoleServices.GetAll().Select(p => new
            {
                Value = p.RoleId,
                Text = p.RoleName
            }).ToList();
            cbRole.ValueMember = "Value";
            cbRole.DisplayMember = "Text";
            cbRole.DataSource = listStaffRole;

            cbStatus.Items.Add("Inactive");
            cbStatus.Items.Add("Active");
        }

        private void dgvStaffList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCreate.Enabled = false;
            btnSearch.Enabled = true;
            btnUpdate.Enabled = true;
            btnAddShift.Enabled = true;
            var staffId = dgvStaffList.Rows[e.RowIndex].Cells[0].Value;
            var obj = _staffServices
                .GetAll()
                .Where(
                       p => p.StaffId.Equals(staffId)
                      )
                .FirstOrDefault();
            if (obj != null)
            {
                txtID.Text = obj.StaffId.ToString();
                txtName.Text = obj.Name;
                txtEmail.Text = obj.Email;
                txtPhone.Text = obj.Phone;
                txtHourlyWage.Text = obj.Salary.ToString();
                dtBirthday.Text = obj.BirthDay.ToString();
                cbRole.SelectedValue = obj.RoleId;
                cbStatus.SelectedIndex = obj.Status;
            }
        }
        private void resetState()
        {
            dgvStaffList.DataSource = new BindingSource
            {
                DataSource = _staffServices
                .GetAll()
                .Join(_staffRoleServices.GetAll(),
                      p => p.RoleId,
                      sr => sr.RoleId,
                      (p, sr) => new
                      {
                          p.StaffId,
                          p.Name,
                          p.Email,
                          p.BirthDay,
                          p.Salary,
                          sr.RoleName,
                          p.Phone,
                      }
                      )
            };

            btnCreate.Enabled = true;
            btnSearch.Enabled = true;
            btnUpdate.Enabled = false;
            btnAddShift.Enabled = false;

            txtID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtHourlyWage.Text = "";
            txtPhone.Text = "";
            numShiftOff.Value = 0;
            cbRole.SelectedIndex = 0;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var staff = new Staff();
            _staffServices = new StaffServices();
            //if (txtName.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtPhone.Text.Trim() == "" || txtHourlyWage.Text.Trim() == "")
            //{
            //    MessageBox.Show("All fields must be entered", "Announcement", MessageBoxButtons.OK);
            //    return;
            //}
            Utils.resetErrorMes();
            Boolean check = Utils.ProcessInput(txtName.Text, txtHourlyWage.Text, txtPhone.Text, txtEmail.Text);
            if (!check)
            {
                staff.Name = txtName.Text;
                staff.Email = txtEmail.Text;
                staff.Phone = txtPhone.Text;
                staff.RoleId = int.Parse(cbRole.SelectedValue.ToString());
                staff.BirthDay = dtBirthday.Value.Date;
                staff.Salary = int.Parse(txtHourlyWage.Text);
                staff.Status = cbStatus.SelectedIndex;
                _staffServices.Create(staff);
                MessageBox.Show("Create successful!", "Announcement", MessageBoxButtons.OK);
                resetState();
            }
            else
            {
                string message = string.Join('\n', Utils.errorMes);
                MessageBox.Show(message, "Announcement", MessageBoxButtons.OK);
            }
        }

        private void dgvStaffList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            e.Control.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            var obj = _staffServices
                .GetAll()
                .Where(
                        p => p.StaffId.Equals(int.Parse(txtID.Text))
                        )
                .FirstOrDefault();

            if (obj != null)
            {
                Utils.resetErrorMes();
                Boolean check = Utils.ProcessInput(txtName.Text, txtHourlyWage.Text, txtPhone.Text, txtEmail.Text);
                if (!check)
                {
                    obj.Name = txtName.Text;
                    obj.Email = txtEmail.Text;
                    obj.Phone = txtPhone.Text;
                    obj.BirthDay = dtBirthday.Value.Date;
                    obj.Salary = int.Parse(txtHourlyWage.Text);
                    obj.RoleId = int.Parse(cbRole.SelectedValue.ToString());
                    obj.Status = cbStatus.SelectedIndex;

                    _staffServices.Update(obj);
                    MessageBox.Show("Update successful!", "Announcement", MessageBoxButtons.OK);
                    resetState();
                }
                else
                {
                    string message = string.Join('\n', Utils.errorMes);
                    MessageBox.Show(message, "Announcement", MessageBoxButtons.OK);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String name = txtFindName.Text.Trim();
            var listStaff = _staffServices.GetAll();
            Boolean result = false;
            if (name == "")
            {
                MessageBox.Show("Pleae enter full name!", "Announcement", MessageBoxButtons.OK);
                return;
            }
            for (int i = 0; i < listStaff.Count; i++)
            {
                if (name.Trim().Equals(listStaff[i].Name))
                {
                    dgvStaffList.DataSource = new BindingSource { DataSource = listStaff[i] };
                    result = true;
                    break;
                }
            }
            if (!result)
            {
                MessageBox.Show("Can not find staff with name " + txtFindName.Text, "Announcement", MessageBoxButtons.OK);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            resetState();
        }

        private void btnAddShift_Click(object sender, EventArgs e)
        {
            Form shiftMana = new FrmManageStaffShift(txtID.Text, txtName.Text);
            shiftMana.ShowDialog();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvStaffList.CurrentRow.Index;

            var staff = (_staffServices.GetAll())[rowIndex];
            FrmSalary frmSalary = new FrmSalary
            {
                GetStaff = (_staffServices.GetAll())[rowIndex]
                ,

            };


            frmSalary.FormClosed += FrmSalary_FormClosed;

            this.Enabled = false;
            frmSalary.Show();
        }
        private void FrmSalary_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            this.Show(); // Hiển thị lại form Admin
        }
    }

}
