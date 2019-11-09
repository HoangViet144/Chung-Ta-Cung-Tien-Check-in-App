using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace assignment_oop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new login_form());*/
            //classManager test = new classManager();
            //test.writeTest("viet", "dep", "trai qua di");
            //test.writeTest("viet", "dep", "holahola");
            var csv = new StringBuilder();
            string fileName = "viet" + "_" +"dep" + ".csv";
            string filePath = "D:\\" + fileName;
            var first = "viet";
            var second = "fdasfa fdah";
            //Suggestion made by KyleMit
            var newLine = string.Format("{0},{1}", first, second);
            csv.AppendLine(newLine);

            //after your loop
            File.WriteAllText(filePath, csv.ToString());
        }
    }
}
