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
    public partial class Form_Add_Product : Form
    {
        public Form_Add_Product()
        {
            InitializeComponent();
            tesaresdbEntities dbe = new tesaresdbEntities();
            List<CategoryTable> catTableList = (from ct in dbe.CategoryTable select ct).ToList();
            List<RecipeTable> rTableList = (from rt in dbe.RecipeTable select rt).ToList();

            CategoryTable ctNull = new CategoryTable();
            ctNull.CatId = -1;
            ctNull.CatName = "Seçiniz";
            catTableList.Insert(0, ctNull);

            RecipeTable rNull = new RecipeTable();
            rNull.RecId = -1;
            rNull.RecIngredients = " ";
            rNull.RecName = "Seçiniz";
            rTableList.Insert(0, rNull);

            cb_cat_id.DataSource = catTableList;
            cb_cat_id.DisplayMember = "CatName";
            cb_cat_id.ValueMember = "CatId";

            cb_recipe_id.DataSource = rTableList;
            cb_recipe_id.DisplayMember = "RecName";
            cb_recipe_id.ValueMember = "RecId";

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form form_main = new Form2();
            form_main.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int catId, rId;
            string name;
            double cost;

            name = tb_product_name.Text;
            catId = (int) cb_cat_id.SelectedValue;
            rId = (int) cb_recipe_id.SelectedValue;
            cost = (double) n_cost.Value;

            if(name != "" && catId>0 && rId>0 && cost>0)
            {
                ProductTable pt = new ProductTable();
                pt.ProductName = name;
                pt.CatId = catId;
                pt.RecipeId = rId;
                pt.ProductDetails = name;
                pt.ProCost = cost;

                tesaresdbEntities dbe = new tesaresdbEntities();
                dbe.ProductTable.Add(pt);
                dbe.SaveChanges();
            } else
            {
                lbl_warn.Text = "* Lütfen eksik alanları doldurunuz.";
            }
            Form form_main = new Form2();
            form_main.Show();
            this.Close();
        }
    }
}
