using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_oop
{
    public partial class Find_Student_form : Form
    {
        dataManager dataMng = dataManager.GetInstance;
        public Find_Student_form()
        {
            InitializeComponent();
        }
        private void updategridOutput()
        {
            gridOutput.Rows.Clear();
            List<Student> stuList = dataMng.getStudentList();
            for (int i = 0; i < stuList.Count; ++i)
            {
                DataGridViewRow tmp = new DataGridViewRow();
                gridOutput.Rows.Add(stuList[i].Id, stuList[i].Name, stuList[i].Faculty, stuList[i].Mail, stuList[i].PhoneNumber);
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if(dataMng.search(txtStudentID.Text)==null)
            {
                MessageBox.Show("Can't find student");
                return;
            }
            Student tmp = dataMng.search(txtStudentID.Text);
            txtStudentName.Text = tmp.Name;
            txtPhonenumber.Text = tmp.PhoneNumber;
            txtStudentEmail.Text = tmp.Mail;
            txtStudentFaculty.Text = tmp.Faculty;
            txtPhonenumber.Enabled = true;
            txtStudentEmail.Enabled = true;
            txtStudentFaculty.Enabled = true;
            txtStudentID.Enabled = true;
            txtStudentName.Enabled = true;
            txtStudentName.Focus();
        }

        private void Find_Student_form_Load(object sender, EventArgs e)
        {
            updategridOutput();
            txtPhonenumber.Enabled = false;
            txtStudentEmail.Enabled = false;
            txtStudentFaculty.Enabled = false;
            txtStudentName.Enabled = false;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            dataMng.update(new Student(txtStudentID.Text, txtStudentName.Text, txtPhonenumber.Text, txtStudentEmail.Text, txtStudentFaculty.Text));
            txtPhonenumber.Clear();
            txtStudentEmail.Clear();
            txtStudentFaculty.Clear();
            txtStudentID.Clear();
            txtStudentName.Clear();
            updategridOutput();
            txtPhonenumber.Enabled = false;
            txtStudentEmail.Enabled = false;
            txtStudentFaculty.Enabled = false;
            txtStudentName.Enabled = false;
            txtStudentID.Focus();
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            txtPhonenumber.Clear();
            txtStudentEmail.Clear();
            txtStudentFaculty.Clear();
            txtStudentName.Clear();
        }

        private void txtStudentID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
            {
                btnFind.Focus();
            }
        }

        private void txtStudentName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
            {
                txtStudentEmail.Focus();
            }
        }

        private void txtStudentEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
            {
                txtStudentFaculty.Focus();
            }
        }

        private void txtStudentFaculty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
            {
                txtPhonenumber.Focus();
            }
        }

        private void txtPhonenumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
            {
                btnSaveChanges.Focus();
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            dataMng.Write2File();
        }
    }
}
