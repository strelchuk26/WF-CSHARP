using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop_forms
{
    public partial class ShopForm : Form
    {
        List<Product> products = new List<Product>();

        public ShopForm()
        {
            InitializeComponent();
        }

		private void UpdateList()
        {
            productsList.DataSource = null;
            productsList.DataSource = products;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm("ADD");
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                products.Add(form.Product);
                UpdateList();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (productsList.SelectedItem == null!)
            {
                MessageBox.Show("Select product to remove!");
                return;
            }

            var item = productsList.SelectedItem as Product;

            products.Remove(item);
            UpdateList();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (productsList.SelectedItem == null!)
            {
                MessageBox.Show("Select product to edit!");
                return;
            }

            var product = productsList.SelectedItem as Product;
            ProductForm form = new ProductForm("EDIT", product);

            form.ShowDialog();
            UpdateList();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm("SHOW");
            var product = productsList.SelectedItem as Product;
            form.ShowMode(product);
        }
    }
}
