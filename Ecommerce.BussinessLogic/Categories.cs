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
    }
}
