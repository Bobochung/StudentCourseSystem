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
    public partial class changepwd : Form
    {
        public changepwd()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = Form1.name;
           /* SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=.;database=db_Person;uid=sa;pwd=123456";
            conn.Open();           //打开连接  
            SqlCommand comm = new SqlCommand();//创建OleDbCommand对象        
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from 登录 where 用户名='" + textBox4.Text + "'";
            SqlDataReader dr;
            dr = comm.ExecuteReader();*/
            OleDbConnection conn = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=C:\\Users\\zhongbo\\Documents\\Visual Studio 2013\\Projects\\学生选课登陆系统\\学生选课登陆系统\\Resources\\学生选课.mdb");//创建连接     
            conn.Open();//打开连接   
            OleDbCommand comm = new OleDbCommand();//创建OleDbCommand对象         
            comm.Connection = conn;//以上代码连接并打开数据库        
            comm.CommandText = "select * from 登录 where 用户名='" + textBox4.Text + "'";     
            OleDbDataReader dr;
            dr = comm.ExecuteReader();//执行连接
            if (textBox6.Text == "张秀琼")
            {
                if (dr.Read() == true)
                {
                    if (dr["密码"].ToString() == textBox1.Text && textBox3.Text == textBox2.Text && textBox3.Text != "")
                    {
                        MessageBox.Show("恭喜你，密码修改成功！");
                    }
                    else if (textBox2.Text != textBox3.Text)
                    {
                        MessageBox.Show("两次输入密码不相同!");
                    }
                    else if (textBox2.Text == "")
                    {
                        MessageBox.Show("修改密码不能为空!");
                    }
                }
                else
                {
                    MessageBox.Show("出错啦!");
                }
            }
            else
            {
                MessageBox.Show("答案不正确哦!");
            }
            conn.Close();
        }
    }
}
