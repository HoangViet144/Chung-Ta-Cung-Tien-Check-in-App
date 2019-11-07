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
        private DataTable GetData(string sql)
        {
            string constr = @"Data Source=.\SQL2017;Initial Catalog=Cascading_ddl;Integrated Security=true";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(sql, con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    DataRow row = dt.NewRow();
                    row[0] = 0;
                    row[1] = "Please select";
                    dt.Rows.InsertAt(row, 0);
                    return dt;
                }
            }
        }
        private void Bt_add_Subject_Click(object sender, EventArgs e)
        {
            if (tb_add_Subject.Text== "")
            {
                MessageBox.Show("Please provide Subject name");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\db_oop_ass.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_subject (subject_name) VALUES (@subject_name)", con);
                cmd.Parameters.Add("@subject_name", tb_add_Subject.Text);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Admin_form_Load(object sender, EventArgs e)
        {
            /*cb_Subject.DataSource = this.GetData("SELECT subject_name FROM Countries");
            cbCountries.DisplayMember = "CountryName";
            cbCountries.ValueMember = "CountryId";
            cbStates.Enabled = false;
            cbCities.Enabled = false;*/
        }
    }
}
