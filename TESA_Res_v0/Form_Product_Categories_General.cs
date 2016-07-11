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
    public partial class Form_Product_Categories_General : Form
    {
        public Form_Product_Categories_General()
        {
            InitializeComponent();
        }

        private void anamenu_Click(object sender, EventArgs e)
        {
            Form main_menu = new Form2();
            main_menu.Show();
            this.Close();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form back = new Form_Products_General();
            back.Show();
            this.Close();
        }

        private void show_categories_Click(object sender, EventArgs e)
        {
            Form product_categories_List = new Form_List_Product_Categories();
            product_categories_List.Show();
            this.Close();
        }

        private void add_category_Click(object sender, EventArgs e)
        {
            Form add_category = new Form_Add_Category();
            add_category.Show();
            this.Close();
        }

        private void delete_category_Click(object sender, EventArgs e)
        {
            Form remove_cat = new Form_Remove_ProductCategory();
            remove_cat.Show();
            this.Close();


        }

        private void change_category_Click(object sender, EventArgs e)
        {
            Form cat_edit = new Form_ProductCategory_Edit();
            cat_edit.Show();
            this.Close();
        }
    }
}
