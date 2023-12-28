using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class Helper
    {
        SqlConnection cn;
        SqlCommand cmd;
        string memo = ConfigurationManager.ConnectionStrings["batu"].ConnectionString;
        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p = null)
        {
            using (cn = new SqlConnection("batu"))
            {

            }
            using (cmd = new SqlCommand(cmdtext, cn))
            {
                if (p != null)
                {

                    cmd.Parameters.AddRange(p);
                }
                cn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    
}
}
