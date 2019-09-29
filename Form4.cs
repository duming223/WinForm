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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string sql = "select paswd from [user] where acconut=@name" ;
            SqlParameter pms =   new SqlParameter("@name", SqlDbType.NVarChar, 10) { Value = textBox1.Text.Trim();

            object r = SqlHelper.ExecuteScalar(sql, pms);
            if ( r==null)
            {
                //this.BackColor = Color.Green;
                this.BackColor = Color.Red;
            }
            else
            if(textBox2.Text.Trim()==r.ToString())
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.Red;
            }
        }
    }
}
