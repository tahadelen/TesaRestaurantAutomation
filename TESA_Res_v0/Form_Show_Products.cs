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
    public partial class Form_Show_Products : Form
    {
        public tesaresdbEntities dbe = new tesaresdbEntities();
        public List<Product_Product> products;
        private int productCount;
        Button[] btn;
        private int top;
        private int left;
        public Form_Show_Products(Boolean isRemove)
        {
            InitializeComponent();


            if(!isRemove)
            remove.Hide();



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

        private void SomeMethod(Button btn, int index) {

            Button b = (Button)btn;
            int num = (int)b.Tag;

            Product_Product selected = (from stock in dbe.Product_Product
                                        where num == stock.productID
                                        select stock).First();

            DialogResult dr = MessageBox.Show("Kod: " + selected.productID + Environment.NewLine + "ürün Adı: " + selected.productName + Environment.NewLine + "olan ürünü silmek istediğinize emin misiniz?",
                    "Silme İşlemi Onay", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:

                    dbe.Product_Product.Remove(selected);
                    dbe.SaveChanges();

                    Form main = new Form_Show_Products(true);
                    main.Show();
                    this.Close();
                    break;
                case DialogResult.No: break;
            }
  }

        private void category_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void show_Click(object sender, EventArgs e)
        {
            int cat_id = (int)category_combobox.SelectedValue;

            foreach (Button bt in btn)
                bt.Hide();

            List<Product_Product> dataList = (from a in dbe.Product_Product
                                              where cat_id == a.productCat
                                              select a).ToList();

            productCount = dataList.Count;
            btn = new Button[productCount];

            top = 100;
            left = 100;

            for (int i = 0; i < productCount; i++)
            {
                btn[i] = new Button();
                btn[i].Height = 50;
                btn[i].Width = 100;
                btn[i].Text = dataList.ElementAt(i).productName;
                Image pImage = (Bitmap)((new ImageConverter()).ConvertFrom(dataList.ElementAt(i).productImage));
                btn[i].BackgroundImageLayout = ImageLayout.Stretch;
                btn[i].BackgroundImage = pImage;
                btn[i].Left = left;
                btn[i].Top = top;
                btn[i].BackColor = Color.White;
                this.Controls.Add(btn[i]);
                top += btn[i].Height + 2;
               
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form back = new Form_Product_Options();
            back.Show();
            this.Close();
        }

        

        private void main_Click(object sender, EventArgs e)
        {
            Form main = new Form2();
            main.Show();
            this.Close();
        }

        private void remove_Click(object sender, EventArgs e)
        {

        }
    }
}
