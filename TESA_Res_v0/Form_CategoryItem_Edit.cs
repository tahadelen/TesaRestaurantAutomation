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
    public partial class Form_CategoryItem_Edit : Form
    {
        private Product_Categories_Table tableItem;
        private OpenFileDialog dlg = new OpenFileDialog();

        public Form_CategoryItem_Edit(Product_Categories_Table itemSelected)
        {
            InitializeComponent();
            this.tableItem = itemSelected;
            category_name.Text = tableItem.productName;
            category_desc.Text = tableItem.productDescription;
            
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

        private void save_Click(object sender, EventArgs e)
        {
            tesaresdbEntities dbe = new tesaresdbEntities();

            Product_Categories_Table product_cat = (from it in dbe.Product_Categories_Table
                                            where tableItem.productID == it.productID
                             select it).First();

            product_cat.productName = category_name.Text;
            product_cat.productDescription = category_desc.Text;
            byte[] bytes = System.IO.File.ReadAllBytes(dlg.FileName);

            product_cat.productImage = bytes;
            dbe.SaveChanges();

            Form backScreen = new Form_Product_Categories_General();
            backScreen.Show();
            this.Close();

        }

        private void edit_category_Click(object sender, EventArgs e)
        {

        }
    }
}
