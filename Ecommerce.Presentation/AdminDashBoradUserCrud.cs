using Ecommerce.BussinessLogic;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class AdminDashBoradUserCrud : Form
    {
        private string userName;
        Users user;
        public AdminDashBoradUserCrud(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            user = new Users(ConfigurationManager.ConnectionStrings["Ecommrce"].ConnectionString);
        }

        private void profileLinkBtn_Click(object sender, EventArgs e)
        {
            ProfileScreen profile = new ProfileScreen(userName);
            profile.Owner = this;
            this.Hide();
            profile.Show();
        }

        private void AdminDashBoradUserCrud_Load(object sender, EventArgs e)
        {
            GetData();

        }
        private void GetData()
        {
            DataTable dt = user.GetAllUser();
            dgv_userAdmin.DataSource = dt;
            btn_Edit.Hide();
            btn_remove.Hide();
            btn_Add.Show();
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int rowsAffected = user.AddUser(tb_UserName.Text, tb_Email.Text, tb_password.Text, (int)tb_numbricAge.Value, tb_Address.Text, cb_role.SelectedItem.ToString());

            if (rowsAffected > 0)
            {
                MessageBox.Show("User added successfully");
                GetData();
            }
            else
            {
                MessageBox.Show("Failed to add user");
            }
        }
        int selectedUserItem = 0;
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int rowsAffected = user.EditUser(selectedUserItem, tb_UserName.Text, tb_Email.Text, tb_password.Text, (int)tb_numbricAge.Value, tb_Address.Text, cb_role.SelectedItem.ToString());
            if (rowsAffected > 0)
            {
                MessageBox.Show("User Updated successfully");
                GetData();
            }
            else
            {
                MessageBox.Show("Failed to Update user");
            }
        }

        private void dgv_userAdmin_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_Edit.Show();
            btn_remove.Show();
            btn_Add.Hide();
            DataGridViewRow row = dgv_userAdmin.SelectedRows[0];
            tb_UserName.Text = row.Cells["UserName"].Value?.ToString() ?? "";
            tb_Email.Text = row.Cells["Email"].Value?.ToString() ?? "";
            tb_password.Text = row.Cells["Password"].Value?.ToString() ?? "";
            tb_numbricAge.Text = row.Cells["Age"].Value?.ToString() ?? "0";
            tb_Address.Text = row.Cells["Address"].Value?.ToString() ?? "";
            cb_role.SelectedItem = row.Cells["Role"].Value?.ToString() ?? "";
            selectedUserItem = (int)row.Cells["UserId"].Value;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            int rowsAffected = user.RemoveUser(selectedUserItem);
            if (rowsAffected > 0)
            {
                MessageBox.Show("User Deleted successfully");
                GetData();
            }
            else
            {
                MessageBox.Show("Failed to Delete user");
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

        private void productBtn_Click(object sender, EventArgs e)
        {
            ProductsAdminDashBoard productsAdminDashBoard = new ProductsAdminDashBoard(userName);
            productsAdminDashBoard.Show();
            this.Close();
        }
    }
}
