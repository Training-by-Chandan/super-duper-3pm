using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Models;
using WindowsFormsApp.Services;

namespace WindowsFormsApp
{
    public partial class frmStudent : Form
    {
        private StudentServices studentService = new StudentServices();

        public frmStudent()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var student = new StudentInfo(txtName.Text, txtEmail.Text);
            var res = studentService.Create(student);
            crudResult(res);
        }

        private void ResetTextBoxes()
        {
            txtName.Clear();
            txtEmail.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTextBoxes();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            gridStudent.DataSource = studentService.GetAll();
            gridStudent.Refresh();
        }

        private void gridStudent_SelectionChanged(object sender, EventArgs e)
        {
            var rows = gridStudent.SelectedRows;
            if (rows == null || rows.Count == 0)
            {
                ResetTextBoxes();
                toggleButtons(true);
            }
            else
            {
                var row = rows[0];
                lblId.Text = row.Cells["Id"].Value?.ToString();
                txtName.Text = row.Cells["Name"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                toggleButtons(false);
            }
        }

        private void toggleButtons(bool createMode)
        {
            btnCreate.Visible = createMode;
            btnReset.Visible = createMode;
            btnEdit.Visible = !createMode;
            btnDelete.Visible = !createMode;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var student = new StudentInfo(Convert.ToInt32(lblId.Text), txtName.Text, txtEmail.Text);
            var res = studentService.Edit(student);
            crudResult(res);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var prompt = MessageBox.Show("Are you sure you want to delete this item?", "Danger", MessageBoxButtons.YesNo);
            if (prompt == DialogResult.Yes)
            {
                var Id = Convert.ToInt32(lblId.Text);
                var res = studentService.Delete(Id);
                crudResult(res);
            }
        }

        private void crudResult((bool, string) res)
        {
            if (res.Item1)
            {
                ResetTextBoxes();
                loadData();
            }
            else
            {
                MessageBox.Show(res.Item2);
            }
        }
    }
}