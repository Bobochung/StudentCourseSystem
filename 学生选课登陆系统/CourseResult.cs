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
    public partial class CourseResult : Form
    {
        public CourseResult()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm aa = new StudentForm(); 
            aa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string g = Form1.name;
         /*   SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=.;database=db_Person;uid=sa;pwd=123456";
            conn.Open();          //打开连接  
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;//以上代码连接并打开数据库 
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT * FROM Course WHERE CId ='"+g+"'";//从course表中选出该同学已经选了的课         
            SqlDataReader myreader = comm.ExecuteReader();*/

            OleDbConnection conn = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=C:\\Users\\zhongbo\\Documents\\Visual Studio 2013\\Projects\\学生选课登陆系统\\学生选课登陆系统\\Resources\\学生选课.mdb");//创建连接     
            conn.Open();//打开连接   
            OleDbCommand comm = new OleDbCommand();//创建OleDbCommand对象         
            comm.Connection = conn;//以上代码连接并打开数据库        
           // comm.CommandText = "select * from course where CID=(select CID from xuanke where 用户名='"+g+"')";//根据登录界面输入的信息去查询数据库内容     
            comm.CommandText = "SELECT * FROM Course WHERE CId ='" + g + "'";//从course表中选出该同学已经选了的课
            OleDbDataReader myreader;
            myreader = comm.ExecuteReader();//执行连接
            listBox1.Items.Add("================================================================================");  //遍历显示 
            while (myreader.Read())
                listBox1.Items.Add(String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}",
                                    myreader[0].ToString(),
                                    myreader[1].ToString(),
                                    myreader[2].ToString(),
                                    myreader[3].ToString(),
                                    myreader[4].ToString(),
                                    myreader[5].ToString())); 
            conn.Close();
            myreader.Close();
            InitializeComponent();
        }

        private void CourseResult_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
