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
    public partial class Insert_Student_form : Form
    {
        ErrorProvider error1 = new ErrorProvider();
        dataManager dataMng = dataManager.GetInstance;
        public Insert_Student_form()
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
                gridOutput.Rows.Add(stuList[i].Id, stuList[i].Name,  stuList[i].Mail, stuList[i].Faculty, stuList[i].PhoneNumber,stuList[i].Present);
            }
        }

        private void Insert_Student_Load(object sender, EventArgs e)
        {
            string a = "", b = "", c = "";
            dataMng.getClassSessionDate(ref a, ref b,ref c);
            tbSubject.Text = a;
            tbSession.Text = b;
            tbDate.Text = c;
            txtStudentID.Focus();
            updategridOutput();
        }

        private void btnInsertStudent_Click(object sender, EventArgs e)
        {
            if (!ValidateName() || !ValidatePhonenumber() || !ValidateEmail() || !ValidateFaculty())
            { 
                MessageBox.Show("Please fill valid information");
                return;
            }
            if (dataMng.search(txtStudentID.Text) != null)
            {
                MessageBox.Show("Student is already exist");
                return;
            }
            bool check=dataMng.insert(new Student(txtStudentID.Text, txtStudentName.Text, txtPhonenumber.Text, txtStudentEmail.Text, txtStudentFaculty.Text,checkPre.Checked));
            updategridOutput();
            if(check)
            {
                txtPhonenumber.Clear();
                txtStudentEmail.Clear();
                txtStudentFaculty.Clear();
                txtStudentID.Clear();
                txtStudentName.Clear();
                txtStudentID.Focus();
            }
        }

        private void btnWrite2File_Click(object sender, EventArgs e)
        {
            dataMng.Write2File();
        }

        private void txtStudentName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue=='\r')
            {
                txtStudentEmail.Focus();
            }
        }

        private void txtStudentID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
            {
                txtStudentName.Focus();
            }
        }

        private void txtStudentEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
            {
                txtStudentFaculty.Focus();
            }
        }

        private void txtPhonenumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
            {
                btnInsertStudent.Focus();
            }
        }

        private void txtStudentFaculty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
            {
                txtPhonenumber.Focus();
            }
        }

        private void txtStudentName_Validating(object sender, CancelEventArgs e)
        {
            ValidateName();
        }
        private void txtStudentID_Validating(object sender, CancelEventArgs e)
        {
            ValidateID();
        }

        private void txtStudentEmail_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmail();
        }

        private void txtStudentFaculty_Validating(object sender, CancelEventArgs e)
        {
            ValidateFaculty();
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
    }
}
