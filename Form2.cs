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
    public partial class Form2 : Form
    {
        private int _id;
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string constr =
             @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mydb;Integrated Security=True;";

            string Account = textBox1.Text.Trim();
            string Password = textBox2.Text.Trim();
            using (SqlConnection con =new SqlConnection(constr))
            {
                string sql = string.Format("select * from [user] where acconut='{0}' ", Account);
                using (SqlCommand cmd =new SqlCommand(sql,con))
                {
                    con.Open();
                   SqlDataReader reader= cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            string paswd = reader.GetString(2).Trim();
                            if (Password==paswd)
                            {
                                MessageBox.Show("登录成功！");
                                GlobleHelper.Account = reader.GetString(1).Trim();
                                _id = reader.GetInt32(0);
                                button2.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("密码错误！");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("账号错误！");
                    }
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(_id);
            f3.Show();

        }
    }
}
