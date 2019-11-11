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
    public partial class Create_Class_Form : Form
    {
        public Create_Class_Form()
        {
            InitializeComponent();
        }

        private void btnCreateAndInsert_Click(object sender, EventArgs e)
        {
            if(cbSubject.Text==""||cbSession.Text=="")
            {
                MessageBox.Show("Please fill all the information");
                return;
            }
            this.Close();
            dataManager dataMng = dataManager.GetInstance;
            dataMng.setClassSessionDate(cbSubject.SelectedItem.ToString(), cbSession.SelectedItem.ToString(),datClassDate.Value.ToString("dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture));
            Insert_Student_form inStufm = new Insert_Student_form();
            inStufm.Show();
        }

        private void cbSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
            {
                cbSession.Focus();
            }
        }

        private void cbSession_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
            {
                datClassDate.Focus();
            }
        }
    }
}
