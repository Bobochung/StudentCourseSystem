using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace 学生选课登陆系统
{
    public partial class TeacherInfo : Form
    {
        public TeacherInfo()
        {
            InitializeComponent();
        }

        private void TeacherInfo_Load(object sender, EventArgs e)
        {
            string n = Form1.name;
            OleDbConnection conn = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=C:\\Users\\zhongbo\\Documents\\Visual Studio 2013\\Projects\\学生选课登陆系统\\学生选课登陆系统\\Resources\\学生选课.mdb");//创建连接     
            conn.Open();//打开连接   
            OleDbCommand comm = new OleDbCommand();//创建OleDbCommand对象         
            comm.Connection = conn;//以上代码连接并打开数据库        
            comm.CommandText = "select * from 登录 where 用户名='" + n + "'";//根据登录界面输入的信息去查询数据库内容     
            OleDbDataReader dr;
            dr = comm.ExecuteReader();//执行连接

            if (dr.Read() == true)//若能读到相应数据
            {
                textBox1.Text = dr["用户名"].ToString();//读姓名于textBox1显示                
                textBox1.ReadOnly = true;  //textBox1为只读 
                textBox2.Text = dr["年龄"].ToString();//读年龄于textBox2显示                
                textBox2.ReadOnly = true;//textBox2为只读 
                textBox3.Text = dr["性别"].ToString();//读性别于textBox3显示 
                textBox3.ReadOnly = true;//textBox3为只读 
                textBox4.Text = dr["电话"].ToString();//读电话于textBox4显示                
                textBox4.ReadOnly = true;//textBox4为只读 
                textBox5.Text = dr["角色"].ToString();//读角色于textBox5显示
                textBox5.ReadOnly = true;//textBox5为只读          
            }
            else//若不能读到相应数据报错          
            {
                MessageBox.Show("出错了哦!");
            }
            conn.Close();//关闭连接
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = Form1.name;
            OleDbConnection conn = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=C:\\Users\\zhongbo\\Documents\\Visual Studio 2013\\Projects\\学生选课登陆系统\\学生选课登陆系统\\Resources\\学生选课.mdb");//创建连接     
            conn.Open();//打开连接   
            OleDbCommand comm = new OleDbCommand();//创建OleDbCommand对象         
            comm.Connection = conn;  //以上代码连接并打开数据库        
            comm.CommandText = "select * from 登录 where 用户名='" + n + "'";//根据登录界面输入的信息去查询数据库内容     
            OleDbDataReader dr;
            dr = comm.ExecuteReader();//执行连接
            if (dr.Read() == true)
            {
                if (dr["角色"].ToString() == "学生")//若为学生用户则返回学生用户主界面         
                {
                    this.Hide();
                    StudentForm aa = new StudentForm();
                    aa.Show();
                }
                else if (dr["角色"].ToString() == "教师")//若为教师用户则返回学生用户主界面             
                {
                    this.Hide();
                    TeacherForm aa = new TeacherForm();
                    aa.Show();
                }
            }
            else
            {
                MessageBox.Show("出错了哦!");
            } 
            conn.Close(); 
        }
    }
}
