using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Crud : Form
    {
        string constr =
              @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mydb;Integrated Security=True;";
        public Crud()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {

            List<Student> students = new List<Student>();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string sql = "select * from student";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                students.Add(new Student
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Sex = reader.GetString(2),
                                    Birthday = reader.IsDBNull(3) ? DateTime.MinValue.ToString("yyyy-MM-dd") : reader.GetDateTime(3).ToString("yyyy-MM-dd"),
                                    PhNumble = reader.IsDBNull(4) ? null : reader.GetString(4),
                                    EamilAdd = reader.IsDBNull(5) ? null : reader.GetString(5),
                                    ClassId = reader.IsDBNull(6) ? null : (int?)reader.GetInt32(6)
                                });
                            }

                        }
                        else
                        {
                            //errorProvider1.SetError(dataGridView1, "wu xin xi");
                        }
                    }
                }
            }
            dataGridView1.DataSource = students;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("刷新成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                Student st = new Student()
                {
                    Name = AddBoxName.Text,
                    Sex = AddBoxSex.Text,
                    Birthday = AddBirthday.Text == "" ? DateTime.MinValue.ToString("yyyy-MM-dd") : AddBoxBrithday.Text,
                    PhNumble = AddBoxPhone.Text,
                    EamilAdd = AddBoxEmail.Text,
                    ClassId = Convert.ToInt32(AddBoxClass.Text)
                };

                using (SqlConnection con = new SqlConnection(constr))
                {
                    string sql = string.Format("insert into student values(N'{0}',N'{1}','{2}','{3}','{4}',{5})",
                       st.Name, st.Sex, st.Birthday, st.PhNumble, st.EamilAdd, st.ClassId);
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        con.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("添加完毕", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("添加失败", "提示！");
                        }
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("请重试！");
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Student st = new Student();

            try
            {
                st.Id = Convert.ToInt32(LabeID.Text);
                st.Name = RedactTxtName.Text.Trim();
                st.Sex = RedactTxtSex.Text.Trim();
                st.Birthday = RedactTxtBrithday.Text == "" ? DateTime.MinValue.ToString("yyyy-MM-dd") : RedactTxtBrithday.Text.Trim();
                st.PhNumble = RedactTxtPhone.Text.Trim();
                st.EamilAdd = RedactTxtEmail.Text.Trim();
                st.Class = RedactTxtClass.Text==""?st.Class="null": RedactTxtClass.Text;

                using (SqlConnection con = new SqlConnection(constr))
                {
                    string sql = string.Format(
                        "update student set name= N'{0}',gender=N'{1}',Brithday='{2}',phnumber='{3}',emailaddress='{4}',class={5} where id={6}",
                        st.Name, st.Sex, st.Birthday, st.PhNumble, st.EamilAdd, st.Class, st.Id);

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        con.Open();
                        int r = cmd.ExecuteNonQuery();

                        if (r > 0)
                        {
                            MessageBox.Show("修改成功！");
                            LoadData();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("输入有误！");
            }

        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            Student student = row.DataBoundItem as Student;

            if (student != null)
            {
                RedactTxtName.Text = student.Name;
                RedactTxtSex.Text = student.Sex;
                RedactTxtBrithday.Text = student.Birthday;
                RedactTxtPhone.Text = student.PhNumble;
                RedactTxtEmail.Text = student.EamilAdd;
                RedactTxtClass.Text = student.ClassId.ToString();
                LabeID.Text = student.Id.ToString();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show("确定删除？", "删除提示！", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result== System.Windows.Forms.DialogResult.OK)
            {
                using (SqlConnection con= new SqlConnection(constr))
                {
                    string sql = string.Format("delete student where id={0}", LabeID.Text);
                    using (SqlCommand cmd=new SqlCommand(sql,con))
                    {
                        con.Open();
                        int r = cmd.ExecuteNonQuery();
                        if (r>0)
                        {
                            this.Text = "删除了" + r + "条数据！";
                            LoadData();
                        }
                    }
                }
            }
        }

        private void 登录_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
