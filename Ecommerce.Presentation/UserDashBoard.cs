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
    public partial class UserDashBoard : Form
    {
        Products Products;
        Categories GetCategories;
        Favorites Favorites;
        private string userName;
        int categoryId;
        bool chooseCategory = false;
        public UserDashBoard(string UserName)
        {
            InitializeComponent();
            Products = new Products(ConfigurationManager.ConnectionStrings["Ecommrce"].ConnectionString);
            GetCategories = new Categories(ConfigurationManager.ConnectionStrings["Ecommrce"].ConnectionString);
            Favorites = new Favorites(ConfigurationManager.ConnectionStrings["Ecommrce"].ConnectionString);
            userName = UserName;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserDashBoard_Load(object sender, EventArgs e)
        {
            DataTable GetAllProduct = Products.getAllProduct();
            dgview_AllProducts.DataSource = GetAllProduct;
            dgview_AllProducts.Columns["ProductId"].Visible = false;
            DataTable categories = GetCategories.GetCategoryId();
            cb_categoryName.DataSource = categories;
            cb_categoryName.DisplayMember = "CategoryName";
            cb_categoryName.ValueMember = "CategoryId";
            DataTable getFav = Favorites.GetFavProduct(userName);
            dgview_FavProduct.DataSource = getFav;
            dgview_FavProduct.Columns["ProductId"].Visible = false;

        }

        private void cb_categoryName_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cb_categoryName.SelectedValue is DataRowView rowView)
            {
                categoryId = Convert.ToInt32(rowView["CategoryID"]);
            }
            else if (cb_categoryName.SelectedValue != null)
            {
                categoryId = Convert.ToInt32(cb_categoryName.SelectedValue);
                DataTable getProduct = Products.getByProduct(categoryId);
                dgview_AllProducts.DataSource = getProduct;
                dgview_AllProducts.Columns["ProductId"].Visible = false;
                DataTable getFavProductFromCategory = Favorites.GetFavProductByCategory(userName, categoryId);
                dgview_FavProduct.DataSource = getFavProductFromCategory;
                chooseCategory = true;
            }
        }

        private void btn_AddFav_Click(object sender, EventArgs e)
        {
            if (dgview_AllProducts.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(dgview_AllProducts.SelectedRows[0].Cells["ProductId"].Value);
                string productName = dgview_AllProducts.SelectedRows[0].Cells["ProductName"].Value.ToString();
                bool addedItem = Favorites.AddToFavorites(userName, productId);
                if (addedItem)
                {
                    MessageBox.Show($"Added Product {productName} success", "Added Item", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Information);
                    RefreshFavorites();
                }
                else
                    MessageBox.Show($" Product {productName} Is Alredy Added", "Added before", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);

            }
            else
                MessageBox.Show($" Please select Product First", "select item", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Warning);

        }
        private void RefreshFavorites()
        {
            if (chooseCategory)
            {
                DataTable getFav = Favorites.GetFavProduct(userName);
                dgview_FavProduct.DataSource = getFav;
            }
            DataTable getFavProductFromCategory = Favorites.GetFavProductByCategory(userName, categoryId);
            dgview_FavProduct.DataSource = getFavProductFromCategory;
        }

        private void btn_unFav_Click(object sender, EventArgs e)
        {

            if (dgview_FavProduct.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(dgview_FavProduct.SelectedRows[0].Cells["ProductId"].Value);
                string productName = dgview_FavProduct.SelectedRows[0].Cells["ProductName"].Value.ToString();
                bool addedItem = Favorites.DeleteFromFav(userName, productId);
                if (addedItem)
                {
                    MessageBox.Show($"delete Product {productName} success", "Delete Item", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Information);
                    RefreshFavorites();
                }
            }
            else
                MessageBox.Show($" Please select Product First", "select item", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Warning);
        }

        private void lb_UserDashBorad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
