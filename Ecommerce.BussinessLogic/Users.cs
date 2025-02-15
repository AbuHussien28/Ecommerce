using Azure.Identity;
using Ecommerce.DataAceess;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BussinessLogic
{
    public class Users
    {
        DbContext context;

        public Users(string connection)
        {
            context= new DbContext(connection);
        }
        public bool GetUserRoleLogin(string username,string password) 
        {
            string query = $"select UserName,Password from UserLoginInfo where UserName='{username}'and Password='{password}'";
            DataTable dt = context.ExecuteQuery(query);
            return dt.Rows.Count > 0;
        }
        public bool GetAdminRoleLogin(string username, string password)
        {
            string query = $"select UserName,Password from AdminLoginInfo where UserName='{username}'and Password='{password}'";
            DataTable dt = context.ExecuteQuery(query);
            return dt.Rows.Count > 0; 
        }
        public int AddUser(string userName, string Email, string Password, int Age, string Address)
        {
            string query = $"insert into Users(UserName,Email,Password,Age,Address)values('{userName}','{Email}','{Password}',{Age},'{Address}')";
            int rowsAffected = context.ExecuteNonQuery(query);
            return rowsAffected;
        }
    }
}
