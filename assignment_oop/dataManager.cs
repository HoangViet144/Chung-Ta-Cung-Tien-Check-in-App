using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace assignment_oop
{
    //Double Check Locking Singleton
    public sealed class dataManager
    {
        classRoom clsRm;
        private static int counter = 0;
        private static readonly object Instancelock = new object();
        private dataManager()
        {
            string data_path = "";

            FolderBrowserDialog dlg = new FolderBrowserDialog();
            while (data_path == "")
            {
                MessageBox.Show("Please choose where to save your file");
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    data_path = dlg.SelectedPath;
                }
                if (data_path != "") MessageBox.Show(data_path);
            }
            counter++;
            MessageBox.Show(counter.ToString());
            clsRm = new classRoom();
        }
        private static dataManager instance = null;

        public static dataManager GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (Instancelock)
                    {
                        if (instance == null)
                        {
                            instance = new dataManager();
                        }
                    }
                }
                return instance;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
        public void setClassSectionDate(string subject, string section,string date)
        {
            clsRm.Subject = subject;
            clsRm.Section = section;
            clsRm.Date = date;
        }
        public void getClassSectionDate(ref string subject, ref string section,ref string date)
        {
            subject = clsRm.Subject;
            section = clsRm.Section;
            date = clsRm.Date;
        }
    }
}
