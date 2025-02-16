namespace Ecommerce.Presentation
{
    partial class ProfileScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileScreen));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lb_messageWelcome = new Label();
            lb_UserName = new Label();
            lb_userNameContent = new Label();
            lb_EmailContent = new Label();
            lb_EmailTitle = new Label();
            lb_RoleContent = new Label();
            lb_Role = new Label();
            lb_AgeContent = new Label();
            lb_ageTitle = new Label();
            lb_ChangePassword = new Label();
            lb_ProfileCloseApp = new Label();
            lb_EditProfile = new Label();
            panelShowData = new Panel();
            panelEditProfile = new Panel();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            tb_numbericAge = new NumericUpDown();
            lb_saveEditProfile = new Label();
            tb_Email = new TextBox();
            tb_UserName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panelChangePassword = new Panel();
            lb_confirmPassword = new Label();
            lb_newPassword = new Label();
            lb_oldPassword = new Label();
            lb_changePasswordBtn = new Label();
            tb_ConfirmPassword = new TextBox();
            tb_NewPassword = new TextBox();
            tb_OldPassword = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelShowData.SuspendLayout();
            panelEditProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tb_numbericAge).BeginInit();
            panelChangePassword.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(688, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lb_messageWelcome
            // 
            lb_messageWelcome.AutoSize = true;
            lb_messageWelcome.Font = new Font("Segoe UI Emoji", 30F, FontStyle.Bold);
            lb_messageWelcome.ForeColor = Color.FromArgb(35, 55, 75);
            lb_messageWelcome.Location = new Point(352, 36);
            lb_messageWelcome.Name = "lb_messageWelcome";
            lb_messageWelcome.Size = new Size(194, 53);
            lb_messageWelcome.TabIndex = 11;
            lb_messageWelcome.Text = "Welcome";
            // 
            // lb_UserName
            // 
            lb_UserName.AutoSize = true;
            lb_UserName.Font = new Font("Segoe UI Black", 15F);
            lb_UserName.ForeColor = Color.FromArgb(54, 75, 99);
            lb_UserName.Location = new Point(363, 119);
            lb_UserName.Name = "lb_UserName";
            lb_UserName.Size = new Size(126, 28);
            lb_UserName.TabIndex = 12;
            lb_UserName.Text = "UserName :";
            // 
            // lb_userNameContent
            // 
            lb_userNameContent.AutoSize = true;
            lb_userNameContent.Font = new Font("Segoe UI Black", 12F);
            lb_userNameContent.ForeColor = Color.FromArgb(54, 75, 99);
            lb_userNameContent.Location = new Point(20, 17);
            lb_userNameContent.Name = "lb_userNameContent";
            lb_userNameContent.Size = new Size(0, 21);
            lb_userNameContent.TabIndex = 13;
            // 
            // lb_EmailContent
            // 
            lb_EmailContent.AutoSize = true;
            lb_EmailContent.Font = new Font("Segoe UI Black", 12F);
            lb_EmailContent.ForeColor = Color.FromArgb(54, 75, 99);
            lb_EmailContent.Location = new Point(20, 64);
            lb_EmailContent.Name = "lb_EmailContent";
            lb_EmailContent.Size = new Size(0, 21);
            lb_EmailContent.TabIndex = 15;
            // 
            // lb_EmailTitle
            // 
            lb_EmailTitle.AutoSize = true;
            lb_EmailTitle.Font = new Font("Segoe UI Black", 15F);
            lb_EmailTitle.ForeColor = Color.FromArgb(54, 75, 99);
            lb_EmailTitle.Location = new Point(363, 167);
            lb_EmailTitle.Name = "lb_EmailTitle";
            lb_EmailTitle.Size = new Size(77, 28);
            lb_EmailTitle.TabIndex = 14;
            lb_EmailTitle.Text = "Email :";
            // 
            // lb_RoleContent
            // 
            lb_RoleContent.AutoSize = true;
            lb_RoleContent.Font = new Font("Segoe UI Black", 12F);
            lb_RoleContent.ForeColor = Color.FromArgb(54, 75, 99);
            lb_RoleContent.Location = new Point(20, 166);
            lb_RoleContent.Name = "lb_RoleContent";
            lb_RoleContent.Size = new Size(0, 21);
            lb_RoleContent.TabIndex = 19;
            // 
            // lb_Role
            // 
            lb_Role.AutoSize = true;
            lb_Role.Font = new Font("Segoe UI Black", 15F);
            lb_Role.ForeColor = Color.FromArgb(54, 75, 99);
            lb_Role.Location = new Point(363, 268);
            lb_Role.Name = "lb_Role";
            lb_Role.Size = new Size(68, 28);
            lb_Role.TabIndex = 18;
            lb_Role.Text = "Role :";
            // 
            // lb_AgeContent
            // 
            lb_AgeContent.AutoSize = true;
            lb_AgeContent.Font = new Font("Segoe UI Black", 12F);
            lb_AgeContent.ForeColor = Color.FromArgb(54, 75, 99);
            lb_AgeContent.Location = new Point(20, 118);
            lb_AgeContent.Name = "lb_AgeContent";
            lb_AgeContent.Size = new Size(0, 21);
            lb_AgeContent.TabIndex = 17;
            // 
            // lb_ageTitle
            // 
            lb_ageTitle.AutoSize = true;
            lb_ageTitle.Font = new Font("Segoe UI Black", 15F);
            lb_ageTitle.ForeColor = Color.FromArgb(54, 75, 99);
            lb_ageTitle.Location = new Point(363, 221);
            lb_ageTitle.Name = "lb_ageTitle";
            lb_ageTitle.Size = new Size(63, 28);
            lb_ageTitle.TabIndex = 16;
            lb_ageTitle.Text = "Age :";
            // 
            // lb_ChangePassword
            // 
            lb_ChangePassword.AutoSize = true;
            lb_ChangePassword.BackColor = Color.FromArgb(219, 225, 227);
            lb_ChangePassword.Font = new Font("ae_Shado", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_ChangePassword.ForeColor = Color.FromArgb(54, 75, 99);
            lb_ChangePassword.Location = new Point(352, 427);
            lb_ChangePassword.Name = "lb_ChangePassword";
            lb_ChangePassword.Size = new Size(176, 23);
            lb_ChangePassword.TabIndex = 20;
            lb_ChangePassword.Text = "Change Password";
            lb_ChangePassword.Click += lb_ChangePassword_Click;
            // 
            // lb_ProfileCloseApp
            // 
            lb_ProfileCloseApp.AutoSize = true;
            lb_ProfileCloseApp.BackColor = Color.FromArgb(231, 234, 240);
            lb_ProfileCloseApp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_ProfileCloseApp.ForeColor = Color.FromArgb(50, 74, 133);
            lb_ProfileCloseApp.Location = new Point(720, 483);
            lb_ProfileCloseApp.Name = "lb_ProfileCloseApp";
            lb_ProfileCloseApp.Size = new Size(86, 21);
            lb_ProfileCloseApp.TabIndex = 25;
            lb_ProfileCloseApp.Text = "Close App";
            lb_ProfileCloseApp.Click += lb_ProfileCloseApp_Click;
            // 
            // lb_EditProfile
            // 
            lb_EditProfile.AutoSize = true;
            lb_EditProfile.BackColor = Color.FromArgb(219, 225, 227);
            lb_EditProfile.Font = new Font("ae_Shado", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_EditProfile.ForeColor = Color.FromArgb(54, 75, 99);
            lb_EditProfile.Location = new Point(563, 427);
            lb_EditProfile.Name = "lb_EditProfile";
            lb_EditProfile.Size = new Size(117, 23);
            lb_EditProfile.TabIndex = 26;
            lb_EditProfile.Text = "Edit Profile";
            lb_EditProfile.Click += lb_EditProfile_Click;
            // 
            // panelShowData
            // 
            panelShowData.Controls.Add(lb_userNameContent);
            panelShowData.Controls.Add(lb_EmailContent);
            panelShowData.Controls.Add(lb_AgeContent);
            panelShowData.Controls.Add(lb_RoleContent);
            panelShowData.Location = new Point(495, 108);
            panelShowData.Name = "panelShowData";
            panelShowData.Size = new Size(309, 209);
            panelShowData.TabIndex = 27;
            // 
            // panelEditProfile
            // 
            panelEditProfile.Controls.Add(label11);
            panelEditProfile.Controls.Add(label12);
            panelEditProfile.Controls.Add(label13);
            panelEditProfile.Controls.Add(tb_numbericAge);
            panelEditProfile.Controls.Add(lb_saveEditProfile);
            panelEditProfile.Controls.Add(tb_Email);
            panelEditProfile.Controls.Add(tb_UserName);
            panelEditProfile.Controls.Add(label1);
            panelEditProfile.Controls.Add(label2);
            panelEditProfile.Controls.Add(label3);
            panelEditProfile.Controls.Add(label4);
            panelEditProfile.Location = new Point(352, 90);
            panelEditProfile.Name = "panelEditProfile";
            panelEditProfile.Size = new Size(477, 259);
            panelEditProfile.TabIndex = 28;
            panelEditProfile.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 15F);
            label11.ForeColor = Color.FromArgb(54, 75, 99);
            label11.Location = new Point(34, 112);
            label11.Name = "label11";
            label11.Size = new Size(63, 28);
            label11.TabIndex = 31;
            label11.Text = "Age :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 15F);
            label12.ForeColor = Color.FromArgb(54, 75, 99);
            label12.Location = new Point(34, 58);
            label12.Name = "label12";
            label12.Size = new Size(77, 28);
            label12.TabIndex = 30;
            label12.Text = "Email :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Black", 15F);
            label13.ForeColor = Color.FromArgb(54, 75, 99);
            label13.Location = new Point(32, 11);
            label13.Name = "label13";
            label13.Size = new Size(126, 28);
            label13.TabIndex = 29;
            label13.Text = "UserName :";
            // 
            // tb_numbericAge
            // 
            tb_numbericAge.BackColor = Color.FromArgb(189, 204, 218);
            tb_numbericAge.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tb_numbericAge.ForeColor = Color.FromArgb(54, 75, 99);
            tb_numbericAge.Location = new Point(195, 110);
            tb_numbericAge.Name = "tb_numbericAge";
            tb_numbericAge.Size = new Size(222, 29);
            tb_numbericAge.TabIndex = 24;
            // 
            // lb_saveEditProfile
            // 
            lb_saveEditProfile.AutoSize = true;
            lb_saveEditProfile.BackColor = Color.FromArgb(219, 225, 227);
            lb_saveEditProfile.Font = new Font("ae_Shado", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_saveEditProfile.ForeColor = Color.FromArgb(54, 75, 99);
            lb_saveEditProfile.Location = new Point(173, 168);
            lb_saveEditProfile.Name = "lb_saveEditProfile";
            lb_saveEditProfile.Size = new Size(53, 23);
            lb_saveEditProfile.TabIndex = 28;
            lb_saveEditProfile.Text = "Save";
            lb_saveEditProfile.Click += lb_saveEditProfile_Click;
            // 
            // tb_Email
            // 
            tb_Email.BackColor = Color.FromArgb(189, 204, 218);
            tb_Email.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tb_Email.ForeColor = Color.FromArgb(54, 75, 99);
            tb_Email.Location = new Point(195, 56);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(222, 29);
            tb_Email.TabIndex = 21;
            // 
            // tb_UserName
            // 
            tb_UserName.BackColor = Color.FromArgb(189, 204, 218);
            tb_UserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tb_UserName.ForeColor = Color.FromArgb(54, 75, 99);
            tb_UserName.Location = new Point(195, 9);
            tb_UserName.Name = "tb_UserName";
            tb_UserName.Size = new Size(222, 29);
            tb_UserName.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F);
            label1.ForeColor = Color.FromArgb(54, 75, 99);
            label1.Location = new Point(20, 17);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F);
            label2.ForeColor = Color.FromArgb(54, 75, 99);
            label2.Location = new Point(20, 64);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F);
            label3.ForeColor = Color.FromArgb(54, 75, 99);
            label3.Location = new Point(20, 118);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F);
            label4.ForeColor = Color.FromArgb(54, 75, 99);
            label4.Location = new Point(20, 166);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 19;
            // 
            // panelChangePassword
            // 
            panelChangePassword.Controls.Add(lb_confirmPassword);
            panelChangePassword.Controls.Add(lb_newPassword);
            panelChangePassword.Controls.Add(lb_oldPassword);
            panelChangePassword.Controls.Add(lb_changePasswordBtn);
            panelChangePassword.Controls.Add(tb_ConfirmPassword);
            panelChangePassword.Controls.Add(tb_NewPassword);
            panelChangePassword.Controls.Add(tb_OldPassword);
            panelChangePassword.Controls.Add(label6);
            panelChangePassword.Controls.Add(label7);
            panelChangePassword.Controls.Add(label8);
            panelChangePassword.Controls.Add(label9);
            panelChangePassword.Location = new Point(351, 90);
            panelChangePassword.Name = "panelChangePassword";
            panelChangePassword.Size = new Size(466, 302);
            panelChangePassword.TabIndex = 0;
            panelChangePassword.Visible = false;
            // 
            // lb_confirmPassword
            // 
            lb_confirmPassword.AutoSize = true;
            lb_confirmPassword.Font = new Font("Segoe UI Black", 15F);
            lb_confirmPassword.ForeColor = Color.FromArgb(54, 75, 99);
            lb_confirmPassword.Location = new Point(3, 134);
            lb_confirmPassword.Name = "lb_confirmPassword";
            lb_confirmPassword.Size = new Size(196, 28);
            lb_confirmPassword.TabIndex = 31;
            lb_confirmPassword.Text = "Confirm Password";
            // 
            // lb_newPassword
            // 
            lb_newPassword.AutoSize = true;
            lb_newPassword.Font = new Font("Segoe UI Black", 15F);
            lb_newPassword.ForeColor = Color.FromArgb(54, 75, 99);
            lb_newPassword.Location = new Point(3, 75);
            lb_newPassword.Name = "lb_newPassword";
            lb_newPassword.Size = new Size(158, 28);
            lb_newPassword.TabIndex = 30;
            lb_newPassword.Text = "New Password";
            // 
            // lb_oldPassword
            // 
            lb_oldPassword.AutoSize = true;
            lb_oldPassword.Font = new Font("Segoe UI Black", 15F);
            lb_oldPassword.ForeColor = Color.FromArgb(54, 75, 99);
            lb_oldPassword.Location = new Point(3, 16);
            lb_oldPassword.Name = "lb_oldPassword";
            lb_oldPassword.Size = new Size(148, 28);
            lb_oldPassword.TabIndex = 0;
            lb_oldPassword.Text = "Old Password";
            // 
            // lb_changePasswordBtn
            // 
            lb_changePasswordBtn.AutoSize = true;
            lb_changePasswordBtn.BackColor = Color.FromArgb(219, 225, 227);
            lb_changePasswordBtn.Font = new Font("ae_Shado", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_changePasswordBtn.ForeColor = Color.FromArgb(54, 75, 99);
            lb_changePasswordBtn.Location = new Point(182, 202);
            lb_changePasswordBtn.Name = "lb_changePasswordBtn";
            lb_changePasswordBtn.Size = new Size(53, 23);
            lb_changePasswordBtn.TabIndex = 28;
            lb_changePasswordBtn.Text = "Save";
            lb_changePasswordBtn.Click += lb_changePasswordBtn_Click;
            // 
            // tb_ConfirmPassword
            // 
            tb_ConfirmPassword.BackColor = Color.FromArgb(189, 204, 218);
            tb_ConfirmPassword.Font = new Font("Segoe UI", 12F);
            tb_ConfirmPassword.ForeColor = Color.FromArgb(54, 75, 99);
            tb_ConfirmPassword.Location = new Point(211, 133);
            tb_ConfirmPassword.Name = "tb_ConfirmPassword";
            tb_ConfirmPassword.Size = new Size(222, 29);
            tb_ConfirmPassword.TabIndex = 23;
            // 
            // tb_NewPassword
            // 
            tb_NewPassword.BackColor = Color.FromArgb(189, 204, 218);
            tb_NewPassword.Font = new Font("Segoe UI", 12F);
            tb_NewPassword.ForeColor = Color.FromArgb(54, 75, 99);
            tb_NewPassword.Location = new Point(211, 72);
            tb_NewPassword.Name = "tb_NewPassword";
            tb_NewPassword.Size = new Size(222, 29);
            tb_NewPassword.TabIndex = 21;
            // 
            // tb_OldPassword
            // 
            tb_OldPassword.BackColor = Color.FromArgb(189, 204, 218);
            tb_OldPassword.Font = new Font("Segoe UI", 12F);
            tb_OldPassword.ForeColor = Color.FromArgb(54, 75, 99);
            tb_OldPassword.Location = new Point(211, 19);
            tb_OldPassword.Name = "tb_OldPassword";
            tb_OldPassword.Size = new Size(222, 29);
            tb_OldPassword.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 12F);
            label6.ForeColor = Color.FromArgb(54, 75, 99);
            label6.Location = new Point(20, 17);
            label6.Name = "label6";
            label6.Size = new Size(0, 21);
            label6.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 12F);
            label7.ForeColor = Color.FromArgb(54, 75, 99);
            label7.Location = new Point(20, 64);
            label7.Name = "label7";
            label7.Size = new Size(0, 21);
            label7.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 12F);
            label8.ForeColor = Color.FromArgb(54, 75, 99);
            label8.Location = new Point(20, 118);
            label8.Name = "label8";
            label8.Size = new Size(0, 21);
            label8.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 12F);
            label9.ForeColor = Color.FromArgb(54, 75, 99);
            label9.Location = new Point(20, 166);
            label9.Name = "label9";
            label9.Size = new Size(0, 21);
            label9.TabIndex = 19;
            // 
            // ProfileScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 234, 240);
            ClientSize = new Size(829, 513);
            Controls.Add(panelEditProfile);
            Controls.Add(panelChangePassword);
            Controls.Add(panelShowData);
            Controls.Add(lb_EditProfile);
            Controls.Add(lb_ProfileCloseApp);
            Controls.Add(lb_ChangePassword);
            Controls.Add(lb_Role);
            Controls.Add(lb_ageTitle);
            Controls.Add(lb_EmailTitle);
            Controls.Add(lb_UserName);
            Controls.Add(lb_messageWelcome);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "ProfileScreen";
            Text = "ProfileScreen";
            Load += ProfileScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelShowData.ResumeLayout(false);
            panelShowData.PerformLayout();
            panelEditProfile.ResumeLayout(false);
            panelEditProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tb_numbericAge).EndInit();
            panelChangePassword.ResumeLayout(false);
            panelChangePassword.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lb_messageWelcome;
        private Label lb_UserName;
        private Label lb_userNameContent;
        private Label lb_EmailContent;
        private Label lb_EmailTitle;
        private Label lb_RoleContent;
        private Label lb_Role;
        private Label lb_AgeContent;
        private Label lb_ageTitle;
        private Label lb_ChangePassword;
        private Label lb_ProfileCloseApp;
        private Label lb_EditProfile;
        private Panel panelShowData;
        private Panel panelEditProfile;
        private TextBox tb_Email;
        private TextBox tb_UserName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown tb_numbericAge;
        private Label lb_saveEditProfile;
        private Panel panelChangePassword;
        private Label lb_confirmPassword;
        private Label lb_newPassword;
        private Label lb_oldPassword;
        private Label lb_changePasswordBtn;
        private TextBox tb_ConfirmPassword;
        private TextBox tb_NewPassword;
        private TextBox tb_OldPassword;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}