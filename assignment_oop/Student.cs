using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace assignment_oop
{
    enum faculty { KHKTMT, QLCN, CK, DK, DDT, KTGT, KTHH, MTTN, KHUD, CNVL, KTXD };
    class Student : IStudent
    {
        int id;
        string name;
        string phoneNumber;
        string mail;
        faculty faculty;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value <= 0 || value >= 2000000)
                {
                    MessageBox.Show("Wrong id!");
                    return;
                }
                id = value;
            }
        }
        public Student(Student curStu)
        {
            id = curStu.id;
            name = curStu.name;
            phoneNumber = curStu.phoneNumber;
            mail = curStu.mail;
            faculty = curStu.faculty;
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
                    MessageBox.Show("Wrong input!");
                    return;
                }
                name = value;
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
                if (value =="" ||value.Length!=10 )
                {
                    MessageBox.Show("Wrong input!");
                    return;
                }
                for (int i = 0; i < 10; i++)
                {
                    if (Char.IsNumber(value[i]) == false)
                    {
                        MessageBox.Show("Wrong input!");
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
                string tmp=value.Substring(value.Length-13);
                if(tmp=="" || tmp!="@hcmut.edu.vn")
                {
                    MessageBox.Show("Wrong email, only accept @hcmut.edu.vn");
                    return;
                }
                mail = value;
            }
        }
        public faculty Faculty
        {
            get
            {
                return faculty;
            }
            set
            {
                faculty = value;
            }
        }
    }
}
