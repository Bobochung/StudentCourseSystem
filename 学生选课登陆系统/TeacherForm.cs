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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            string n = Form1.name;
            textBox1.Text = n;
            textBox1.ReadOnly = true;
        }

        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherInfo aa = new TeacherInfo();
            aa.Show();
        }

        private void 选课信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseList aa = new CourseList();
            aa.Show();
        }

        private void 选课要求ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseReq aa = new CourseReq();
            aa.Show();
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出登录吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)   //再次确定是否要退出系统            
            {
                this.Hide();
                Form1 aa = new Form1();         //跳到登录界面          
                aa.Show();
            } 
        }
    }
}
