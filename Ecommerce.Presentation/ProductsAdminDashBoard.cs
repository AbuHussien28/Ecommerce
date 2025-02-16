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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Ecommerce.Presentation
{
    public partial class ProductsAdminDashBoard : Form
    {
        private string userName;
        Categories categories;
        Products products;
        public ProductsAdminDashBoard(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            categories = new Categories(ConfigurationManager.ConnectionStrings["Ecommrce"].ConnectionString);
            products = new Products(ConfigurationManager.ConnectionStrings["Ecommrce"].ConnectionString);
        }

        private void profileLinkBtn_Click(object sender, EventArgs e)
        {
            ProfileScreen profile = new ProfileScreen(userName);
            profile.Owner = this;
            this.Hide();
            profile.Show();
        }

        private void pb_logOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void lb_closeDashBoard_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void GetData()
        {
            DataTable dtGridView = products.getAllProduct();
            dgv_ProductAdmin.DataSource = dtGridView;
            DataTable dt = categories.GetCategoryId();
            cb_Category.DataSource = dt;
            cb_Category.DisplayMember = "CategoryName";
            cb_Category.ValueMember = "CategoryId";
            btn_Edit.Hide();
            btn_remove.Hide();
            btn_Add.Show();
        }

        private void ProductsAdminDashBoard_Load(object sender, EventArgs e)
        {
            GetData();
            dgv_ProductAdmin.CellDoubleClick += dgv_ProductAdmin_CellContentDoubleClick_1;
        }
        int selectedProductItem = 0;

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int rowsAffected = products.AddProduct(tb_ProductName.Text, (int)tb_numbericPrice.Value, (int)cb_Category.SelectedValue);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Product Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetData();
            }
            else
            {
                MessageBox.Show("Product Not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int rowsAffected = products.EditProduct(selectedProductItem, tb_ProductName.Text, (int)tb_numbericPrice.Value, (int)cb_Category.SelectedValue);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Product Edited Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetData();
            }
            else
            {
                MessageBox.Show("Product Not Edited", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            int rowsAffected = products.DeleteProduct(selectedProductItem);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Product Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetData();
            }
            else
            {
                MessageBox.Show("Product Not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lb_RefreshData_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void CategoryBtn_Click(object sender, EventArgs e)
        {
            CateogryAdminDashBoard cateogryAdminDashBoard = new CateogryAdminDashBoard(userName);
            cateogryAdminDashBoard.Show();
            this.Close();
        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            AdminDashBoradUserCrud userCrud = new AdminDashBoradUserCrud(userName);
            userCrud.Show();
            this.Close();
        }

        private void dgv_ProductAdmin_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
                btn_Edit.Show();
                btn_remove.Show();
                btn_Add.Hide();
                DataGridViewRow row = dgv_ProductAdmin.Rows[e.RowIndex];
                tb_ProductName.Text = row.Cells["ProductName"].Value?.ToString() ?? "";
                tb_numbericPrice.Value = Convert.ToInt32(row.Cells["Price"].Value);
                selectedProductItem = Convert.ToInt32(row.Cells["ProductId"].Value);
        }
    }
}
