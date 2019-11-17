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
        bool isStudent = true;
        bool present = false;
        string faculty;
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value=="" || value.Length!=7)
                {
                    isStudent = false;
                    MessageBox.Show("Id must have 7 digits");
                    return;
                }
                for(int i=0;i<7;++i)
                {
                    if(value[i]<'0' || value[i]>'9')
                    {
                        isStudent = false;
                        MessageBox.Show("Id must have 7 digits");
                        return;
                    }
                }
                id = value;
            }
        }
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
        public Student()
        {
            
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == "")
                {
                    isStudent = false;
                    MessageBox.Show("Name cannot be empty");
                    return;
                }
                name = value;
            }
        }
        public bool Present
        {
            get
            {
                return present;
            }
            set
            {
                present = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                if (value =="" || value.Length != 10)
                {
                    isStudent = false;
                    MessageBox.Show("Phone number must have 10 digits");
                    return;
                }
                for (int i = 0; i < 9; i++)
                {
                    if (Char.IsNumber(value[i]) == false)
                    {
                        isStudent = false;
                        MessageBox.Show("Phone number must have 10 digits");
                        return;
                    }
                }
                phoneNumber = value;
            }
        }
        public string Mail
        {
            get
            {
                return mail;
            }
            set
            {
                if (value.Length < 13)
                {
                    isStudent = false;
                    MessageBox.Show("Wrong email, only accept @hcmut.edu.vn");
                    return;
                }
                string tmp=value.Substring(value.Length-13);
                if(tmp=="" || tmp!="@hcmut.edu.vn")
                {
                    isStudent = false;
                    MessageBox.Show("Wrong email, only accept @hcmut.edu.vn");
                    return;
                }
                mail = value;
            }
        }
        public string Faculty
        {
            get
            {
                return faculty;
            }
            set
            {
                if(value=="")
                {
                    isStudent = false;
                    MessageBox.Show("Faculty cannot be empty");
                    return;
                }
                faculty = value;
            }
        }
        public bool IsStudent
        {
            get
            {
                return isStudent;
            }
        }
    }
}
