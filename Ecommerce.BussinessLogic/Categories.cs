using Ecommerce.DataAceess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BussinessLogic
{
    public class Categories
    {
        DbContext context;

        public Categories(string connection)
        {
            context = new DbContext(connection);
        }
        public DataTable GetCategoryId()
        {
            string query = "select CategoryId, CategoryName from Categories";
            DataTable dt = context.ExecuteQuery(query);
            return dt;
        }
        public int AddCategory(string CategoryName)
        {
            string query = $"insert into Categories(CategoryName)values('{CategoryName}')";
            int rowsAffected = context.ExecuteNonQuery(query);
            return rowsAffected;
        }
        public int EditCategory(int CategoryId, string CategoryName)
        {
            string query = $"update Categories set CategoryName='{CategoryName}' where CategoryId={CategoryId}";
            int rowsAffected = context.ExecuteNonQuery(query);
            return rowsAffected;
        }
        public int DeleteCategory(int CategoryId)
        {
            string query = $"delete from Categories where CategoryId={CategoryId}";
            int rowsAffected = context.ExecuteNonQuery(query);
            return rowsAffected;
        }
    }
}
