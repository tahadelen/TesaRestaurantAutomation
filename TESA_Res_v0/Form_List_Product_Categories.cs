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
    public partial class Form_List_Product_Categories : Form
    {
        public tesaresdbEntities dbe = new tesaresdbEntities();
        public List<Product_Categories_Table> productCategoreis;
        private int categoriesCount;
        public Form_List_Product_Categories()
        {
            InitializeComponent();

            categoriesCount = dbe.Product_Categories_Table.Count();
            productCategoreis = (from fl in dbe.Product_Categories_Table select fl).ToList();

            int top = 50;
            int left = 100;

            for (int i = 0; i < categoriesCount; i++)
            {
                Button button = new Button();
                button.Height = 50;
                button.Width = 100;
                button.Text = productCategoreis.ElementAt(i).productName;
                Image pImage = (Bitmap)((new ImageConverter()).ConvertFrom(productCategoreis.ElementAt(i).productImage));
                button.BackgroundImageLayout = ImageLayout.Stretch;
                button.BackgroundImage = pImage;
                button.Left = left;
                button.Top = top;
                button.BackColor = Color.White;
                this.Controls.Add(button);
                top += button.Height + 2;
            }
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form back_menu = new Form_Kasa_Giris();
            back_menu.Show();
            this.Close();
        }

        private void anamenu_Click(object sender, EventArgs e)
        {
            Form main_menu = new Form2();
            main_menu.Show();
            this.Close();
        }

        private void geri_Click_1(object sender, EventArgs e)
        {
            Form back_menu = new Form_Product_Categories_General();
            back_menu.Show();
            this.Close();
        }
    }
}
