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
    public partial class Form_Product_Edit : Form
    {
        public tesaresdbEntities dbe = new tesaresdbEntities();
        public List<Product_Product> products;
        private int productCount;
        Button[] btn;
        private int top;
        private int left;
        public Form_Product_Edit()
        {
            InitializeComponent();
            tesaresdbEntities dbe = new tesaresdbEntities();
            List<Product_Categories_Table> dataList = (from a in dbe.Product_Categories_Table
                                                       orderby a.productID ascending
                                                       select a).ToList();


            category_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            category_combobox.DataSource = dataList;
            category_combobox.DisplayMember = "productName";
            category_combobox.ValueMember = "productID";
            category_combobox.SelectedIndexChanged += new EventHandler(category_combobox_SelectedIndexChanged);


            productCount = dbe.Product_Product.Count();
            products = (from fl in dbe.Product_Product select fl).ToList();
            btn = new Button[productCount];

            top = 100;
            left = 100;

            for (int i = 0; i < productCount; i++)
            {
                btn[i] = new Button();
                btn[i].Height = 50;
                btn[i].Width = 100;
                btn[i].Text = products.ElementAt(i).productName;
                btn[i].Tag = products.ElementAt(i).productID;
                Image pImage = (Bitmap)((new ImageConverter()).ConvertFrom(products.ElementAt(i).productImage));
                btn[i].BackgroundImageLayout = ImageLayout.Stretch;
                btn[i].BackgroundImage = pImage;
                btn[i].Left = left;
                btn[i].Top = top;
                btn[i].BackColor = Color.White;
                this.Controls.Add(btn[i]);
                top += btn[i].Height + 2;

            }
            for (int i = 0; i < productCount; i++)
            {
                //it's important to have this; closing over the loop variable would be bad
                int index = i;
                btn[i].Click += (sender, args) => SomeMethod(btn[index], index);
            }
        }
        private void SomeMethod(Button btn, int index)
        {

            Button b = (Button)btn;
            int num = (int)b.Tag;

            Product_Product selected = (from stock in dbe.Product_Product
                                        where num == stock.productID
                                        select stock).First();

            DialogResult dr = MessageBox.Show("Kod: " + selected.productID + Environment.NewLine + "ürün Adı: " + selected.productName + Environment.NewLine + "olan ürünü değiştirmek istediğinize emin misiniz?",
                    "Silme İşlemi Onay", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:

                    Form form_edit_item = new Form_Edit_Product_Item(selected);
                    form_edit_item.Show();
                    this.Close();


                    break;
                case DialogResult.No: break;
            }
        }

        private void category_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form back = new Form_Product_Options();
            back.Show();
            this.Close();
        }

        private void anamenu_Click(object sender, EventArgs e)
        {
            Form main = new Form2();
            main.Show();
            this.Close();
        }
    }
}
