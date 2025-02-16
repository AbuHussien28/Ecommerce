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
    public  class Favorites
    {
        private DbContext context;
        public Favorites(string con)
        {
            context = new DbContext(con);
        }
        public DataTable GetFavProduct(string userName)
        {
            string query = $"select p.ProductId,ProductName,Price,c.CategoryName from Categories c inner join Products p on c.CategoryId=p.CategoryId inner join Favorites f on p.ProductId=f.ProductId inner join Users u on u.UserId=f.UserId where u.UserName='{userName}'";
            DataTable dt = context.ExecuteQuery(query);
            return dt;
        }
        public bool AddToFavorites(string userName, int productId)
        {
            string checkQuery = $"SELECT * FROM Favorites WHERE UserId = (SELECT UserId FROM Users WHERE UserName = '{userName}') AND ProductId = {productId}";
            DataTable dt = context.ExecuteQuery(checkQuery);

            if (dt.Rows.Count > 0)
            {
                return false;
            }
            string insertQuery = $"INSERT INTO Favorites (UserId, ProductId) VALUES ((SELECT UserId FROM Users WHERE UserName = '{userName}'), {productId})";
            int rowsAffected = context.ExecuteNonQuery(insertQuery);
            return rowsAffected > 0;
        }
        public bool DeleteFromFav(string userName, int productId) 
        {
            string deleteQuery = $"DELETE FROM Favorites WHERE UserId IN (SELECT UserId FROM Users WHERE UserName = '{userName}') and ProductId={productId}";
            int rowsAffected = context.ExecuteNonQuery(deleteQuery);
            return rowsAffected > 0;
        }
        public DataTable GetFavProductByCategory(string userName,int categoryId)
        {
            string query = $"select p.ProductId,ProductName,Price,c.CategoryName from Categories c inner join Products p on c.CategoryId=p.CategoryId inner join Favorites f on p.ProductId=f.ProductId inner join Users u on u.UserId=f.UserId where u.UserName='{userName}' and c.CategoryId={categoryId}";
            DataTable dt = context.ExecuteQuery(query);
            return dt;
        }
    }
}
