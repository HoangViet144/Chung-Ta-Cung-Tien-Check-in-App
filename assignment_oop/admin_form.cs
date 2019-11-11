using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace assignment_oop
{
    public partial class admin_form : Form
    {
        public admin_form()
        {
            InitializeComponent();
        }

        private void Bt_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_form fl = new login_form();
            fl.Show();
        }
        private void Frame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void btnCreateClass_Click(object sender, EventArgs e)
        {
            dataManager dataMng = dataManager.GetInstance;
            Create_Class_Form cls = new Create_Class_Form();
            cls.Show();
        }

        private void btnImportClass_Click(object sender, EventArgs e)
        {
            dataManager dataMng = dataManager.GetInstance;
            string data_path = "";

            FolderBrowserDialog dlg = new FolderBrowserDialog();
            while (data_path == "")
            {
                MessageBox.Show("Please choose where to open your file");
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    data_path = dlg.SelectedPath;
                }
                if (data_path != "") MessageBox.Show(data_path);
            }
        }
    }
}
