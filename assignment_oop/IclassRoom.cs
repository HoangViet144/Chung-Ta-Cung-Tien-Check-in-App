using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_oop
{
    interface IclassRoom
    {
        void insert(Student item);
        void update(IStudent item);
        void delete(int stuId);
        IStudent search(int stuId);
        void write2File();
    }
}
