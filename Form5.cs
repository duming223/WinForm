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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadProvice();
        }

        private void LoadProvice()
        {
            List<model> models = new List<model>();
            string sql = "select *from xxx where fid=@id";
            SqlParameter pms = new SqlParameter("@id", SqlDbType.Int) { Value = 0 };
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, pms))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        model model = new model()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Fid = reader.GetInt32(2)
                        };
                        models.Add(model);
                        comboBox1.Items.Add(model);
                    }
                }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items!=null)
            {
                //comboBox2.Items.Clear();

                model model = comboBox1.SelectedItem as model;
                List<model> models = GetListCityByFid(model.Fid);

                //foreach (var item in models)
                //{
                //    comboBox2.Items.Add(item);
                //}

                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Id";
                comboBox2.DataSource = models;
            }
        }
        private List<model> GetListCityByFid(int id)
        {
            string sql = "select *from xxx where fid=@fid";
            List<model> models = new List<model>();
            SqlParameter spm = new SqlParameter("@fid", SqlDbType.Int, 32) { Value = id };

            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, spm))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        model model2 = new model()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Fid = reader.GetInt32(2)
                        };
                        models.Add(model2);
                    }
                }
            }
            return models;
        }
    }


}