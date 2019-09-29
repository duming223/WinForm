using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    public static class SqlHelper
    {
        private static readonly string constr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        public static int ExecuteNonQuery(string sql, params SqlParameter[] pms)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (sql != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static object ExecuteScalar(string sql, params SqlParameter[] pms)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (sql != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        public static SqlDataReader ExecuteReader(string sql,params SqlParameter[] pms)
        {
            SqlConnection con = new SqlConnection(constr);
            using (SqlCommand com = new SqlCommand(sql, con))
            {
                if (pms != null)
                {
                    com.Parameters.AddRange(pms);
                }
                try
                {
                    con.Open();
                    return com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                } 
                catch
                {
                    con.Close();
                    con.Dispose();
                    throw;
                }
            }
        }
    }
}
