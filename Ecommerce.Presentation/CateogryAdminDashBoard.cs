using Ecommerce.BussinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce.Presentation
{
    public partial class CateogryAdminDashBoard : Form
    {
        private string userName;
        Categories categories;
        public CateogryAdminDashBoard(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            categories = new Categories(ConfigurationManager.ConnectionStrings["Ecommrce"].ConnectionString);
        }

        private void CateogryAdminDashBoard_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void profileLinkBtn_Click(object sender, EventArgs e)
        {
            ProfileScreen profile = new ProfileScreen(userName);
            profile.Owner = this;
            this.Hide();
            profile.Show();
        }

        private void lb_closeDashBoard_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void GetData()
        {
            DataTable dt = categories.GetCategoryId();
            dgv_CategoryAdmin.DataSource = dt;
            btn_Edit.Hide();
            btn_remove.Hide();
            btn_Add.Show();
        }
        int selectedCategoryItem = 0;
        private void dgv_CategoryAdmin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Edit.Show();
            btn_remove.Show();
            btn_Add.Hide();
            DataGridViewRow row = dgv_CategoryAdmin.SelectedRows[0];
            tb_categoryName.Text = row.Cells["CategoryName"].Value?.ToString() ?? "";
            selectedCategoryItem = (int)row.Cells["CategoryId"].Value;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int rowsAffected = categories.AddCategory(tb_categoryName.Text);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Category Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetData();
            }
            else
            {
                MessageBox.Show("Category Not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int rowsAffected = categories.EditCategory(selectedCategoryItem, tb_categoryName.Text);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Category Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetData();
            }
            else
            {
                MessageBox.Show("Category Not Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            int rowsAffected = categories.DeleteCategory(selectedCategoryItem);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Category Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetData();
            }
            else
            {
                MessageBox.Show("Category Not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            AdminDashBoradUserCrud userCrud = new AdminDashBoradUserCrud(userName);
            userCrud.Show();
            this.Close();
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            ProductsAdminDashBoard productsAdminDashBoard = new ProductsAdminDashBoard(userName);
            productsAdminDashBoard.Show();
            this.Close();
        }

        private void lb_RefreshData_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void pb_logOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
