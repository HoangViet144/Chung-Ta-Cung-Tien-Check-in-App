using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace assignment_oop
{
   // public enum faculty { KHKTMT, QLCN, CK, DK, DDT, KTGT, KTHH, MTTN, KHUD, CNVL, KTXD };
    public class Student
    {
        string id;
        string name;
        string phoneNumber;
        string mail;
        string faculty;

        public string Id
        {
            get { return id; }
            set
            {
                if (value=="" || value.Length!=7) return;
                if (!int.TryParse(value, out int tmp)) return;
                id = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "") return;
                name = value;
            }
        }

        public string Mail
        {
            get { return mail; }
            set
            {
                if (value.Length < 13) return;
                string tmp = value.Substring(value.Length - 13);
                if (tmp == "" || tmp != "@hcmut.edu.vn") return;
                mail = value;
            }
        }
        

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (value == "" || value.Length != 10) return;
                if (!int.TryParse(value, out int tmp)) return;
                phoneNumber = value;
            }
        }

        public string Faculty
        {
            get { return faculty; }
            set
            {
                if (value == "") return;
                faculty = value;
            }
        }

        public bool Present { get; set; }
        public Student() { }

        public Student(Student curStu)
        {
            Id = curStu.id;
            Name = curStu.name;
            PhoneNumber = curStu.phoneNumber;
            Mail = curStu.mail;
            Faculty = curStu.faculty;
            Present = curStu.Present;
        }

        public Student(string id, string name,string phone, string mail, string fal,bool pre)
        {
            Id = id;
            Name = name;
            PhoneNumber = phone;
            Mail = mail;
            Faculty = fal;
            Present = pre;
        } 
    }
}
