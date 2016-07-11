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
    public partial class Form_Remove_ProductCategory : Form
    {
        public Form_Remove_ProductCategory()
        {
            InitializeComponent();
            tesaresdbEntities dbe = new tesaresdbEntities();

            product_category.DataSource = (from ct in dbe.Product_Categories_Table
                                        select new
                                        {
                                            Id = ct.productID,
                                            Name = ct.productName,
                                            Ord = ct.productDescription

                                        }).ToList();
            product_category.ColumnHeadersHeight = 35;
            product_category.RowTemplate.Height = 35;
            product_category.Columns[0].HeaderText = "Kategori Numarası";
            product_category.Columns[0].Width = 50;
            product_category.Columns[1].HeaderText = "Kategori Adı";
            product_category.Columns[1].Width = 200;
            product_category.Columns[2].HeaderText = "Kategori açıklama";
            product_category.Columns[2].Width = 200;


            product_category.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            product_category.MultiSelect = false;
        }

        private void remove_Click(object sender, EventArgs e)
        {

            tesaresdbEntities dbe = new tesaresdbEntities();

            if (product_category.SelectedRows == null)
                return;

            DataGridViewRow row = product_category.SelectedRows[0];
            int iId = int.Parse(row.Cells[0].Value.ToString());

            Product_Categories_Table selected = (from stock in dbe.Product_Categories_Table
                                  where iId == stock.productID
                                  select stock).First();

           

            dbe.Product_Categories_Table.Remove(selected);
            dbe.SaveChanges();


            Form categories_general = new Form_Product_Categories_General();
            categories_general.Show();
            this.Close();


        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form categories_general = new Form_Product_Categories_General();
            categories_general.Show();
            this.Close();
        }

        private void anamenu_Click(object sender, EventArgs e)
        {
            Form main_form = new Form2();
            main_form.Show();
            this.Close();

        }
    }
}
