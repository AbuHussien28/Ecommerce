using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAceess
{
    public class DbContext
    {
        SqlConnection con;
        public DbContext(String connection) 
        {
            con = new SqlConnection(connection);
        }
        //==> Select using Disconnected Mode 
        public DataTable ExecuteQuery(string cmd) 
        {
            SqlCommand command = new SqlCommand(cmd, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        //Insert, update,Delete => connected Mode
        public int ExecuteNonQuery(string cmd) 
        {
            SqlCommand command = new SqlCommand(cmd, con);
            int affectedRow = 0;
            try
            {
                con.Open();
                affectedRow=command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                con.Close();
            }
            return affectedRow;
        }
    }
}
