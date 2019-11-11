using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_oop
{
   interface IStudent
    {
        int Id { get; set; }
        string Name { get; set; }
        string PhoneNumber { get; set; }
        string Mail { get; set; }
        string Faculty { get; set; }
    }
}
