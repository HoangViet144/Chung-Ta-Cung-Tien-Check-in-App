using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel= Microsoft.Office.Interop.Excel;
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
             Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new login_form());

            //classManager test = new classManager();
            //test.writeTest("viet", "dep", "trai qua di");
            //test.writeTest("viet", "dep", "holahola");
           /* var csv = new StringBuilder();
            string fileName = "viet" + "_" +"dep" + ".csv";
            string filePath = "D:\\" + fileName;
            var first = "viet";
            var second = "fdasfa fdah";*/
            //Suggestion made by KyleMit
            //   var newLine = string.Format("{0},{1}", first, second);
            // csv.AppendLine(newLine);

            //after your loop
            //File.WriteAllText(filePath, csv.ToString());
            //var excelApp = new Excel.Application();
            // Make the object visible.
            //  excelApp.Visible = true;
            // Create a new, empty workbook and add it to the collection returned 
            // by property Workbooks. The new workbook becomes the active workbook.
            // Add has an optional parameter for specifying a praticular template. 
            // Because no argument is sent in this example, Add creates a new workbook. 
            //  excelApp.Workbooks.Add();

            // This example uses a single workSheet. The explicit type casting is
            // removed in a later procedure.
            /*    Excel.Worksheet workSheet = (Excel.Worksheet)excelApp.Worksheets.Add();
                Excel._Worksheet worksheet2 = (Excel.Worksheet)excelApp.Worksheets.Add();
                workSheet.Name = "vietdeptrai";
                workSheet.Cells[1, "A"] = "ID Number";
                worksheet2.Cells[1, "A"] = "ID Number";
                workSheet.Cells[1, "B"] = "Current Balance";
                workSheet.Columns[1].AutoFit();
                workSheet.Columns[2].AutoFit();
                ((Excel.Range)workSheet.Columns[1]).AutoFit();
                ((Excel.Range)workSheet.Columns[2]).AutoFit();*/
            /*Excel.Workbook workbook = excelApp.Workbooks.Add();
            excelApp.Visible = true;
            Excel.Worksheet worksheet = workbook.Worksheets[1];
            worksheet.Name = "A";
            worksheet.Cells[1, "A"] = "ID Number";
            worksheet = workbook.Worksheets.Add();
            worksheet.Name = "B";
            worksheet.Cells[1, "A"] = "ID Numberr";
            workbook.SaveAs("d:\\abcd.xls");*/
        }
    }
}
