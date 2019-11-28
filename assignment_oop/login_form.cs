using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace assignment_oop
{
    public partial class login_form : Form
    {
        admin_form fm = new admin_form();
        public login_form()
        {
            InitializeComponent();
        }

        private void Login_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Bt_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bt_Login_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == "" || tb_Password.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                if(tb_Username.Text=="admin" && tb_Password.Text=="admin")
                {
                    this.Hide();
                    
                    fm.Show();
                }
                else if(tb_Username.Text=="user1" && tb_Password.Text=="user1")
                {
                    this.Hide();
                    
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
                /*SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\db_oop_ass.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand("Select * from tbl_user where user_name=@username and password=@password", con);
                cmd.Parameters.AddWithValue("@username", tb_Username.Text);
                cmd.Parameters.AddWithValue("@password", tb_Password.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable db = new DataTable();
                adapt.Fill(db);
                con.Close();
                string level = "";
                if (db != null)
                {
                    foreach (DataRow dr in db.Rows)
                    {
                        level = dr["level"].ToString();
                    }
                }
                if (level == "1")
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    admin_form fm = new admin_form();
                    fm.Show();
                }
                else if (level == "2")
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    user_form fm = new user_form();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Tb_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
            {
                tb_Password.Focus();
            }
        }

        private void Tb_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
            {
                bt_Login.Focus();
            }
        }
    }
}
