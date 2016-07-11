using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TESA_Res_v0
{
    public partial class Form_Product_Options : Form
    {
        public Form_Product_Options()
        {
            InitializeComponent();
        }

        private void show_products_Click(object sender, EventArgs e)
        {
            Form form_show_Products = new Form_Show_Products(false);
            form_show_Products.Show();
            this.Close();
        }

        private void add_product_Click(object sender, EventArgs e)
        {
            Form form_add_newProduct = new Form_Add_New_Product();
            form_add_newProduct.Show();
            this.Close();
        }

        private void remove_product_Click(object sender, EventArgs e)
        {
            Form form_show_Products = new Form_Show_Products(true);
            form_show_Products.Show();
            this.Close();
        }

        private void edit_product_Click(object sender, EventArgs e)
        {
            Form form_show_Products = new Form_Product_Edit();
            form_show_Products.Show();
            this.Close();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form back = new Form_Products_General();
            back.Show();
            this.Close();
        }

        private void anamenu_Click(object sender, EventArgs e)
        {
            Form main_menu = new Form2();
            main_menu.Show();
            this.Close();
        }
    }
}
