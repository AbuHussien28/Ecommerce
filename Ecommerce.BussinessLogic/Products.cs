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
    }
}
