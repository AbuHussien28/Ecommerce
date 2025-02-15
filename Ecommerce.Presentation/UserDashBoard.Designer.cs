namespace Ecommerce.Presentation
{
    partial class UserDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashBoard));
            dgview_AllProducts = new DataGridView();
            dgview_FavProduct = new DataGridView();
            lb_UserDashboard = new Label();
            cb_categoryName = new ComboBox();
            btn_AddFav = new Button();
            btn_Refresh = new Button();
            btn_unFav = new Button();
            lb_FavoriteProduct = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lb_Products = new Label();
            ((System.ComponentModel.ISupportInitialize)dgview_AllProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgview_FavProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgview_AllProducts
            // 
            dgview_AllProducts.BackgroundColor = Color.FromArgb(217, 217, 217);
            dgview_AllProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgview_AllProducts.Location = new Point(435, 92);
            dgview_AllProducts.Name = "dgview_AllProducts";
            dgview_AllProducts.Size = new Size(535, 276);
            dgview_AllProducts.TabIndex = 0;
            // 
            // dgview_FavProduct
            // 
            dgview_FavProduct.BackgroundColor = Color.FromArgb(217, 217, 217);
            dgview_FavProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgview_FavProduct.Location = new Point(435, 433);
            dgview_FavProduct.Name = "dgview_FavProduct";
            dgview_FavProduct.Size = new Size(535, 276);
            dgview_FavProduct.TabIndex = 1;
            // 
            // lb_UserDashboard
            // 
            lb_UserDashboard.AutoSize = true;
            lb_UserDashboard.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lb_UserDashboard.ForeColor = Color.FromArgb(50, 74, 133);
            lb_UserDashboard.Location = new Point(97, 12);
            lb_UserDashboard.Name = "lb_UserDashboard";
            lb_UserDashboard.Size = new Size(275, 46);
            lb_UserDashboard.TabIndex = 2;
            lb_UserDashboard.Text = "User DashBoard";
            // 
            // cb_categoryName
            // 
            cb_categoryName.BackColor = Color.FromArgb(174, 195, 214);
            cb_categoryName.Font = new Font("Segoe UI", 18F);
            cb_categoryName.ForeColor = Color.FromArgb(12, 32, 84);
            cb_categoryName.FormattingEnabled = true;
            cb_categoryName.Location = new Point(18, 79);
            cb_categoryName.Name = "cb_categoryName";
            cb_categoryName.Size = new Size(311, 40);
            cb_categoryName.TabIndex = 3;
            // 
            // btn_AddFav
            // 
            btn_AddFav.BackColor = Color.FromArgb(174, 195, 214);
            btn_AddFav.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_AddFav.ForeColor = Color.FromArgb(12, 32, 84);
            btn_AddFav.Location = new Point(19, 130);
            btn_AddFav.Name = "btn_AddFav";
            btn_AddFav.Size = new Size(152, 46);
            btn_AddFav.TabIndex = 4;
            btn_AddFav.Text = "Add To Fav";
            btn_AddFav.UseVisualStyleBackColor = false;
            // 
            // btn_Refresh
            // 
            btn_Refresh.BackColor = Color.FromArgb(174, 195, 214);
            btn_Refresh.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_Refresh.ForeColor = Color.FromArgb(12, 32, 84);
            btn_Refresh.Location = new Point(177, 130);
            btn_Refresh.Name = "btn_Refresh";
            btn_Refresh.Size = new Size(152, 46);
            btn_Refresh.TabIndex = 5;
            btn_Refresh.Text = "Refresh Data";
            btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_unFav
            // 
            btn_unFav.BackColor = Color.FromArgb(174, 195, 214);
            btn_unFav.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_unFav.ForeColor = Color.FromArgb(12, 32, 84);
            btn_unFav.Location = new Point(97, 197);
            btn_unFav.Name = "btn_unFav";
            btn_unFav.Size = new Size(152, 46);
            btn_unFav.TabIndex = 6;
            btn_unFav.Text = "UnFavorite";
            btn_unFav.UseVisualStyleBackColor = false;
            // 
            // lb_FavoriteProduct
            // 
            lb_FavoriteProduct.AutoSize = true;
            lb_FavoriteProduct.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lb_FavoriteProduct.ForeColor = Color.FromArgb(50, 74, 133);
            lb_FavoriteProduct.Location = new Point(436, 385);
            lb_FavoriteProduct.Name = "lb_FavoriteProduct";
            lb_FavoriteProduct.Size = new Size(203, 32);
            lb_FavoriteProduct.TabIndex = 7;
            lb_FavoriteProduct.Text = "Favorite Product";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(870, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lb_Products
            // 
            lb_Products.AutoSize = true;
            lb_Products.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lb_Products.ForeColor = Color.FromArgb(50, 74, 133);
            lb_Products.Location = new Point(435, 47);
            lb_Products.Name = "lb_Products";
            lb_Products.Size = new Size(116, 32);
            lb_Products.TabIndex = 10;
            lb_Products.Text = "Products";
            lb_Products.Click += label1_Click;
            // 
            // UserDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 241, 250);
            ClientSize = new Size(992, 724);
            Controls.Add(lb_Products);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lb_FavoriteProduct);
            Controls.Add(btn_unFav);
            Controls.Add(btn_Refresh);
            Controls.Add(btn_AddFav);
            Controls.Add(cb_categoryName);
            Controls.Add(lb_UserDashboard);
            Controls.Add(dgview_FavProduct);
            Controls.Add(dgview_AllProducts);
            Name = "UserDashBoard";
            Text = "UserDashBoard";
            ((System.ComponentModel.ISupportInitialize)dgview_AllProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgview_FavProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgview_AllProducts;
        private DataGridView dgview_FavProduct;
        private Label lb_UserDashboard;
        private ComboBox cb_categoryName;
        private Button btn_AddFav;
        private Button btn_Refresh;
        private Button btn_unFav;
        private Label lb_FavoriteProduct;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lb_Products;
    }
}