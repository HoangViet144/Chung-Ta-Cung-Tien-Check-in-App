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
using Excel = Microsoft.Office.Interop.Excel;
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
           // OpenFileDialog dlg = new OpenFileDialog();
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            
            MessageBox.Show("Please choose where to open your file");
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                data_path = dlg.SelectedPath;
            }
            if (data_path == "")
            {
                MessageBox.Show("Can't open file");
                return;
            }
            Excel.Application app = new Excel.Application();
            Excel.Workbook workbookImport = app.Workbooks.Open(data_path+ "\\test.xlsx");
            Excel.Worksheet worksheetImport = workbookImport.Sheets[1];
            Excel.Range rangeImport = worksheetImport.UsedRange;
            string nameSheet = worksheetImport.Name;
            if (nameSheet.IndexOf(',')==-1)
            {
                MessageBox.Show("Wrong file");
                return;
            }
            dataMng.Subject = nameSheet.Substring(0, nameSheet.IndexOf(','));
            nameSheet = nameSheet.Substring(nameSheet.IndexOf(',')+1);
            dataMng.Session = nameSheet.Substring(0, nameSheet.IndexOf(','));
            nameSheet = nameSheet.Substring(nameSheet.IndexOf(',')+1);
            dataMng.Date = nameSheet;
            int row = rangeImport.Rows.Count;
            for(int i=2;i<=row;++i)
            {

                 dataMng.insert(new Student(worksheetImport.Cells[i,1].Text.ToString(), 
                     worksheetImport.Cells[i,2].Text.ToString(),
                     worksheetImport.Cells[i,5].Text.ToString(), 
                     worksheetImport.Cells[i,4].Text.ToString(), 
                     worksheetImport.Cells[i,3].Text.ToString()));
            }
            workbookImport.Close(0);
            app.Quit();
        }

        private void btnModifyStu_Click(object sender, EventArgs e)
        {
            Find_Student_form find = new Find_Student_form();
            find.Show();
        }
    }
}
