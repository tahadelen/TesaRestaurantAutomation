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
    public partial class Form_Edit_Product_Item : Form
    {
        private Product_Product selected;
        private OpenFileDialog dlg = new OpenFileDialog();

        public Form_Edit_Product_Item(Product_Product product)
        {
            InitializeComponent();
            this.selected = product;
            tb_product_name.Text = selected.productName;
            prepTime.Text = selected.productPrepTime.ToString();
            product_price.Text = selected.productPrice.ToString();
            Image image = (Bitmap)((new ImageConverter()).ConvertFrom(selected.productImage));

            productImage.Image = image;



            tesaresdbEntities dbe = new tesaresdbEntities();
            List<Product_Categories_Table> dataList = (from a in dbe.Product_Categories_Table
                                                       orderby a.productID ascending
                                                       select a).ToList();

            product_cat_combo.DataSource = dataList;
            product_cat_combo.DisplayMember = "productName";
            product_cat_combo.ValueMember = "productID";
            product_cat_combo.SelectedIndexChanged += new EventHandler(product_cat_combo_SelectedIndexChanged);

            product_cat_combo.SelectedValue = selected.productID;


        }

        private void edit_product_Click(object sender, EventArgs e)
        {
            tesaresdbEntities dbe = new tesaresdbEntities();

            Product_Product product_cat = (from it in dbe.Product_Product
                                           where selected.productID == it.productID
                                                    select it).First();

            int cat_id = (int)product_cat_combo.SelectedValue;

            product_cat.productName = tb_product_name.Text;
            product_cat.productPrepTime = Int32.Parse(prepTime.Text);
            product_cat.productCat = cat_id;

             
            byte[] bytes = System.IO.File.ReadAllBytes(dlg.FileName);

            product_cat.productImage = bytes;
            dbe.SaveChanges();

            Form backScreen = new Form_Product_Categories_General();
            backScreen.Show();
            this.Close();
        }

        private void prepİngre_Click(object sender, EventArgs e)
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

        private void backbutton_Click(object sender, EventArgs e)
        {
            Form main_screen = new Form2();
            main_screen.Show();
            this.Close();
        }

        private void mainmenu_Click(object sender, EventArgs e)
        {

        }

        private void product_cat_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
