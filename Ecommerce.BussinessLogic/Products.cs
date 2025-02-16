using Ecommerce.DataAceess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BussinessLogic
{
    public class Products
    {
        DbContext context;

        public Products(string connection)
        {
            context = new DbContext(connection);
        }
        public DataTable getByProduct(int CategoryId) 
        {
            string query = $"select ProductId,ProductName,Price,c.CategoryName from Products p inner join Categories c on c.CategoryId=p.CategoryId where c.CategoryId={CategoryId}";
            DataTable dt = context.ExecuteQuery(query);
            return dt;
        }
        public DataTable getAllProduct()
        {
            string query = $"select ProductId,ProductName,Price,c.CategoryName from Products p inner join Categories c on c.CategoryId=p.CategoryId";
            DataTable dt = context.ExecuteQuery(query);
            return dt;
        }
        public int AddProduct(string ProductName, int Price, int CategoryId)
        {
            string query = $"insert into Products(ProductName,Price,CategoryId)values('{ProductName}',{Price},{CategoryId})";
            int rowsAffected = context.ExecuteNonQuery(query);
            return rowsAffected;
        }
        public int EditProduct(int ProductId, string ProductName, int Price, int CategoryId)
        {
            string query = $"update Products set ProductName='{ProductName}',Price={Price},CategoryId={CategoryId} where ProductId={ProductId}";
            int rowsAffected = context.ExecuteNonQuery(query);
            return rowsAffected;
        }
        public int DeleteProduct(int ProductId) 
        {
            string query = $"delete from Products where ProductId={ProductId}";
            int rowsAffected = context.ExecuteNonQuery(query);
            return rowsAffected;
        }
    }
}
