namespace Ecommerce.Presentation
{
    partial class ProductsAdminDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsAdminDashBoard));
            lb_RefreshData = new Label();
            lb_closeDashBoard = new Label();
            cb_Category = new ComboBox();
            lb_Category = new Label();
            lb_ProductPrice = new Label();
            tb_ProductName = new TextBox();
            lb_ProductName = new Label();
            btn_remove = new Button();
            btn_Edit = new Button();
            btn_Add = new Button();
            lb_Operations = new Label();
            productBtn = new Button();
            CategoryBtn = new Button();
            UserBtn = new Button();
            dgv_ProductAdmin = new DataGridView();
            pb_logOut = new PictureBox();
            lb_AdminProductDashboard = new Label();
            profileLinkBtn = new PictureBox();
            tb_numbericPrice = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgv_ProductAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_logOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profileLinkBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tb_numbericPrice).BeginInit();
            SuspendLayout();
            // 
            // lb_RefreshData
            // 
            lb_RefreshData.AutoSize = true;
            lb_RefreshData.BackColor = Color.FromArgb(225, 241, 251);
            lb_RefreshData.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_RefreshData.ForeColor = Color.FromArgb(50, 74, 133);
            lb_RefreshData.Location = new Point(632, 436);
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
            lb_closeDashBoard.Location = new Point(622, 615);
            lb_closeDashBoard.Name = "lb_closeDashBoard";
            lb_closeDashBoard.Size = new Size(86, 21);
            lb_closeDashBoard.TabIndex = 58;
            lb_closeDashBoard.Text = "Close App";
            lb_closeDashBoard.Click += lb_closeDashBoard_Click;
            // 
            // cb_Category
            // 
            cb_Category.BackColor = Color.FromArgb(174, 195, 214);
            cb_Category.ForeColor = Color.FromArgb(50, 74, 133);
            cb_Category.FormattingEnabled = true;
            cb_Category.Items.AddRange(new object[] { "Admin", "User" });
            cb_Category.Location = new Point(445, 584);
            cb_Category.Margin = new Padding(4);
            cb_Category.Name = "cb_Category";
            cb_Category.Size = new Size(264, 23);
            cb_Category.TabIndex = 57;
            // 
            // lb_Category
            // 
            lb_Category.AutoSize = true;
            lb_Category.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_Category.ForeColor = Color.FromArgb(50, 74, 133);
            lb_Category.Location = new Point(315, 586);
            lb_Category.Margin = new Padding(4, 0, 4, 0);
            lb_Category.Name = "lb_Category";
            lb_Category.Size = new Size(80, 21);
            lb_Category.TabIndex = 56;
            lb_Category.Text = "Category";
            // 
            // lb_ProductPrice
            // 
            lb_ProductPrice.AutoSize = true;
            lb_ProductPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_ProductPrice.ForeColor = Color.FromArgb(50, 74, 133);
            lb_ProductPrice.Location = new Point(315, 542);
            lb_ProductPrice.Margin = new Padding(4, 0, 4, 0);
            lb_ProductPrice.Name = "lb_ProductPrice";
            lb_ProductPrice.Size = new Size(112, 21);
            lb_ProductPrice.TabIndex = 48;
            lb_ProductPrice.Text = "Product Price";
            // 
            // tb_ProductName
            // 
            tb_ProductName.BackColor = Color.FromArgb(174, 195, 214);
            tb_ProductName.ForeColor = Color.FromArgb(50, 74, 133);
            tb_ProductName.Location = new Point(444, 483);
            tb_ProductName.Margin = new Padding(4);
            tb_ProductName.Name = "tb_ProductName";
            tb_ProductName.Size = new Size(265, 23);
            tb_ProductName.TabIndex = 47;
            // 
            // lb_ProductName
            // 
            lb_ProductName.AutoSize = true;
            lb_ProductName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_ProductName.ForeColor = Color.FromArgb(50, 74, 133);
            lb_ProductName.Location = new Point(315, 485);
            lb_ProductName.Margin = new Padding(4, 0, 4, 0);
            lb_ProductName.Name = "lb_ProductName";
            lb_ProductName.Size = new Size(120, 21);
            lb_ProductName.TabIndex = 46;
            lb_ProductName.Text = "Product Name";
            // 
            // btn_remove
            // 
            btn_remove.BackColor = Color.FromArgb(174, 195, 214);
            btn_remove.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_remove.ForeColor = Color.FromArgb(12, 32, 84);
            btn_remove.Location = new Point(155, 540);
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
            btn_Edit.Location = new Point(155, 460);
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
            btn_Add.Location = new Point(13, 492);
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
            lb_Operations.Location = new Point(13, 427);
            lb_Operations.Margin = new Padding(4, 0, 4, 0);
            lb_Operations.Name = "lb_Operations";
            lb_Operations.Size = new Size(94, 21);
            lb_Operations.TabIndex = 42;
            lb_Operations.Text = "Operations";
            // 
            // productBtn
            // 
            productBtn.BackColor = Color.White;
            productBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            productBtn.ForeColor = Color.FromArgb(12, 32, 84);
            productBtn.Location = new Point(13, 319);
            productBtn.Margin = new Padding(4);
            productBtn.Name = "productBtn";
            productBtn.Size = new Size(209, 71);
            productBtn.TabIndex = 41;
            productBtn.Text = "Prodcuts";
            productBtn.UseVisualStyleBackColor = false;
            // 
            // CategoryBtn
            // 
            CategoryBtn.BackColor = Color.FromArgb(174, 195, 214);
            CategoryBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CategoryBtn.ForeColor = Color.FromArgb(12, 32, 84);
            CategoryBtn.Location = new Point(13, 222);
            CategoryBtn.Margin = new Padding(4);
            CategoryBtn.Name = "CategoryBtn";
            CategoryBtn.Size = new Size(209, 71);
            CategoryBtn.TabIndex = 40;
            CategoryBtn.Text = "Category ";
            CategoryBtn.UseVisualStyleBackColor = false;
            CategoryBtn.Click += CategoryBtn_Click;
            // 
            // UserBtn
            // 
            UserBtn.BackColor = Color.FromArgb(174, 195, 214);
            UserBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            UserBtn.ForeColor = Color.FromArgb(12, 32, 84);
            UserBtn.Location = new Point(13, 123);
            UserBtn.Margin = new Padding(4);
            UserBtn.Name = "UserBtn";
            UserBtn.Size = new Size(209, 71);
            UserBtn.TabIndex = 39;
            UserBtn.Text = "User";
            UserBtn.UseVisualStyleBackColor = false;
            UserBtn.Click += UserBtn_Click;
            // 
            // dgv_ProductAdmin
            // 
            dgv_ProductAdmin.BackgroundColor = Color.FromArgb(217, 217, 217);
            dgv_ProductAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ProductAdmin.GridColor = Color.Silver;
            dgv_ProductAdmin.Location = new Point(315, 123);
            dgv_ProductAdmin.Margin = new Padding(4);
            dgv_ProductAdmin.Name = "dgv_ProductAdmin";
            dgv_ProductAdmin.Size = new Size(394, 293);
            dgv_ProductAdmin.TabIndex = 38;
            dgv_ProductAdmin.CellContentDoubleClick += dgv_ProductAdmin_CellContentDoubleClick_1;
            // 
            // pb_logOut
            // 
            pb_logOut.Image = (Image)resources.GetObject("pb_logOut.Image");
            pb_logOut.Location = new Point(632, 21);
            pb_logOut.Margin = new Padding(4);
            pb_logOut.Name = "pb_logOut";
            pb_logOut.Size = new Size(143, 70);
            pb_logOut.SizeMode = PictureBoxSizeMode.Zoom;
            pb_logOut.TabIndex = 37;
            pb_logOut.TabStop = false;
            pb_logOut.Click += pb_logOut_Click;
            // 
            // lb_AdminProductDashboard
            // 
            lb_AdminProductDashboard.AutoSize = true;
            lb_AdminProductDashboard.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lb_AdminProductDashboard.ForeColor = Color.FromArgb(50, 74, 133);
            lb_AdminProductDashboard.Location = new Point(149, 24);
            lb_AdminProductDashboard.Margin = new Padding(4, 0, 4, 0);
            lb_AdminProductDashboard.Name = "lb_AdminProductDashboard";
            lb_AdminProductDashboard.Size = new Size(446, 46);
            lb_AdminProductDashboard.TabIndex = 36;
            lb_AdminProductDashboard.Text = "Admin Product DashBoard";
            // 
            // profileLinkBtn
            // 
            profileLinkBtn.Image = (Image)resources.GetObject("profileLinkBtn.Image");
            profileLinkBtn.Location = new Point(13, 21);
            profileLinkBtn.Margin = new Padding(4);
            profileLinkBtn.Name = "profileLinkBtn";
            profileLinkBtn.Size = new Size(103, 67);
            profileLinkBtn.SizeMode = PictureBoxSizeMode.Zoom;
            profileLinkBtn.TabIndex = 35;
            profileLinkBtn.TabStop = false;
            profileLinkBtn.Click += profileLinkBtn_Click;
            // 
            // tb_numbericPrice
            // 
            tb_numbericPrice.BackColor = Color.FromArgb(174, 195, 214);
            tb_numbericPrice.ForeColor = Color.FromArgb(50, 74, 133);
            tb_numbericPrice.Location = new Point(445, 540);
            tb_numbericPrice.Maximum = new decimal(new int[] { 6000000, 0, 0, 0 });
            tb_numbericPrice.Name = "tb_numbericPrice";
            tb_numbericPrice.Size = new Size(263, 23);
            tb_numbericPrice.TabIndex = 60;
            // 
            // ProductsAdminDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 241, 250);
            ClientSize = new Size(799, 724);
            ControlBox = false;
            Controls.Add(tb_numbericPrice);
            Controls.Add(lb_RefreshData);
            Controls.Add(lb_closeDashBoard);
            Controls.Add(cb_Category);
            Controls.Add(lb_Category);
            Controls.Add(lb_ProductPrice);
            Controls.Add(tb_ProductName);
            Controls.Add(lb_ProductName);
            Controls.Add(btn_remove);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Add);
            Controls.Add(lb_Operations);
            Controls.Add(productBtn);
            Controls.Add(CategoryBtn);
            Controls.Add(UserBtn);
            Controls.Add(dgv_ProductAdmin);
            Controls.Add(pb_logOut);
            Controls.Add(lb_AdminProductDashboard);
            Controls.Add(profileLinkBtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ProductsAdminDashBoard";
            Text = "ProductsAdminDashBoard";
            Load += ProductsAdminDashBoard_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_ProductAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_logOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)profileLinkBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)tb_numbericPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_RefreshData;
        private Label lb_closeDashBoard;
        private ComboBox cb_Category;
        private Label lb_Category;
        private Label lb_ProductPrice;
        private TextBox tb_ProductName;
        private Label lb_ProductName;
        private Button btn_remove;
        private Button btn_Edit;
        private Button btn_Add;
        private Label lb_Operations;
        private Button productBtn;
        private Button CategoryBtn;
        private Button UserBtn;
        private DataGridView dgv_ProductAdmin;
        private PictureBox pb_logOut;
        private Label lb_AdminProductDashboard;
        private PictureBox profileLinkBtn;
        private NumericUpDown tb_numbericPrice;
    }
}