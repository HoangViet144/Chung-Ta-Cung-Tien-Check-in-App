using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;
using System.Threading.Tasks;
namespace assignment_oop
{
    //Double Check Locking Singleton
    public sealed class DataManager
    {
        string dataPath = "";
        string date;
        string subject;
        string session;
        BindingList<Student> students;

        public string Subject
        {
            get { return subject; }
            set
            {
                if (value == "")
                {
                    MessageBox.Show("subject cannot be empty");
                    return;
                }
                subject = value;
            }
        }

        public string Session
        {
            get { return session; }
            set
            {
                if (value == "")
                {
                    MessageBox.Show("session cannot be empty");
                    return;
                }
                session = value;
            }
        }

        public string Date
        {
            get { return date; }
            set
            {
                if (value == "")
                {
                    MessageBox.Show("format date is dd-mm-yyyy");
                    return;
                }
                date = value;
            }
        }

        public BindingList<Student> StudentList
        {
            get { return students; }
        }

        private static int counter = 0;
        private static readonly object Instancelock = new object();
        private DataManager()
        {
            counter++;
            students = new BindingList<Student>();
            students.AllowNew = true;
            students.AllowRemove = true;
            students.AllowEdit = true;
            students.RaiseListChangedEvents = true;
        }
        private static DataManager instance = null;

        public static DataManager GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (Instancelock)
                    {
                        if (instance == null)
                        {
                            instance = new DataManager();
                        }
                    }
                }
                return instance;
            }
        }
        public bool insert(Student item)
        {
            students.Add(item);
            return true;
        }
        public void update(Student student)
        {
            /*for(int i=0; i < studentList.Count; i++)
            {
                if (studentList[i].Id == id) return studentList[i];
            }
            foreach(Student student in students)
            {
                if(student.Id==id)
            }*/
            Student curStudent = students.SingleOrDefault(x => (x.Id == student.Id));
            if (curStudent == null)
            {
                MessageBox.Show("Can't find student");
                return;
            }
            Update1(curStudent, student);
        }

        private void Update1(Student student, Student stuNeedUpdate)
        {
            int index = students.IndexOf(student);
            students.Remove(student);
            students.Insert(index, stuNeedUpdate);
        }

        public Student search(string stuId)
        {
            return students.SingleOrDefault(x => (x.Id == stuId));
        }

        public void delete(string stuId)
        {
            Student curStudent = students.SingleOrDefault(x => (x.Id == stuId));
            if (curStudent == null) return;
            students.Remove(curStudent);
        }
        
        
        public void setClassSessionDate(string Subject, string Session, string Date)
        {
            subject = Subject;
            session = Session;
            date = Date;
        }
        public void getClassSessionDate(ref string Subject, ref string Session, ref string Date)
        {
            Subject = subject;
            Session = session;
            Date = date;
        }

        public BindingList<Student> getStudentList()
        {
            return students;
        }
        public void Write2File()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel files(*.xlsx)| *.xlsx | All files(*.*) | *.* ";
            saveFileDialog1.Title = "Save File";
            saveFileDialog1.ShowDialog();
            saveFileDialog1.CheckFileExists = true;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "xlsx";
            if (saveFileDialog1.FileName=="")
            {
                MessageBox.Show("Please choose a name");
                return;
            }
            dataPath = saveFileDialog1.FileName;
            Action myaction = () =>
              {
                  WriteToFile(dataPath);
              };
            Task task = new Task(myaction);
            task.Start();
        }
        private void WriteToFile(string dataPath)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Worksheets[1];
            worksheet.Name = subject + "," + session + "," + date;

            worksheet.Cells[1, "A"] = "ID";
            worksheet.Cells[1, "B"] = "Name";
            worksheet.Cells[1, "C"] = "Faculty";
            worksheet.Cells[1, "D"] = "Email";
            worksheet.Cells[1, "E"] = "Phone";
            worksheet.Cells[1, "F"] = "Present";
            int tmp = students.Count + 1;
            if (students.Count > 0)
                worksheet.Range["E2", "E" + tmp].NumberFormat = "@";
            for (int i = 0; i < students.Count; ++i)
            {
                worksheet.Cells[i + 2, "A"] = students[i].Id;
                worksheet.Cells[i + 2, "B"] = students[i].Name;
                worksheet.Cells[i + 2, "C"] = students[i].Faculty;
                worksheet.Cells[i + 2, "D"] = students[i].Mail;
                worksheet.Cells[i + 2, "E"] = students[i].PhoneNumber;
                worksheet.Cells[i + 2, "F"] = students[i].Present;
            }

            worksheet.Columns[1].AutoFit();
            worksheet.Columns[2].AutoFit();
            worksheet.Columns[3].AutoFit();
            worksheet.Columns[4].AutoFit();
            worksheet.Columns[5].AutoFit();
            worksheet.Columns[6].AutoFit();
            workbook.SaveAs(dataPath);
            workbook.Close(0);
            excelApp.Quit();
        }
    }
}
