using Azure;
using Azure.Identity;
using Ecommerce.DataAceess;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
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
        public DataTable GetDataForPrfoile(String UserName) 
        {
            string query = $"select UserName,Email,Password,Age,Address,Role from Users where UserName='{UserName}'";
            DataTable dt = context.ExecuteQuery(query);
            return dt;
        }
        public int EditProfile(string UserName, string newUserName, string Email, int age) 
        {
            string query = $"update Users set UserName='{newUserName}',Email='{Email}',Age={age} from Users where UserName='{UserName}'";
            int rowsAffected = context.ExecuteNonQuery(query);
            return rowsAffected;
        }
        public int ChangePassword(string OldPassword,string newPassword) 
        {
            string query = $"update Users set Password='{newPassword}' where Password='{OldPassword}'";
            int rowsAffected = context.ExecuteNonQuery(query);
            return rowsAffected;
        }
    }
}
