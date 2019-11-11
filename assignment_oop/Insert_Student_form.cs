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
        private void updateLbStudent()
        {
            lbStudent.Items.Clear();
            List<Student> stuList = dataMng.getStudentList();
            for (int i = 0; i < stuList.Count; ++i)
            {
                lbStudent.Items.Add(stuList[i].Id + " | " + stuList[i].Name + " | " + stuList[i].Faculty + " | " + stuList[i].Mail + " | " + stuList[i].PhoneNumber);
            }
        }

        private void Insert_Student_Load(object sender, EventArgs e)
        {
            string a = "", b = "", c = "";
            dataMng.getClassSectionDate(ref a, ref b,ref c);
            tbSubject.Text = a;
            tbSection.Text = b;
            tbDate.Text = c;
            updateLbStudent();
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
            dataMng.insert(new Student(txtStudentID.Text, txtStudentName.Text, txtStudentFaculty.Text, txtStudentEmail.Text, txtPhonenumber.Text));
            updateLbStudent();
        }
    }
}
