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

        private void Bt_add_Subject_Click(object sender, EventArgs e)
        {
            //string query = "SELECT NEXT VALUE FOR tbl_subject.Sequence";
            //SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\ASUS\\Documents\\db_oop_ass.mdf; Integrated Security = True; Connect Timeout = 30");
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\db_oop_ass.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_subject (subject_name) VALUES (@subject_name)", con);
            cmd.Parameters.Add("@subject_name", tb_add_Subject.Text);
            //cmd.Parameters.Add("@id", 11);
            //cmd.Parameters.Add("@id", query);
            cmd.ExecuteNonQuery();
        }
    }
}
