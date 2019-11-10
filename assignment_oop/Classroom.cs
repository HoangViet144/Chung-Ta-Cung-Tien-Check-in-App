using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronXL;
namespace assignment_oop
{
    class classRoom: I_Db
    {
        string date;
        string subject;
        string section;
        List<Student> studentList = new List<Student>();
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
        public string Section
        {
            get
            {
                return section;
            }
            set
            {
                if (value == "")
                {
                    MessageBox.Show("Wrong input!");
                    return;
                }
                section = value;
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
        public void insert(Student item)
        {
            studentList.Add(item);
        }
        public void update(IStudent student)
        {
            /*for(int i=0; i < studentList.Count; i++)
            {
                if (studentList[i].Id == id) return studentList[i];
            }

            foreach(IStudent student in studentList)
            {
                if(student.Id==id)
            }*/
            IStudent curStudent = studentList.Find(x => (x.Id == student.Id));
            if(curStudent==null)
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
        public IStudent search(int stuId)
        {
            IStudent curStudent = studentList.Find(x => (x.Id == stuId));
            if (curStudent == null)
            {
                MessageBox.Show("Can't find student");
                return null;
            }
            return curStudent;
        }
        public void delete(int stuId)
        {
            Student curStudent = studentList.Find(x => (x.Id == stuId));
            if (curStudent == null)
            {
                MessageBox.Show("Can't find student");
                return;
            }
            studentList.Remove(curStudent);
        }
        public void write2File()
        {
            string nameExcel = "fdas";
            WorkBook workbook = WorkBook.Create(ExcelFileFormat.XLSX);
            var sheet = workbook.CreateWorkSheet(nameExcel);
            sheet["A1"].Value = "ID";
            sheet["B1"].Value = "STUDENT_ID";
            sheet["C1"].Value = "NAME";
            sheet["D1"].Value = "MAIL";
            sheet["E1"].Value = "FACULTY";
            sheet["F1"].Value = "PHONENUMBER";
            for(int i=0;i<studentList.Count;++i)
            {
                string cur = (i+2).ToString();
                sheet["A" + cur].Value = i + 1;
                sheet["B" + cur].Value = studentList[i].Id;
                sheet["C" + cur].Value = studentList[i].Name;
                sheet["D" + cur].Value = studentList[i].Mail;
                sheet["E" + cur].Value = studentList[i].Faculty;
                sheet["F" + cur].Value = studentList[i].PhoneNumber;
            }
            workbook.SaveAs( subject+section + date +".xlsx");
        }
        private void Update1(IStudent student, IStudent stuNeedUpdate)
        {
            student.Name = stuNeedUpdate.Name;
            student.Id = stuNeedUpdate.Id;
            student.Mail =stuNeedUpdate.Mail;
            student.Faculty = stuNeedUpdate.Faculty;
            student.PhoneNumber = stuNeedUpdate.PhoneNumber;
        }
        
    }
}
