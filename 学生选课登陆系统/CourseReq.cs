using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生选课登陆系统
{
    public partial class CourseReq : Form
    {
        public CourseReq()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentForm ss = new StudentForm();
            ss.Show();
        }
    }
}
