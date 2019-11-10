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
        public void setClassSection(string subject, string section)
        {
            clsRm.Subject = subject;
            clsRm.Section = section;
        }
        public void getClassSection(string subject, string section)
        {
            subject = clsRm.Subject;
            section = clsRm.Section;
        }
    }
}
