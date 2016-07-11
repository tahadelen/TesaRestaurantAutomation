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
    public partial class Form_Add_New_Product : Form
    {
        private OpenFileDialog dlg = new OpenFileDialog();

        public Form_Add_New_Product()
        {
            InitializeComponent();
            tesaresdbEntities dbe = new tesaresdbEntities();
            List<Product_Categories_Table> dataList = (from a in dbe.Product_Categories_Table
                                                       orderby a.productID ascending
                                           select a).ToList();

            product_cat_combo.DataSource = dataList;
            product_cat_combo.DisplayMember = "productName";
            product_cat_combo.ValueMember = "productID";
            product_cat_combo.SelectedIndexChanged += new EventHandler(product_cat_combo_SelectedIndexChanged);
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Form back = new Form_Product_Options();
            back.Show();
            this.Close();
        }

        private void product_cat_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void select_image_Click(object sender, EventArgs e)
        {
            dlg.Title = "Open Image";
            dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                productImage.SizeMode = PictureBoxSizeMode.Zoom;
                
                productImage.Image = Image.FromFile(dlg.FileName);
            }
            dlg.Dispose();
        }

        private void add_product_Click(object sender, EventArgs e)
        {
            
            tesaresdbEntities dbe = new tesaresdbEntities();
            Product_Product item = new Product_Product();

            int cat_id = (int)product_cat_combo.SelectedValue;

            item.productName = tb_product_name.Text;
            item.productPrepPlace = prepPlace.Text;
            item.productPrepTime = Int32.Parse(prepTime.Text);
            item.productCat = cat_id;

            byte[] bytes = System.IO.File.ReadAllBytes(dlg.FileName);
            item.productImage = bytes;
            dbe.Product_Product.Add(item);
            dbe.SaveChanges();

            Form form_product_categories = new Form_Product_Categories_General();
            form_product_categories.Show();
            this.Close();
            
        }

        private void mainmenu_Click(object sender, EventArgs e)
        {
            Form main = new Form2();
            main.Show();
            this.Close();
        }
    }
}
