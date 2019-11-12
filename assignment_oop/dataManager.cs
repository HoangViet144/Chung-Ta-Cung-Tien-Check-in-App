using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace assignment_oop
{
    //Double Check Locking Singleton
    public sealed class dataManager
    {
        string data_path = "";
        string date;
        string subject;
        string session;
        List<Student> studentList;
        public string Subject
        {
            get
            {
                return subject;
            }
            set
            {
                if (value == "")
                {
                    MessageBox.Show("Wrong input!");
                    return;
                }
                subject = value;
            }
        }
        public string Session
        {
            get
            {
                return session;
            }
            set
            {
                if (value == "")
                {
                    MessageBox.Show("Wrong input!");
                    return;
                }
                session = value;
            }
        }
        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                if (value == "")
                {
                    MessageBox.Show("Wrong input!");
                    return;
                }
                date = value;
            }
        }
        public List<Student> StudentList
        {
            get
            {
                return studentList;
            }

        }
        public bool insert(Student item)
        {
            if (!item.IsStudent)
            {
                MessageBox.Show("Wrong information of the student");
                return false;
            }
            studentList.Add(item);
            return true;
        }
        public void update(Student student)
        {
            /*for(int i=0; i < studentList.Count; i++)
            {
                if (studentList[i].Id == id) return studentList[i];
            }

            foreach(IStudent student in studentList)
            {
                if(student.Id==id)
            }*/
            Student curStudent = studentList.Find(x => (x.Id == student.Id));
            if (curStudent == null)
            {
                MessageBox.Show("Can't find student");
                return;
            }
            Update1(curStudent, student);
            /*var student1 = new Student()
            {
                Id = 12,
                Name = "1122"
            };*/
        }
        public Student search(string stuId)
        {
            Student curStudent = studentList.Find(x => (x.Id == stuId));
            if (curStudent == null)
            {
                //MessageBox.Show("Can't find student");
                return null;
            }
            return curStudent;
        }
        public void delete(string stuId)
        {
            Student curStudent = studentList.Find(x => (x.Id == stuId));
            if (curStudent == null)
            {
                //MessageBox.Show("Can't find student");
                return;
            }
            studentList.Remove(curStudent);
        }
        
        private void Update1(Student student, Student stuNeedUpdate)
        {
            student.Name = stuNeedUpdate.Name;
            student.Id = stuNeedUpdate.Id;
            student.Mail = stuNeedUpdate.Mail;
            student.Faculty = stuNeedUpdate.Faculty;
            student.PhoneNumber = stuNeedUpdate.PhoneNumber;
        }

        private static int counter = 0;
        private static readonly object Instancelock = new object();
        private dataManager()
        {
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
            studentList=new List<Student>();
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

        public List<Student> getStudentList()
        {
            return studentList;
        }

        public void Write2File()
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Worksheets[1];
            worksheet.Name = subject+","+session+","+date;

            worksheet.Cells[1, "A"] = "ID";
            worksheet.Cells[1, "B"] = "Name";
            worksheet.Cells[1, "C"] = "Faculty";
            worksheet.Cells[1, "D"] = "Email";
            worksheet.Cells[1, "E"] = "Phone";
            int tmp = studentList.Count + 1;
            worksheet.Range["E2", "E" + tmp].NumberFormat = "@";
            for (int i=0;i<studentList.Count;++i)
            {
                worksheet.Cells[i+2, "A"] = studentList[i].Id;
                worksheet.Cells[i+2, "B"] = studentList[i].Name;
                worksheet.Cells[i+2, "C"] = studentList[i].Faculty;
                worksheet.Cells[i+2, "D"] = studentList[i].Mail;
                worksheet.Cells[i + 2, "E"] = studentList[i].PhoneNumber;
            }
            
            worksheet.Columns[1].AutoFit();
            worksheet.Columns[2].AutoFit();
            worksheet.Columns[3].AutoFit();
            worksheet.Columns[4].AutoFit();
            worksheet.Columns[5].AutoFit();
            workbook.SaveAs(data_path+"\\testtt.xlsx");
            workbook.Close(0);
            excelApp.Quit();
        }

        /*
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
        public List<Student> getStudentList()
        {
            return clsRm.StudentList;
        }
        */
    }
}
