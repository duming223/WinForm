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
    public partial class Form3 : Form
    {
        private int _Id;
        string constr =
         @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mydb;Integrated Security=True;";
        public Form3(int id)
        {
            this._Id = id;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string oldpas = textBox1.Text.Trim();
            string newpas1 = textBox2.Text.Trim();
            string newpas2 = textBox3.Text.Trim();

            if (newpas1 != newpas2)
            {
                MessageBox.Show("两次输入不一致！");
            }
            else
            if (!ValidationPassword(oldpas))
            {
                MessageBox.Show("旧密码输入错误！");
            }else
                try
                {
                    if (UpdatePassword(newpas1, GlobleHelper.Account))
                    {
                        MessageBox.Show("修改成功！");
                    }
                }
                catch (Exception)
                {
                    {
                        MessageBox.Show("修改失败！");
                    }
                }
        }

        private bool UpdatePassword(string newpas, string acconut)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                string sql = string.Format("update [user] set paswd='{0}' where acconut='{1}'", newpas, acconut);
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    int r = cmd.ExecuteNonQuery();
                    return r > 0;
                }
            }
        }

        private bool ValidationPassword(string oldpas)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                string sql = string.Format("select paswd from [user] where acconut='{0}'", GlobleHelper.Account);
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    object r = cmd.ExecuteScalar();
                    if (r.ToString().Replace(" ", "") == oldpas)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
