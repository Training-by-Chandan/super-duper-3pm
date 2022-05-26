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
            var student = new StudentInfo();
            student.Name = txtName.Text;
            student.Email = txtEmail.Text;

            var res = studentService.Create(student);
            if (res.Item1)
            {
                //todo after successful
                ResetTextBoxes();
                loadData();
            }
            else
            {
                MessageBox.Show(res.Item2);
            }
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
    }
}