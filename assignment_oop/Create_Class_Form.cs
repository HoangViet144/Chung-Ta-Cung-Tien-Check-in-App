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
            if(cbSubject.Text==""||cbSection.Text=="")
            {
                MessageBox.Show("Please fill all the information");
                return;
            }
            this.Close();
            dataManager dataMng = dataManager.GetInstance;
            dataMng.setClassSection(cbSubject.Text, cbSection.Text);
            Insert_Student_form inStufm = new Insert_Student_form();
            inStufm.Show();
        }
        private void Create_Class_Form_Load(object sender, EventArgs e)
        {
            /*cb_Subject.DataSource = this.GetData("SELECT subject_name FROM Countries");
            cbCountries.DisplayMember = "CountryName";
            cbCountries.ValueMember = "CountryId";
            cbStates.Enabled = false;
            cbCities.Enabled = false;*/
        }
    }
}
