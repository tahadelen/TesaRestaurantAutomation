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
    public partial class Form_ProductCategory_Edit : Form
    {
        public Form_ProductCategory_Edit()
        {
            InitializeComponent();
            tesaresdbEntities dbe = new tesaresdbEntities();

            product_category_list.DataSource = (from ct in dbe.Product_Categories_Table
                                           select new
                                           {
                                               Id = ct.productID,
                                               Name = ct.productName,
                                               Ord = ct.productDescription

                                           }).ToList();
            product_category_list.ColumnHeadersHeight = 35;
            product_category_list.RowTemplate.Height = 35;
            product_category_list.Columns[0].HeaderText = "Kategori Numarası";
            product_category_list.Columns[0].Width = 50;
            product_category_list.Columns[1].HeaderText = "Kategori Adı";
            product_category_list.Columns[1].Width = 200;
            product_category_list.Columns[2].HeaderText = "Kategori açıklama";
            product_category_list.Columns[2].Width = 200;
        

            product_category_list.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            product_category_list.MultiSelect = false;
        }

        private void edit_Click(object sender, EventArgs e)
        {

            tesaresdbEntities dbe = new tesaresdbEntities();

            if (product_category_list.SelectedRows == null)
                return;

            DataGridViewRow row = product_category_list.SelectedRows[0];
            int iId = int.Parse(row.Cells[0].Value.ToString());

            Product_Categories_Table selected = (from pr_cat in dbe.Product_Categories_Table
                                                 where iId == pr_cat.productID
                                  select pr_cat).First();

            Form form_edit_item = new Form_CategoryItem_Edit(selected);
            form_edit_item.Show();
            this.Close();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form back = new Form_Product_Categories_General();
            back.Show();
            this.Close();
        }

        private void anamenu_Click(object sender, EventArgs e)
        {
            Form form_main = new Form2();
            form_main.Show();
            this.Close();
        }
    }
}
