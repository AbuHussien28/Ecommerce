using Ecommerce.BussinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce.Presentation
{
    public partial class SignUp : Form
    {
        Users user;
        Login login ;
        public SignUp()
        {
            InitializeComponent();
            user = new Users(ConfigurationManager.ConnectionStrings["Ecommrce"].ConnectionString);
            login = new Login();
        }

        private void lb_LoginHere_Click(object sender, EventArgs e)
        {
           
            login.Show();
            this.Close();
        }

        private void lb_closeSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            tb_UserName.Text = string.Empty;
            tb_Email.Text = string.Empty;
            tb_Password.Text = string.Empty;
            numberic_Age.Value = 0;
            tb_Address.Text = string.Empty;
        }

        private void checkBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPass.Checked)
                tb_Password.UseSystemPasswordChar = false;
            else
                tb_Password.UseSystemPasswordChar = true;
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                try
                {
                    int rowsAffected = user.AddUser(tb_UserName.Text, tb_Email.Text, tb_Password.Text, (int)numberic_Age.Value, tb_Address.Text);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("SignUp Suceess", "Suceess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        login.Show();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool ValidateInputs()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(tb_Email.Text) || !tb_Email.Text.Contains("@"))
            {
                lb_checkEmail.Text = "Please Write Email Correct";
                isValid = false;
            }
            else
            {
                lb_checkEmail.Text = "";
            }

            if (string.IsNullOrWhiteSpace(tb_UserName.Text))
            {
                lb_checkUserName.Text = "Please Enter UserName";
                isValid = false;
            }
            else
            {
                lb_checkUserName.Text = "";
            }

            if (string.IsNullOrWhiteSpace(tb_Password.Text))
            {
                lb_checkPassword.Text = "Please Enter Password";
                isValid = false;
            }
            else
            {
                lb_checkPassword.Text = "";
            }

            if (numberic_Age.Value < 1)
            {
                lb_checkAge.Text = "Please Enter Age";
                isValid = false;
            }
            else
            {
                lb_checkAge.Text = "";
            }

            return isValid;
        }
    }
}
