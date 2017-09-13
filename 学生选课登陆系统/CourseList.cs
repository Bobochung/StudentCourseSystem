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
    public partial class CourseList : Form
    {
        //定义数据集对象
        DataSet des = new DataSet();
        //定义Adapter
        OleDbDataAdapter adapter = null;

        public CourseList()
        {
            InitializeComponent();
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

        private void CourseList_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“学生选课DataSet.course”中。您可以根据需要移动或删除它。
            OleDbConnection conn = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=C:\\Users\\zhongbo\\Documents\\Visual Studio 2013\\Projects\\学生选课登陆系统\\学生选课登陆系统\\Resources\\学生选课.mdb");//创建连接     
            conn.Open();//打开连接 
            adapter = new OleDbDataAdapter("select * from course",conn);
            adapter.Fill(des,"course");
            this.dataGridView1.DataSource = des;
            this.dataGridView1.DataMember = "course";

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string n = Form1.name;
            OleDbConnection conn = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=C:\\Users\\zhongbo\\Documents\\Visual Studio 2013\\Projects\\学生选课登陆系统\\学生选课登陆系统\\Resources\\学生选课.mdb");//创建连接     
            conn.Open();//打开连接
            OleDbCommand comm = new OleDbCommand();//创建OleDbCommand对象         
            comm.Connection = conn;  //以上代码连接并打开数据库        
           // comm.CommandText = "INSERT INTO xuanke(用户名,CID) VALUES('"+n+"','"+dataGridView1[0,dataGridView1.CurrentCell.RowIndex].Value+"')";
            string strSQL = "INSERT INTO xuanke(用户名,CID) " +
            "VALUES ( '" + n + "','" + dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value + "')";
            comm = new OleDbCommand(strSQL, conn);
            comm.ExecuteNonQuery();
            this.Hide();
                
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
   

