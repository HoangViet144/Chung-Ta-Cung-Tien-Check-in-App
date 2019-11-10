using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_oop
{
    public partial class Insert_Student_form : Form
    {
        dataManager dataMng = dataManager.GetInstance;
        public Insert_Student_form()
        {
            InitializeComponent();
        }

        private void Insert_Student_Load(object sender, EventArgs e)
        {
            dataMng.getClassSection(lbClassName.Text, lbSection.Text);
        }
    }
}
