namespace Ecommerce.Presentation
{
    partial class AdminDashBoradUserCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashBoradUserCrud));
            profileLinkBtn = new PictureBox();
            pb_logOut = new PictureBox();
            lb_AdminUserDashboard = new Label();
            dgv_userAdmin = new DataGridView();
            UserBtn = new Button();
            CategoryBtn = new Button();
            productBtn = new Button();
            lb_Operations = new Label();
            btn_Add = new Button();
            btn_remove = new Button();
            btn_Edit = new Button();
            lb_userName = new Label();
            tb_UserName = new TextBox();
            tb_Email = new TextBox();
            lb_Email = new Label();
            lb_age = new Label();
            tb_numbricAge = new NumericUpDown();
            tb_Address = new TextBox();
            lb_Address = new Label();
            lb_Role = new Label();
            cb_role = new ComboBox();
            lb_closeDashBoard = new Label();
            lb_RefreshData = new Label();
            tb_password = new TextBox();
            lb_pssword = new Label();
            ((System.ComponentModel.ISupportInitialize)profileLinkBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_logOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_userAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tb_numbricAge).BeginInit();
            SuspendLayout();
            // 
            // profileLinkBtn
            // 
            profileLinkBtn.Image = (Image)resources.GetObject("profileLinkBtn.Image");
            profileLinkBtn.Location = new Point(17, 17);
            profileLinkBtn.Margin = new Padding(4);
            profileLinkBtn.Name = "profileLinkBtn";
            profileLinkBtn.Size = new Size(103, 67);
            profileLinkBtn.SizeMode = PictureBoxSizeMode.Zoom;
            profileLinkBtn.TabIndex = 9;
            profileLinkBtn.TabStop = false;
            profileLinkBtn.Click += profileLinkBtn_Click;
            // 
            // pb_logOut
            // 
            pb_logOut.Image = (Image)resources.GetObject("pb_logOut.Image");
            pb_logOut.Location = new Point(953, 20);
            pb_logOut.Margin = new Padding(4);
            pb_logOut.Name = "pb_logOut";
            pb_logOut.Size = new Size(143, 70);
            pb_logOut.SizeMode = PictureBoxSizeMode.Zoom;
            pb_logOut.TabIndex = 11;
            pb_logOut.TabStop = false;
            pb_logOut.Click += pb_logOut_Click;
            // 
            // lb_AdminUserDashboard
            // 
            lb_AdminUserDashboard.AutoSize = true;
            lb_AdminUserDashboard.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lb_AdminUserDashboard.ForeColor = Color.FromArgb(50, 74, 133);
            lb_AdminUserDashboard.Location = new Point(153, 20);
            lb_AdminUserDashboard.Margin = new Padding(4, 0, 4, 0);
            lb_AdminUserDashboard.Name = "lb_AdminUserDashboard";
            lb_AdminUserDashboard.Size = new Size(391, 46);
            lb_AdminUserDashboard.TabIndex = 10;
            lb_AdminUserDashboard.Text = "Admin User DashBoard";
            // 
            // dgv_userAdmin
            // 
            dgv_userAdmin.BackgroundColor = Color.FromArgb(217, 217, 217);
            dgv_userAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_userAdmin.GridColor = Color.Silver;
            dgv_userAdmin.Location = new Point(405, 119);
            dgv_userAdmin.Margin = new Padding(4);
            dgv_userAdmin.Name = "dgv_userAdmin";
            dgv_userAdmin.RowHeadersWidth = 51;
            dgv_userAdmin.Size = new Size(637, 293);
            dgv_userAdmin.TabIndex = 12;
            dgv_userAdmin.CellMouseDoubleClick += dgv_userAdmin_CellMouseDoubleClick;
            // 
            // UserBtn
            // 
            UserBtn.BackColor = Color.White;
            UserBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            UserBtn.ForeColor = Color.FromArgb(12, 32, 84);
            UserBtn.Location = new Point(17, 119);
            UserBtn.Margin = new Padding(4);
            UserBtn.Name = "UserBtn";
            UserBtn.Size = new Size(209, 71);
            UserBtn.TabIndex = 13;
            UserBtn.Text = "User";
            UserBtn.UseVisualStyleBackColor = false;
            // 
            // CategoryBtn
            // 
            CategoryBtn.BackColor = Color.FromArgb(174, 195, 214);
            CategoryBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CategoryBtn.ForeColor = Color.FromArgb(12, 32, 84);
            CategoryBtn.Location = new Point(17, 218);
            CategoryBtn.Margin = new Padding(4);
            CategoryBtn.Name = "CategoryBtn";
            CategoryBtn.Size = new Size(209, 71);
            CategoryBtn.TabIndex = 14;
            CategoryBtn.Text = "Category ";
            CategoryBtn.UseVisualStyleBackColor = false;
            CategoryBtn.Click += CategoryBtn_Click;
            // 
            // productBtn
            // 
            productBtn.BackColor = Color.FromArgb(174, 195, 214);
            productBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            productBtn.ForeColor = Color.FromArgb(12, 32, 84);
            productBtn.Location = new Point(17, 315);
            productBtn.Margin = new Padding(4);
            productBtn.Name = "productBtn";
            productBtn.Size = new Size(209, 71);
            productBtn.TabIndex = 15;
            productBtn.Text = "Prodcuts";
            productBtn.UseVisualStyleBackColor = false;
            productBtn.Click += productBtn_Click;
            // 
            // lb_Operations
            // 
            lb_Operations.AutoSize = true;
            lb_Operations.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_Operations.ForeColor = Color.FromArgb(50, 74, 133);
            lb_Operations.Location = new Point(17, 423);
            lb_Operations.Margin = new Padding(4, 0, 4, 0);
            lb_Operations.Name = "lb_Operations";
            lb_Operations.Size = new Size(94, 21);
            lb_Operations.TabIndex = 16;
            lb_Operations.Text = "Operations";
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.FromArgb(174, 195, 214);
            btn_Add.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Add.ForeColor = Color.FromArgb(12, 32, 84);
            btn_Add.Location = new Point(17, 456);
            btn_Add.Margin = new Padding(4);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(134, 71);
            btn_Add.TabIndex = 18;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_remove
            // 
            btn_remove.BackColor = Color.FromArgb(174, 195, 214);
            btn_remove.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_remove.ForeColor = Color.FromArgb(12, 32, 84);
            btn_remove.Location = new Point(17, 638);
            btn_remove.Margin = new Padding(4);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(134, 71);
            btn_remove.TabIndex = 20;
            btn_remove.Text = "Remove";
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.BackColor = Color.FromArgb(174, 195, 214);
            btn_Edit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Edit.ForeColor = Color.FromArgb(12, 32, 84);
            btn_Edit.Location = new Point(17, 550);
            btn_Edit.Margin = new Padding(4);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(134, 71);
            btn_Edit.TabIndex = 19;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // lb_userName
            // 
            lb_userName.AutoSize = true;
            lb_userName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_userName.ForeColor = Color.FromArgb(50, 74, 133);
            lb_userName.Location = new Point(410, 434);
            lb_userName.Margin = new Padding(4, 0, 4, 0);
            lb_userName.Name = "lb_userName";
            lb_userName.Size = new Size(90, 21);
            lb_userName.TabIndex = 21;
            lb_userName.Text = "UserName";
            // 
            // tb_UserName
            // 
            tb_UserName.BackColor = Color.FromArgb(174, 195, 214);
            tb_UserName.ForeColor = Color.FromArgb(50, 74, 133);
            tb_UserName.Location = new Point(539, 423);
            tb_UserName.Margin = new Padding(4);
            tb_UserName.Name = "tb_UserName";
            tb_UserName.Size = new Size(265, 29);
            tb_UserName.TabIndex = 22;
            // 
            // tb_Email
            // 
            tb_Email.BackColor = Color.FromArgb(174, 195, 214);
            tb_Email.ForeColor = Color.FromArgb(50, 74, 133);
            tb_Email.Location = new Point(539, 520);
            tb_Email.Margin = new Padding(4);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(265, 29);
            tb_Email.TabIndex = 26;
            // 
            // lb_Email
            // 
            lb_Email.AutoSize = true;
            lb_Email.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_Email.ForeColor = Color.FromArgb(50, 74, 133);
            lb_Email.Location = new Point(410, 531);
            lb_Email.Margin = new Padding(4, 0, 4, 0);
            lb_Email.Name = "lb_Email";
            lb_Email.Size = new Size(59, 21);
            lb_Email.TabIndex = 25;
            lb_Email.Text = "E-mail";
            // 
            // lb_age
            // 
            lb_age.AutoSize = true;
            lb_age.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_age.ForeColor = Color.FromArgb(50, 74, 133);
            lb_age.Location = new Point(410, 588);
            lb_age.Margin = new Padding(4, 0, 4, 0);
            lb_age.Name = "lb_age";
            lb_age.Size = new Size(40, 21);
            lb_age.TabIndex = 27;
            lb_age.Text = "Age";
            // 
            // tb_numbricAge
            // 
            tb_numbricAge.BackColor = Color.FromArgb(174, 195, 214);
            tb_numbricAge.ForeColor = Color.FromArgb(50, 74, 133);
            tb_numbricAge.Location = new Point(539, 577);
            tb_numbricAge.Margin = new Padding(4);
            tb_numbricAge.Name = "tb_numbricAge";
            tb_numbricAge.Size = new Size(267, 29);
            tb_numbricAge.TabIndex = 28;
            // 
            // tb_Address
            // 
            tb_Address.BackColor = Color.FromArgb(174, 195, 214);
            tb_Address.ForeColor = Color.FromArgb(50, 74, 133);
            tb_Address.Location = new Point(539, 625);
            tb_Address.Margin = new Padding(4);
            tb_Address.Name = "tb_Address";
            tb_Address.Size = new Size(265, 29);
            tb_Address.TabIndex = 30;
            // 
            // lb_Address
            // 
            lb_Address.AutoSize = true;
            lb_Address.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_Address.ForeColor = Color.FromArgb(50, 74, 133);
            lb_Address.Location = new Point(410, 636);
            lb_Address.Margin = new Padding(4, 0, 4, 0);
            lb_Address.Name = "lb_Address";
            lb_Address.Size = new Size(70, 21);
            lb_Address.TabIndex = 29;
            lb_Address.Text = "Address";
            // 
            // lb_Role
            // 
            lb_Role.AutoSize = true;
            lb_Role.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_Role.ForeColor = Color.FromArgb(50, 74, 133);
            lb_Role.Location = new Point(410, 690);
            lb_Role.Margin = new Padding(4, 0, 4, 0);
            lb_Role.Name = "lb_Role";
            lb_Role.Size = new Size(44, 21);
            lb_Role.TabIndex = 31;
            lb_Role.Text = "Role";
            // 
            // cb_role
            // 
            cb_role.BackColor = Color.FromArgb(174, 195, 214);
            cb_role.ForeColor = Color.FromArgb(50, 74, 133);
            cb_role.FormattingEnabled = true;
            cb_role.Items.AddRange(new object[] { "Admin", "User" });
            cb_role.Location = new Point(539, 679);
            cb_role.Margin = new Padding(4);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(264, 29);
            cb_role.TabIndex = 32;
            // 
            // lb_closeDashBoard
            // 
            lb_closeDashBoard.AutoSize = true;
            lb_closeDashBoard.BackColor = Color.FromArgb(225, 241, 251);
            lb_closeDashBoard.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_closeDashBoard.ForeColor = Color.FromArgb(50, 74, 133);
            lb_closeDashBoard.Location = new Point(956, 682);
            lb_closeDashBoard.Name = "lb_closeDashBoard";
            lb_closeDashBoard.Size = new Size(86, 21);
            lb_closeDashBoard.TabIndex = 33;
            lb_closeDashBoard.Text = "Close App";
            lb_closeDashBoard.Click += lb_closeDashBoard_Click;
            // 
            // lb_RefreshData
            // 
            lb_RefreshData.AutoSize = true;
            lb_RefreshData.BackColor = Color.FromArgb(225, 241, 251);
            lb_RefreshData.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_RefreshData.ForeColor = Color.FromArgb(50, 74, 133);
            lb_RefreshData.Location = new Point(966, 431);
            lb_RefreshData.Name = "lb_RefreshData";
            lb_RefreshData.Size = new Size(76, 21);
            lb_RefreshData.TabIndex = 34;
            lb_RefreshData.Text = "Get Data";
            lb_RefreshData.Click += lb_RefreshData_Click;
            // 
            // tb_password
            // 
            tb_password.BackColor = Color.FromArgb(174, 195, 214);
            tb_password.ForeColor = Color.FromArgb(50, 74, 133);
            tb_password.Location = new Point(538, 471);
            tb_password.Margin = new Padding(4);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(265, 29);
            tb_password.TabIndex = 36;
            tb_password.UseSystemPasswordChar = true;
            // 
            // lb_pssword
            // 
            lb_pssword.AutoSize = true;
            lb_pssword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_pssword.ForeColor = Color.FromArgb(50, 74, 133);
            lb_pssword.Location = new Point(409, 482);
            lb_pssword.Margin = new Padding(4, 0, 4, 0);
            lb_pssword.Name = "lb_pssword";
            lb_pssword.Size = new Size(82, 21);
            lb_pssword.TabIndex = 35;
            lb_pssword.Text = "Password";
            // 
            // AdminDashBoradUserCrud
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 241, 250);
            ClientSize = new Size(1144, 758);
            ControlBox = false;
            Controls.Add(tb_password);
            Controls.Add(lb_pssword);
            Controls.Add(lb_RefreshData);
            Controls.Add(lb_closeDashBoard);
            Controls.Add(cb_role);
            Controls.Add(lb_Role);
            Controls.Add(tb_Address);
            Controls.Add(lb_Address);
            Controls.Add(tb_numbricAge);
            Controls.Add(lb_age);
            Controls.Add(tb_Email);
            Controls.Add(lb_Email);
            Controls.Add(tb_UserName);
            Controls.Add(lb_userName);
            Controls.Add(btn_remove);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Add);
            Controls.Add(lb_Operations);
            Controls.Add(productBtn);
            Controls.Add(CategoryBtn);
            Controls.Add(UserBtn);
            Controls.Add(dgv_userAdmin);
            Controls.Add(pb_logOut);
            Controls.Add(lb_AdminUserDashboard);
            Controls.Add(profileLinkBtn);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "AdminDashBoradUserCrud";
            Text = "AdminDashBoradUserCrud";
            Load += AdminDashBoradUserCrud_Load;
            ((System.ComponentModel.ISupportInitialize)profileLinkBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_logOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_userAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)tb_numbricAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox profileLinkBtn;
        private PictureBox pb_logOut;
        private Label lb_AdminUserDashboard;
        private DataGridView dgv_userAdmin;
        private Button UserBtn;
        private Button CategoryBtn;
        private Button productBtn;
        private Label lb_Operations;
        private Button btn_Add;
        private Button btn_remove;
        private Button btn_Edit;
        private Label lb_userName;
        private TextBox tb_UserName;
        private TextBox tb_Email;
        private Label lb_Email;
        private Label lb_age;
        private NumericUpDown tb_numbricAge;
        private TextBox tb_Address;
        private Label lb_Address;
        private Label lb_Role;
        private ComboBox cb_role;
        private Label lb_closeDashBoard;
        private Label lb_RefreshData;
        private TextBox tb_password;
        private Label lb_pssword;
    }
}