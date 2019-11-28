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
        ErrorProvider error1 = new ErrorProvider();
        DataManager dataMng = DataManager.GetInstance;
        public Find_Student_form()
        {
            InitializeComponent();
        }
       /* private void updategridOutput()
        {
            gridOutput.Rows.Clear();
            List<Student> stuList = dataMng.getStudentList();
            for (int i = 0; i < stuList.Count; ++i)
            {
                DataGridViewRow tmp = new DataGridViewRow();
                gridOutput.Rows.Add(stuList[i].Id, stuList[i].Name, stuList[i].Faculty, stuList[i].Mail, stuList[i].PhoneNumber,stuList[i].Present);
            }
        }*/
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
            checkPre.Checked = tmp.Present;
            txtPhonenumber.Enabled = true;
            txtStudentEmail.Enabled = true;
            txtStudentFaculty.Enabled = true;
            txtStudentID.Enabled = true;
            txtStudentName.Enabled = true;
            checkPre.Enabled = true;
            txtStudentName.Focus();
            btnSaveChanges.Enabled = true;
            btnDel.Enabled = true;
        }

        private void Find_Student_form_Load(object sender, EventArgs e)
        {
            txtPhonenumber.Enabled = false;
            txtStudentEmail.Enabled = false;
            txtStudentFaculty.Enabled = false;
            txtStudentName.Enabled = false;
            checkPre.Enabled = false;
            btnDel.Enabled = false;
            btnSaveChanges.Enabled = false;
            var source = new BindingSource(dataMng.getStudentList(), null);
            gridOutput.DataSource = source;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (!ValidateName() || !ValidatePhonenumber() || !ValidateEmail() || !ValidateFaculty())
            {
                MessageBox.Show("Please fill valid information");
                return;
            }
            dataMng.update(new Student(txtStudentID.Text, txtStudentName.Text, txtPhonenumber.Text, txtStudentEmail.Text, txtStudentFaculty.Text,checkPre.Checked));
            txtPhonenumber.Clear();
            txtStudentEmail.Clear();
            txtStudentFaculty.Clear();
            txtStudentID.Clear();
            txtStudentName.Clear();
            txtPhonenumber.Enabled = false;
            txtStudentEmail.Enabled = false;
            txtStudentFaculty.Enabled = false;
            txtStudentName.Enabled = false;
            checkPre.Enabled = false;
            txtStudentID.Focus();
            btnSaveChanges.Enabled = false;
            btnDel.Enabled = false;
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            txtPhonenumber.Clear();
            txtStudentEmail.Clear();
            txtStudentFaculty.Clear();
            txtStudentName.Clear();
            checkPre.Checked = false;
            txtPhonenumber.Enabled = false;
            txtStudentEmail.Enabled = false;
            txtStudentFaculty.Enabled = false;
            txtStudentName.Enabled = false;
            checkPre.Enabled = false;
            btnSaveChanges.Enabled = false;
            btnDel.Enabled = false;
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
                checkPre.Focus();
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            dataMng.Write2File();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            dataMng.delete(txtStudentID.Text);
            txtPhonenumber.Clear();
            txtStudentEmail.Clear();
            txtStudentFaculty.Clear();
            txtStudentID.Clear();
            txtStudentName.Clear();
            txtPhonenumber.Enabled = false;
            txtStudentEmail.Enabled = false;
            txtStudentFaculty.Enabled = false;
            txtStudentName.Enabled = false;
            checkPre.Enabled = false;
            txtStudentID.Focus();
            btnDel.Enabled = false;
            btnSaveChanges.Enabled = false;
        }
        
        private void txtStudentID_Validating(object sender, CancelEventArgs e)
        {
            ValidateID();
        }
        private bool ValidateID()
        {
            if (txtStudentID.Text == "" || txtStudentID.Text.Length != 7)
            {
                error1.SetError(txtStudentID, "ID must have 7 digits");
                return false;
            }
            for (int i = 0; i < 7; ++i)
            {
                if (txtStudentID.Text[i] < '0' || txtStudentID.Text[i] > '9')
                {
                    error1.SetError(txtStudentID, "ID must have 7 digits");
                    return false;
                }
            }
            error1.SetError(txtStudentID, "");
            return true;
        }

        private void txtStudentName_Validating(object sender, CancelEventArgs e)
        {
            ValidateName();
        }
        private bool ValidateName()
        {
            if (txtStudentName.Text == "")
            {
                error1.SetError(txtStudentName, "Name is required");
                return false;
            }
            error1.SetError(txtStudentName, "");
            return true;
        }

        private void txtStudentEmail_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmail();
        }
        private bool ValidateEmail()
        {
            if (txtStudentEmail.Text.Length < 13)
            {
                error1.SetError(txtStudentEmail, "Wrong email, only accept @hcmut.edu.vn");
                return false;
            }
            string tmp = txtStudentEmail.Text.Substring(txtStudentEmail.Text.Length - 13);
            if (tmp == "" || tmp != "@hcmut.edu.vn")
            {
                error1.SetError(txtStudentEmail, "Wrong email, only accept @hcmut.edu.vn");
                return false;
            }
            error1.SetError(txtStudentEmail, "");
            return true;
        }

        private void txtStudentFaculty_Validating(object sender, CancelEventArgs e)
        {
            ValidateFaculty();
        }
        private bool ValidateFaculty()
        {

            if (txtStudentFaculty.Text == "")
            {
                error1.SetError(txtStudentFaculty, "Faculty is required");
                return false;
            }
            error1.SetError(txtStudentFaculty, "");
            return true;
        }

        private void txtPhonenumber_Validating(object sender, CancelEventArgs e)
        {
            ValidatePhonenumber();
        }
        private bool ValidatePhonenumber()
        {
            if (txtPhonenumber.Text == "" || txtPhonenumber.Text.Length != 10)
            {
                error1.SetError(txtPhonenumber, "Phone number must have 10 digits");
                return false;
            }
            for (int i = 0; i < 9; i++)
            {
                if (Char.IsNumber(txtPhonenumber.Text[i]) == false)
                {
                    error1.SetError(txtPhonenumber, "Phone number must have 10 digits");
                    return false;
                }
            }
            error1.SetError(txtPhonenumber, "");
            return true;
        }
    }
}
