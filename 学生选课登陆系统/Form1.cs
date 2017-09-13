using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace 学生选课登陆系统
{
    public partial class Form1 : Form
    {
        public static string name = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          /*  SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=.;database=db_Person;uid=sa;pwd=123456";
            conn.Open();          //打开连接  
            SqlCommand comm = new SqlCommand();      
            comm.Connection = conn;//以上代码连接并打开数据库 
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from login where username='" + textBox1.Text + "'";//根据登录界面输入的信息去查询数据库内容  
            SqlDataReader dr;
            dr = comm.ExecuteReader();*/
            OleDbConnection conn = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=C:\\Users\\zhongbo\\Documents\\Visual Studio 2013\\Projects\\学生选课登陆系统\\学生选课登陆系统\\Resources\\学生选课.mdb");//创建连接     
            conn.Open();//打开连接   
            OleDbCommand comm = new OleDbCommand();//创建OleDbCommand对象         
            comm.Connection = conn;//以上代码连接并打开数据库        
            comm.CommandText = "select * from 登录 where 用户名='" + textBox1.Text + "'";//根据登录界面输入的信息去查询数据库内容     
            OleDbDataReader dr;           
            dr = comm.ExecuteReader();//执行连接
            if (dr.Read() == true)
            {
                if (dr["密码"].ToString() == textBox2.Text && dr["角色"].ToString() == comboBox1.Text)
                {
                    name = textBox1.Text;
                    if (dr["角色"].ToString() == "学生")
                    {
                        this.Hide();
                         StudentForm stu = new StudentForm();
                         stu.Show();
                    }
                    else if (dr["角色"].ToString() == "教师")
                    {
                        this.Hide();
                         TeacherForm tea = new TeacherForm();
                         tea.Show();
                    }
                }
                else
                {
                    MessageBox.Show("登陆角色错误或密码错误！");
                }
            }
            else {
                MessageBox.Show("无此用户！");
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "学生";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            changepwd cp = new changepwd();
            cp.Show();
        }
    }
}
