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
    public partial class Form_Products_General : Form
    {
        public Form_Products_General()
        {
            InitializeComponent();
        }

        private void product_categories_Click(object sender, EventArgs e)
        {
            Form categories_general = new Form_Product_Categories_General();
            categories_general.Show();
            this.Close();
        }

        private void products_Click(object sender, EventArgs e)
        {
            Form product_options = new Form_Product_Options();
            product_options.Show();
            this.Close();
        }

        private void menus_Click(object sender, EventArgs e)
        {
            Form back = new Form_Kasa_Giris();
            back.Show();
            this.Close();
        }

        private void anamenu_Click(object sender, EventArgs e)
        {
            Form main_menu = new Form2();
            main_menu.Show();
            this.Close();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form back = new Form_Kasa_Giris();
            back.Show();
            this.Close();
        }
    }
}
