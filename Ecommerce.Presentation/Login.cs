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
    public partial class Login : Form
    {
        Users user;
        public Login()
        {
            InitializeComponent();
            user = new Users(ConfigurationManager.ConnectionStrings["Ecommrce"].ConnectionString);
        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_UserName.Text = string.Empty;
            tb_Password.Text = string.Empty;
        }

        private void lb_closeApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_registerHere_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Close();
        }

        private void lb_SignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Close();
        }

        private void checkBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPass.Checked)
                tb_Password.UseSystemPasswordChar = false;
            else
                tb_Password.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = tb_UserName.Text;
            if(userName == string.Empty)
                MessageBox.Show("Please Enter The User Name ");
            else if (tb_Password.Text == string.Empty)
                MessageBox.Show("Please Enter The Password ");
            if (user.GetUserRoleLogin(userName, tb_Password.Text))
            {
                this.Close();
                UserDashBoard userDashBoard = new UserDashBoard(userName);
                userDashBoard.Show();
            }
            else if (user.GetAdminRoleLogin(userName, tb_Password.Text))
            {
                AdminDashBoradUserCrud adminDashBorad=new AdminDashBoradUserCrud(userName);
                adminDashBorad.Show();
                this.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
