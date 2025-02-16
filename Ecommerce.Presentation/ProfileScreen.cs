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
    public partial class ProfileScreen : Form
    {
        Users user;
        private string userName;
        public ProfileScreen(string UserName)
        {
            InitializeComponent();
            user = new Users(ConfigurationManager.ConnectionStrings["Ecommrce"].ConnectionString);
            userName = UserName;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void lb_ProfileCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lb_ChangePassword_Click(object sender, EventArgs e)
        {
            panelShowData.Visible = false;
            panelEditProfile.Visible = false;
            panelChangePassword.Visible = true;
        }
        private void LoadUserData()
        {
            DataTable dt = user.GetDataForPrfoile(userName);
            if (dt.Rows.Count > 0)
            {
                lb_userNameContent.Text = dt.Rows[0]["UserName"].ToString();
                lb_EmailContent.Text = dt.Rows[0]["Email"] != DBNull.Value ? dt.Rows[0]["Email"].ToString() : "Not Found Email";
                lb_AgeContent.Text = dt.Rows[0]["Age"] != DBNull.Value ? dt.Rows[0]["Age"].ToString() : "Age Not Found";
                lb_RoleContent.Text = dt.Rows[0]["Role"].ToString();
            }
            else
            {
                MessageBox.Show($"Not Found :{userName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProfileScreen_Load(object sender, EventArgs e)
        {
            LoadUserData();
            panelShowData.Visible = true;
            panelEditProfile.Visible = false;
            panelChangePassword.Visible = false;
        }

        private void lb_EditProfile_Click(object sender, EventArgs e)
        {
            panelShowData.Visible = false;
            panelEditProfile.Visible = true;
            panelChangePassword.Visible = false;
            DataTable dt = user.GetDataForPrfoile(userName);
            tb_UserName.Text = dt.Rows[0]["UserName"].ToString();
            tb_Email.Text = dt.Rows[0]["Email"] != DBNull.Value ? dt.Rows[0]["Email"].ToString() : "";
            tb_numbericAge.Value = dt.Rows[0]["Age"] != DBNull.Value ? (int)dt.Rows[0]["Age"] : 0;
        }

        private void lb_saveEditProfile_Click(object sender, EventArgs e)
        {

            int affectedRow = user.EditProfile(userName, tb_UserName.Text, tb_Email.Text, (int)tb_numbericAge.Value);
            if (affectedRow > 0)
            {
                MessageBox.Show("Edit Profile Done");
                LoadUserData();
            }
            else
                MessageBox.Show("Error!");
            panelShowData.Visible = true;
            panelEditProfile.Visible = false;
            panelChangePassword.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lb_changePasswordBtn_Click(object sender, EventArgs e)
        {

            DataTable dt = user.GetDataForPrfoile(userName);
            string oldPassword = dt.Rows[0]["Password"].ToString();
            string oldPasswordWrite = tb_OldPassword.Text;
            string newPassword = tb_NewPassword.Text;
            string confrimPassword = tb_ConfirmPassword.Text;
            if (string.IsNullOrWhiteSpace(oldPasswordWrite))
            {
                MessageBox.Show("Please Enter Old Password", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (oldPasswordWrite != oldPassword)
            {
                MessageBox.Show("old Password wrong", "Error!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please Enter New Password", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(confrimPassword))
            {
                MessageBox.Show("Please Enter Confirm Password", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (newPassword != confrimPassword)
            {
                MessageBox.Show("New Password and Confirm Password Not Match", "Error!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // تحديث كلمة المرور
            int affectedRow = user.ChangePassword(oldPassword, newPassword);
            if (affectedRow > 0)
            {
                MessageBox.Show("Changed Password Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUserData();
                panelShowData.Visible = true;
                panelEditProfile.Visible = false;
                panelChangePassword.Visible = false;
            }
            else
            {
                MessageBox.Show("Error hapen during running", "Error!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lb_back_Click(object sender, EventArgs e)
        {
            this.Owner?.Show();
            this.Hide();
        }

        private void chb_ShowOldPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_ShowOldPassword.Checked)
                tb_OldPassword.UseSystemPasswordChar = false;
            else
                tb_OldPassword.UseSystemPasswordChar = true;
        }

        private void ChB_ShowNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ChB_ShowNewPassword.Checked)
                tb_NewPassword.UseSystemPasswordChar = false;
            else
                tb_NewPassword.UseSystemPasswordChar = true;
        }

        private void ChB_ShowConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ChB_ShowConfirmPassword.Checked)
                tb_ConfirmPassword.UseSystemPasswordChar = false;
            else
                tb_ConfirmPassword.UseSystemPasswordChar = true;
        }
    }
}
