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
    public partial class Form_Add_Category : Form
    {
        private OpenFileDialog dlg = new OpenFileDialog();

        public Form_Add_Category()
        {
            InitializeComponent();
        }

        private void anamenu_Click(object sender, EventArgs e)
        {
            Form main_screen = new Form2();
            main_screen.Show();
            this.Close();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form backScreen = new Form_Product_Categories_General();
            backScreen.Show();
            this.Close();
        }

        private void select_image_Click(object sender, EventArgs e)
        {
            dlg.Title = "Open Image";
            dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                category_image.SizeMode = PictureBoxSizeMode.Zoom;

                category_image.Image = Image.FromFile(dlg.FileName);
            }
            dlg.Dispose();
        }

        private void add_category_Click(object sender, EventArgs e)
        {

        }

      
        private void save_Click(object sender, EventArgs e)
        {
            tesaresdbEntities dbe = new tesaresdbEntities();
            Product_Categories_Table item = new Product_Categories_Table();

            item.productName = category_name.Text;
            item.productDescription = category_description.Text;
            byte[] bytes = System.IO.File.ReadAllBytes(dlg.FileName);

            item.productImage = bytes;
            dbe.Product_Categories_Table.Add(item);
            dbe.SaveChanges();

            Form form_product_categories = new Form_Product_Categories_General();
            form_product_categories.Show();
            this.Close();
        }
    }
}
