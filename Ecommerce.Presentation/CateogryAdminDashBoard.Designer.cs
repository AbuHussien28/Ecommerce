namespace Ecommerce.Presentation
{
    partial class CateogryAdminDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CateogryAdminDashBoard));
            lb_RefreshData = new Label();
            lb_closeDashBoard = new Label();
            tb_categoryName = new TextBox();
            lb_Category = new Label();
            btn_remove = new Button();
            btn_Edit = new Button();
            btn_Add = new Button();
            lb_Operations = new Label();
            productBtn = new Button();
            CategoryBtn = new Button();
            UserBtn = new Button();
            dgv_CategoryAdmin = new DataGridView();
            pb_logOut = new PictureBox();
            lb_AdminCategoryDashboard = new Label();
            profileLinkBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_CategoryAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_logOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profileLinkBtn).BeginInit();
            SuspendLayout();
            // 
            // lb_RefreshData
            // 
            lb_RefreshData.AutoSize = true;
            lb_RefreshData.BackColor = Color.FromArgb(225, 241, 251);
            lb_RefreshData.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_RefreshData.ForeColor = Color.FromArgb(50, 74, 133);
            lb_RefreshData.Location = new Point(618, 385);
            lb_RefreshData.Name = "lb_RefreshData";
            lb_RefreshData.Size = new Size(76, 21);
            lb_RefreshData.TabIndex = 59;
            lb_RefreshData.Text = "Get Data";
            lb_RefreshData.Click += lb_RefreshData_Click;
            // 
            // lb_closeDashBoard
            // 
            lb_closeDashBoard.AutoSize = true;
            lb_closeDashBoard.BackColor = Color.FromArgb(225, 241, 251);
            lb_closeDashBoard.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_closeDashBoard.ForeColor = Color.FromArgb(50, 74, 133);
            lb_closeDashBoard.Location = new Point(608, 565);
            lb_closeDashBoard.Name = "lb_closeDashBoard";
            lb_closeDashBoard.Size = new Size(86, 21);
            lb_closeDashBoard.TabIndex = 58;
            lb_closeDashBoard.Text = "Close App";
            lb_closeDashBoard.Click += lb_closeDashBoard_Click;
            // 
            // tb_categoryName
            // 
            tb_categoryName.ForeColor = Color.FromArgb(50, 74, 133);
            tb_categoryName.Location = new Point(495, 465);
            tb_categoryName.Margin = new Padding(4);
            tb_categoryName.Name = "tb_categoryName";
            tb_categoryName.Size = new Size(114, 23);
            tb_categoryName.TabIndex = 47;
            // 
            // lb_Category
            // 
            lb_Category.AutoSize = true;
            lb_Category.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_Category.ForeColor = Color.FromArgb(50, 74, 133);
            lb_Category.Location = new Point(343, 467);
            lb_Category.Margin = new Padding(4, 0, 4, 0);
            lb_Category.Name = "lb_Category";
            lb_Category.Size = new Size(130, 21);
            lb_Category.TabIndex = 46;
            lb_Category.Text = "Category Name";
            // 
            // btn_remove
            // 
            btn_remove.BackColor = Color.FromArgb(174, 195, 214);
            btn_remove.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_remove.ForeColor = Color.FromArgb(12, 32, 84);
            btn_remove.Location = new Point(102, 540);
            btn_remove.Margin = new Padding(4);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(134, 71);
            btn_remove.TabIndex = 45;
            btn_remove.Text = "Remove";
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.BackColor = Color.FromArgb(174, 195, 214);
            btn_Edit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Edit.ForeColor = Color.FromArgb(12, 32, 84);
            btn_Edit.Location = new Point(182, 452);
            btn_Edit.Margin = new Padding(4);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(134, 71);
            btn_Edit.TabIndex = 44;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.FromArgb(174, 195, 214);
            btn_Add.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Add.ForeColor = Color.FromArgb(12, 32, 84);
            btn_Add.Location = new Point(27, 452);
            btn_Add.Margin = new Padding(4);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(134, 71);
            btn_Add.TabIndex = 43;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // lb_Operations
            // 
            lb_Operations.AutoSize = true;
            lb_Operations.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_Operations.ForeColor = Color.FromArgb(50, 74, 133);
            lb_Operations.Location = new Point(27, 419);
            lb_Operations.Margin = new Padding(4, 0, 4, 0);
            lb_Operations.Name = "lb_Operations";
            lb_Operations.Size = new Size(94, 21);
            lb_Operations.TabIndex = 42;
            lb_Operations.Text = "Operations";
            // 
            // productBtn
            // 
            productBtn.BackColor = Color.FromArgb(174, 195, 214);
            productBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            productBtn.ForeColor = Color.FromArgb(12, 32, 84);
            productBtn.Location = new Point(27, 311);
            productBtn.Margin = new Padding(4);
            productBtn.Name = "productBtn";
            productBtn.Size = new Size(209, 71);
            productBtn.TabIndex = 41;
            productBtn.Text = "Prodcuts";
            productBtn.UseVisualStyleBackColor = false;
            productBtn.Click += productBtn_Click;
            // 
            // CategoryBtn
            // 
            CategoryBtn.BackColor = Color.White;
            CategoryBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CategoryBtn.ForeColor = Color.FromArgb(12, 32, 84);
            CategoryBtn.Location = new Point(27, 214);
            CategoryBtn.Margin = new Padding(4);
            CategoryBtn.Name = "CategoryBtn";
            CategoryBtn.Size = new Size(209, 71);
            CategoryBtn.TabIndex = 40;
            CategoryBtn.Text = "Category ";
            CategoryBtn.UseVisualStyleBackColor = false;
            // 
            // UserBtn
            // 
            UserBtn.BackColor = Color.FromArgb(174, 195, 214);
            UserBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            UserBtn.ForeColor = Color.FromArgb(12, 32, 84);
            UserBtn.Location = new Point(27, 115);
            UserBtn.Margin = new Padding(4);
            UserBtn.Name = "UserBtn";
            UserBtn.Size = new Size(209, 71);
            UserBtn.TabIndex = 39;
            UserBtn.Text = "User";
            UserBtn.UseVisualStyleBackColor = false;
            UserBtn.Click += UserBtn_Click;
            // 
            // dgv_CategoryAdmin
            // 
            dgv_CategoryAdmin.BackgroundColor = Color.FromArgb(217, 217, 217);
            dgv_CategoryAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_CategoryAdmin.GridColor = Color.Silver;
            dgv_CategoryAdmin.Location = new Point(317, 115);
            dgv_CategoryAdmin.Margin = new Padding(4);
            dgv_CategoryAdmin.Name = "dgv_CategoryAdmin";
            dgv_CategoryAdmin.Size = new Size(272, 267);
            dgv_CategoryAdmin.TabIndex = 38;
            dgv_CategoryAdmin.CellDoubleClick += dgv_CategoryAdmin_CellDoubleClick;
            // 
            // pb_logOut
            // 
            pb_logOut.Image = (Image)resources.GetObject("pb_logOut.Image");
            pb_logOut.Location = new Point(635, 10);
            pb_logOut.Margin = new Padding(4);
            pb_logOut.Name = "pb_logOut";
            pb_logOut.Size = new Size(143, 70);
            pb_logOut.SizeMode = PictureBoxSizeMode.Zoom;
            pb_logOut.TabIndex = 37;
            pb_logOut.TabStop = false;
            pb_logOut.Click += pb_logOut_Click;
            // 
            // lb_AdminCategoryDashboard
            // 
            lb_AdminCategoryDashboard.AutoSize = true;
            lb_AdminCategoryDashboard.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lb_AdminCategoryDashboard.ForeColor = Color.FromArgb(50, 74, 133);
            lb_AdminCategoryDashboard.Location = new Point(163, 16);
            lb_AdminCategoryDashboard.Margin = new Padding(4, 0, 4, 0);
            lb_AdminCategoryDashboard.Name = "lb_AdminCategoryDashboard";
            lb_AdminCategoryDashboard.Size = new Size(464, 46);
            lb_AdminCategoryDashboard.TabIndex = 36;
            lb_AdminCategoryDashboard.Text = "Admin Category DashBoard";
            // 
            // profileLinkBtn
            // 
            profileLinkBtn.Image = (Image)resources.GetObject("profileLinkBtn.Image");
            profileLinkBtn.Location = new Point(27, 13);
            profileLinkBtn.Margin = new Padding(4);
            profileLinkBtn.Name = "profileLinkBtn";
            profileLinkBtn.Size = new Size(103, 67);
            profileLinkBtn.SizeMode = PictureBoxSizeMode.Zoom;
            profileLinkBtn.TabIndex = 35;
            profileLinkBtn.TabStop = false;
            profileLinkBtn.Click += profileLinkBtn_Click;
            // 
            // CateogryAdminDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 241, 251);
            ClientSize = new Size(827, 620);
            ControlBox = false;
            Controls.Add(lb_RefreshData);
            Controls.Add(lb_closeDashBoard);
            Controls.Add(tb_categoryName);
            Controls.Add(lb_Category);
            Controls.Add(btn_remove);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Add);
            Controls.Add(lb_Operations);
            Controls.Add(productBtn);
            Controls.Add(CategoryBtn);
            Controls.Add(UserBtn);
            Controls.Add(dgv_CategoryAdmin);
            Controls.Add(pb_logOut);
            Controls.Add(lb_AdminCategoryDashboard);
            Controls.Add(profileLinkBtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CateogryAdminDashBoard";
            Text = "CateogryAdminDashBoard";
            Load += CateogryAdminDashBoard_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_CategoryAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_logOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)profileLinkBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_RefreshData;
        private Label lb_closeDashBoard;
        private ComboBox cb_role;
        private Label lb_Role;
        private TextBox tb_Address;
        private Label lb_Address;
        private NumericUpDown tb_numbricAge;
        private Label lb_age;
        private TextBox tb_Email;
        private Label lb_Email;
        private TextBox tb_password;
        private Label lb_password;
        private TextBox tb_categoryName;
        private Label lb_Category;
        private Button btn_remove;
        private Button btn_Edit;
        private Button btn_Add;
        private Label lb_Operations;
        private Button productBtn;
        private Button CategoryBtn;
        private Button UserBtn;
        private DataGridView dgv_CategoryAdmin;
        private PictureBox pb_logOut;
        private Label lb_AdminCategoryDashboard;
        private PictureBox profileLinkBtn;
    }
}