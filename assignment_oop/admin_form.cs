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
using Microsoft.VisualBasic;
namespace assignment_oop
{
    public partial class admin_form : Form
    {
        dataManager dataMng = dataManager.GetInstance;
        public admin_form()
        {
            InitializeComponent();
        }

        private void Bt_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Frame_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to save your file before closing the program?", "Exit", MessageBoxButtons.YesNoCancel);
            if(dialog==DialogResult.Yes)
            {
                dataMng.Write2File();
            }
            if (dialog == DialogResult.Cancel)
            { 
                e.Cancel = true;
                return;
            }
            login_form log = new login_form();
            log.Show();
        }
        private void btnCreateClass_Click(object sender, EventArgs e)
        {
            dataManager dataMng = dataManager.GetInstance;
            Create_Class_Form cls = new Create_Class_Form();
            cls.Show();
        }

        private void btnImportClass_Click(object sender, EventArgs e)
        {
            
            string data_path = "";
            OpenFileDialog dlg = new OpenFileDialog
            {
                Title = "Browse Excel File",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xlsx",
                Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
               
            };
            // FolderBrowserDialog dlg = new FolderBrowserDialog();
            MessageBox.Show("Please choose where to open your file");
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                data_path = dlg.FileName;
            }
            if (data_path == "")
            {
                MessageBox.Show("Can't open file");
                return;
            }
            Excel.Application app = new Excel.Application();
            Excel.Workbook workbookImport = app.Workbooks.Open(data_path);
            Excel.Worksheet worksheetImport = workbookImport.Sheets[1];
            Excel.Range rangeImport = worksheetImport.UsedRange;
            string nameSheet = worksheetImport.Name;
            if (nameSheet.IndexOf(',')==-1)
            {
                MessageBox.Show("Wrong sheetName, sheet Name must be 'subject,session,date'");
                return;
            }
            dataMng.Subject = nameSheet.Substring(0, nameSheet.IndexOf(','));
            nameSheet = nameSheet.Substring(nameSheet.IndexOf(',')+1);
            dataMng.Session = nameSheet.Substring(0, nameSheet.IndexOf(','));
            nameSheet = nameSheet.Substring(nameSheet.IndexOf(',')+1);
            dataMng.Date = nameSheet;
            if (dataMng.Subject == null || dataMng.Session == null || dataMng.Date == null)
            {
                MessageBox.Show("Some information of class is missing. Please fill again the information of class");
                dataMng.Subject = Interaction.InputBox("Please fill subject name", "", "Example: GT1");
                dataMng.Session = Interaction.InputBox("Please fill session", "", "Example: Sat. Morning");
                dataMng.Date = Interaction.InputBox("Please fill date with the format dd-mm-yyyy", "", "Example: 01-01-2019");
            }
            if (dataMng.Subject == null || dataMng.Session == null || dataMng.Date == null)
            {
                MessageBox.Show("Some information of class is still missing. Please try again");
                return;
            }
            int row = rangeImport.Rows.Count;
            for(int i=2;i<=row;++i)
            {
                if(dataMng.search(worksheetImport.Cells[i, 1].Text.ToString())!=null)
                {
                    continue;
                }
                bool pre;
                if (worksheetImport.Cells[i, 6].Text.ToString() == "TRUE") pre = true;
                else pre = false;
                dataMng.insert(new Student(worksheetImport.Cells[i,1].Text.ToString(), 
                     worksheetImport.Cells[i,2].Text.ToString(),
                     worksheetImport.Cells[i,5].Text.ToString(), 
                     worksheetImport.Cells[i,4].Text.ToString(), 
                     worksheetImport.Cells[i,3].Text.ToString(),
                     pre));
            }
            workbookImport.Close(0);
            app.Quit();
        }

        private void btnModifyStu_Click(object sender, EventArgs e)
        {
            if (dataMng.Subject == null || dataMng.Session == null || dataMng.Date == null)
            {
                MessageBox.Show("Some information of class is missing. Please fill again the information of class");
                dataMng.Subject= Interaction.InputBox("Please fill subject name", "", "Example: GT1");
                dataMng.Session= Interaction.InputBox("Please fill session", "", "Example: Sat. Morning");
                dataMng.Date= Interaction.InputBox("Please fill date with the format dd-mm-yyyy", "", "Example: 01-01-2019");
            }
            if (dataMng.Subject == null || dataMng.Session == null || dataMng.Date == null)
            {
                MessageBox.Show("Some information of class is still missing. Please try again");
                return;
            }
            Find_Student_form find = new Find_Student_form();
            find.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (dataMng.Subject == null || dataMng.Session == null || dataMng.Date == null)
            {
                MessageBox.Show("Some information of class is missing. Please fill again the information of class");
                dataMng.Subject = Interaction.InputBox("Please fill subject name", "", "");
                dataMng.Session = Interaction.InputBox("Please fill session", "", "");
                dataMng.Date = Interaction.InputBox("Please fill date with the format dd-mm-yyyy", "", "");
            }
            if (dataMng.Subject == null || dataMng.Session == null || dataMng.Date == null)
            {
                MessageBox.Show("Some information of class is still missing. Please try again");
                return;
            }
            Insert_Student_form inStu = new Insert_Student_form();
            inStu.Show();
        }
    }
}
