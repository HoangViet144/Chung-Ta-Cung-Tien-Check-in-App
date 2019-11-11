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
                gridOutput.Rows.Add(stuList[i].Id, stuList[i].Name, stuList[i].Faculty, stuList[i].Mail, stuList[i].PhoneNumber);
            }
        }

        private void Insert_Student_Load(object sender, EventArgs e)
        {
            string a = "", b = "", c = "";
            dataMng.getClassSessionDate(ref a, ref b,ref c);
            tbSubject.Text = a;
            tbSession.Text = b;
            tbDate.Text = c;
            updategridOutput();
        }

        private void btnInsertStudent_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text == "" || txtStudentEmail.Text == "" || txtStudentFaculty.Text == "" || txtStudentName.Text == "")
            {
                MessageBox.Show("Please fill all the information");
                return;
            }
            if (dataMng.search(txtStudentID.Text) != null)
            {
                MessageBox.Show("Student is already exist");
                return;
            }
            dataMng.insert(new Student(txtStudentID.Text, txtStudentName.Text, txtPhonenumber.Text, txtStudentEmail.Text, txtStudentFaculty.Text));
            updategridOutput();
        }

        private void btnWrite2File_Click(object sender, EventArgs e)
        {
            dataMng.Write2File();
        }
    }
}
