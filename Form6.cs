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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoadAreasToTree(0, this.treeView1.Nodes);
        }
         
        private void LoadAreasToTree(int v, TreeNodeCollection nodes)
        {
            List<model> models = GetCityListById(v);
            foreach (var item in models)
            {
               TreeNode treeNode= nodes.Add(item.Name);
                treeNode.Tag = item.Id;
                LoadAreasToTree(item.Id, treeNode.Nodes);
            }
        }

        private List<model> GetCityListById(int v)
        {
            List<model> models = new List<model>();
            string sql = "select * from xxx where fid=@id";
            SqlParameter pms = new SqlParameter("@id", SqlDbType.Int) { Value = v };

            using (SqlDataReader reader=SqlHelper.ExecuteReader(sql,pms))
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
                    }
                }
                return models;
            }
        }
    }
}
