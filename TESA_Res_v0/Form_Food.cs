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
    public partial class Form_Food : Form
    {
        private List<ItemTable> dataList;

        public Form_Food()
        {
            InitializeComponent();
            //cb_2.Enabled = cb_3.Enabled = false;

            tesaresdbEntities dbe = new tesaresdbEntities();
            dataList = (from a in dbe.ItemTable
                                         orderby a.ItemId ascending
                                         select a).ToList();

            
            ItemTable itemNull = new ItemTable();
            itemNull.ItemUnit = "Kg/Adet";
            itemNull.ItemExists = 0;
            itemNull.ItemId = -1;
            itemNull.ItemName = "Seçiniz";
            dataList.Insert(0, itemNull);

            cb_1.DataSource = dataList.ToList();
            cb_2.DataSource = dataList.ToList();
            cb_3.DataSource = dataList.ToList();
            cb_4.DataSource = dataList.ToList();
            cb_5.DataSource = dataList.ToList();
            cb_6.DataSource = dataList.ToList();
            cb_7.DataSource = dataList.ToList();
            cb_8.DataSource = dataList.ToList();
            cb_9.DataSource = dataList.ToList();
            cb_10.DataSource = dataList.ToList();
            cb_11.DataSource = dataList.ToList();
            cb_12.DataSource = dataList.ToList();
            cb_13.DataSource = dataList.ToList();
            cb_14.DataSource = dataList.ToList();
            cb_15.DataSource = dataList.ToList();
            cb_16.DataSource = dataList.ToList();
            cb_17.DataSource = dataList.ToList();
            cb_18.DataSource = dataList.ToList();
            cb_19.DataSource = dataList.ToList();
            cb_20.DataSource = dataList.ToList();

            cb_1.DisplayMember = cb_2.DisplayMember = cb_3.DisplayMember = cb_4.DisplayMember = cb_5.DisplayMember =
                cb_6.DisplayMember = cb_7.DisplayMember = cb_8.DisplayMember = cb_9.DisplayMember = cb_10.DisplayMember =
                cb_11.DisplayMember = cb_12.DisplayMember = cb_13.DisplayMember = cb_14.DisplayMember = cb_15.DisplayMember =
                cb_16.DisplayMember = cb_17.DisplayMember = cb_18.DisplayMember = cb_19.DisplayMember = cb_20.DisplayMember = "ItemName";
            cb_1.ValueMember = cb_2.ValueMember = cb_3.ValueMember = cb_4.ValueMember = cb_5.ValueMember =
                cb_6.ValueMember = cb_7.ValueMember = cb_8.ValueMember = cb_9.ValueMember = cb_10.ValueMember =
                cb_11.ValueMember = cb_12.ValueMember = cb_13.ValueMember = cb_14.ValueMember = cb_15.ValueMember =
                cb_16.ValueMember = cb_17.ValueMember = cb_18.ValueMember = cb_19.ValueMember = cb_20.ValueMember = "ItemId";
            
            cb_1.SelectedIndexChanged += new EventHandler(cb1_SelectedIndexChanged);
            cb_2.SelectedIndexChanged += new EventHandler(cb2_SelectedIndexChanged);
            cb_3.SelectedIndexChanged += new EventHandler(cb3_SelectedIndexChanged);
            cb_4.SelectedIndexChanged += new EventHandler(cb4_SelectedIndexChanged);
            cb_5.SelectedIndexChanged += new EventHandler(cb5_SelectedIndexChanged);
            cb_6.SelectedIndexChanged += new EventHandler(cb6_SelectedIndexChanged);
            cb_7.SelectedIndexChanged += new EventHandler(cb7_SelectedIndexChanged);
            cb_8.SelectedIndexChanged += new EventHandler(cb8_SelectedIndexChanged);
            cb_9.SelectedIndexChanged += new EventHandler(cb9_SelectedIndexChanged);
            cb_10.SelectedIndexChanged += new EventHandler(cb10_SelectedIndexChanged);
            cb_11.SelectedIndexChanged += new EventHandler(cb11_SelectedIndexChanged);
            cb_12.SelectedIndexChanged += new EventHandler(cb12_SelectedIndexChanged);
            cb_13.SelectedIndexChanged += new EventHandler(cb13_SelectedIndexChanged);
            cb_14.SelectedIndexChanged += new EventHandler(cb14_SelectedIndexChanged);
            cb_15.SelectedIndexChanged += new EventHandler(cb15_SelectedIndexChanged);
            cb_16.SelectedIndexChanged += new EventHandler(cb16_SelectedIndexChanged);
            cb_17.SelectedIndexChanged += new EventHandler(cb17_SelectedIndexChanged);
            cb_18.SelectedIndexChanged += new EventHandler(cb18_SelectedIndexChanged);
            cb_19.SelectedIndexChanged += new EventHandler(cb19_SelectedIndexChanged);
            cb_20.SelectedIndexChanged += new EventHandler(cb20_SelectedIndexChanged);


        }

        private void cb1_SelectedIndexChanged(object sender,
                System.EventArgs e)
        {
            int itemId = (int)cb_1.SelectedValue;
            if (itemId < 0)
                return;
            ItemTable item = (from u in dataList
                             where u.ItemId == itemId
                             select u).First();
            lbl_1.Text = item.ItemUnit;
        }

        private void cb2_SelectedIndexChanged(object sender,
               System.EventArgs e)
        {
            int itemId = (int)cb_2.SelectedValue;
            if (itemId < 0)
                return;
            ItemTable item = (from u in dataList
                              where u.ItemId == itemId
                              select u).First();
            lbl_2.Text = item.ItemUnit;
        }

        private void cb3_SelectedIndexChanged(object sender,
               System.EventArgs e)
        {
            int itemId = (int)cb_3.SelectedValue;
            if (itemId < 0)
                return;
            ItemTable item = (from u in dataList
                              where u.ItemId == itemId
                              select u).First();
            lbl_3.Text = item.ItemUnit;
        }
        private void cb4_SelectedIndexChanged(object sender,
               System.EventArgs e)
        {
            int itemId = (int)cb_4.SelectedValue;
            if (itemId < 0)
                return;
            ItemTable item = (from u in dataList
                              where u.ItemId == itemId
                              select u).First();
            lbl_4.Text = item.ItemUnit;
        }
        private void cb5_SelectedIndexChanged(object sender,
               System.EventArgs e)
        {
            int itemId = (int)cb_5.SelectedValue;
            if (itemId < 0)
                return;
            ItemTable item = (from u in dataList
                              where u.ItemId == itemId
                              select u).First();
            lbl_5.Text = item.ItemUnit;
        }
        private void cb6_SelectedIndexChanged(object sender,
               System.EventArgs e)
        {
            int itemId = (int)cb_6.SelectedValue;
            if (itemId < 0)
                return;
            ItemTable item = (from u in dataList
                              where u.ItemId == itemId
                              select u).First();
            lbl_6.Text = item.ItemUnit;
        }
        private void cb7_SelectedIndexChanged(object sender,
               System.EventArgs e)
        {
            int itemId = (int)cb_7.SelectedValue;
            if (itemId < 0)
                return;
            ItemTable item = (from u in dataList
                              where u.ItemId == itemId
                              select u).First();
            lbl_7.Text = item.ItemUnit;
        }
        private void cb8_SelectedIndexChanged(object sender,
               System.EventArgs e)
        {
            int itemId = (int)cb_8.SelectedValue;
            if (itemId < 0)
                return;
            ItemTable item = (from u in dataList
                              where u.ItemId == itemId
                              select u).First();
            lbl_8.Text = item.ItemUnit;
        }
        private void cb9_SelectedIndexChanged(object sender,
               System.EventArgs e)
        {
            int itemId = (int)cb_9.SelectedValue;
            if (itemId < 0)
                return;
            ItemTable item = (from u in dataList
                              where u.ItemId == itemId
                              select u).First();
            lbl_9.Text = item.ItemUnit;
        }
        private void cb10_SelectedIndexChanged(object sender,
               System.EventArgs e)
        {
            int itemId = (int)cb_10.SelectedValue;
            if (itemId < 0)
                return;
            ItemTable item = (from u in dataList
                              where u.ItemId == itemId
                              select u).First();
            lbl_10.Text = item.ItemUnit;
        }
        private void cb11_SelectedIndexChanged(object sender,
               System.EventArgs e)
        {
            int itemId = (int)cb_11.SelectedValue;
            if (itemId < 0)
                return;
            ItemTable item = (from u in dataList
                              where u.ItemId == itemId
                              select u).First();
            lbl_11.Text = item.ItemUnit;
        }
        private void cb12_SelectedIndexChanged(object sender,
               System.EventArgs e)
        {
            int itemId = (int)cb_12.SelectedValue;
            if (itemId < 0)
                return;
            ItemTable item = (from u in dataList
                              where u.ItemId == itemId
                              select u).First();
            lbl_12.Text = item.ItemUnit;
        }
        private void cb13_SelectedIndexChanged(object sender,
               System.EventArgs e)
        {
            int itemId = (int)cb_13.SelectedValue;
            if (itemId < 0)
                return;
            ItemTable item = (from u in dataList
                              where u.ItemId == itemId
                              select u).First();
            lbl_13.Text = item.ItemUnit;
        }
        private void cb14_SelectedIndexChanged(object sender,
               System.EventArgs e)
        {
            int itemId = (int)cb_14.SelectedValue;
            if (itemId < 0)
                return;
            ItemTable item = (from u in dataList
                              where u.ItemId == itemId
                              select u).First();
            lbl_14.Text = item.ItemUnit;
        }
        private void cb15_SelectedIndexChanged(object sender,
               System.EventArgs e)
        {
            int itemId = (int)cb_15.SelectedValue;
            if (itemId < 0)
                return;
            ItemTable item = (from u in dataList
                              where u.ItemId == itemId
                              select u).First();
            lbl_15.Text = item.ItemUnit;
        }
        private void cb16_SelectedIndexChanged(object sender,
               System.EventArgs e)
        {
            int itemId = (int)cb_16.SelectedValue;
            if (itemId < 0)
                return;
            ItemTable item = (from u in dataList
                              where u.ItemId == itemId
                              select u).First();
            lbl_16.Text = item.ItemUnit;
        }
        private void cb17_SelectedIndexChanged(object sender,
               System.EventArgs e)
        {
            int itemId = (int)cb_17.SelectedValue;
            if (itemId < 0)
                return;
            ItemTable item = (from u in dataList
                              where u.ItemId == itemId
                              select u).First();
            lbl_17.Text = item.ItemUnit;
        }
        private void cb18_SelectedIndexChanged(object sender,
               System.EventArgs e)
        {
            int itemId = (int)cb_18.SelectedValue;
            if (itemId < 0)
                return;
            ItemTable item = (from u in dataList
                              where u.ItemId == itemId
                              select u).First();
            lbl_18.Text = item.ItemUnit;
        }
        private void cb19_SelectedIndexChanged(object sender,
               System.EventArgs e)
        {
            int itemId = (int)cb_19.SelectedValue;
            if (itemId < 0)
                return;
            ItemTable item = (from u in dataList
                              where u.ItemId == itemId
                              select u).First();
            lbl_19.Text = item.ItemUnit;
        }
        private void cb20_SelectedIndexChanged(object sender,
               System.EventArgs e)
        {
            int itemId = (int)cb_20.SelectedValue;
            if (itemId < 0)
                return;
            ItemTable item = (from u in dataList
                              where u.ItemId == itemId
                              select u).First();
            lbl_20.Text = item.ItemUnit;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form form_main = new Form2();
            form_main.Show();
            this.Close();
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            bool changedd = false;
            tesaresdbEntities dbe = new tesaresdbEntities();
            List<int> idList = new List<int>();

            if ((int)cb_1.SelectedValue > 0)
            {
                IngredientsTable iTable = new IngredientsTable();
                iTable.IngQuantity = (double)n_1.Value;
                iTable.ItemId = (int)cb_1.SelectedValue;
                dbe.IngredientsTable.Add(iTable);
                dbe.SaveChanges();
                int id = (from i in dbe.IngredientsTable orderby i.IngId descending select i).First().IngId;
                idList.Add(id);
                changedd = true;
            }

            if ((int)cb_2.SelectedValue > 0)
            {
                IngredientsTable iTable = new IngredientsTable();
                iTable.IngQuantity = (double)n_2.Value;
                iTable.ItemId = (int)cb_2.SelectedValue;
                dbe.IngredientsTable.Add(iTable);
                dbe.SaveChanges();
                int id = (from i in dbe.IngredientsTable orderby i.IngId descending select i).First().IngId;
                idList.Add(id);
                changedd = true;
            }
            if ((int)cb_3.SelectedValue > 0)
            {
                IngredientsTable iTable = new IngredientsTable();
                iTable.IngQuantity = (double)n_3.Value;
                iTable.ItemId = (int)cb_3.SelectedValue;
                dbe.IngredientsTable.Add(iTable);
                dbe.SaveChanges();
                int id = (from i in dbe.IngredientsTable orderby i.IngId descending select i).First().IngId;
                idList.Add(id);
                changedd = true;
            }
            if ((int)cb_4.SelectedValue > 0)
            {
                IngredientsTable iTable = new IngredientsTable();
                iTable.IngQuantity = (double)n_4.Value;
                iTable.ItemId = (int)cb_4.SelectedValue;
                dbe.IngredientsTable.Add(iTable);
                dbe.SaveChanges();
                int id = (from i in dbe.IngredientsTable orderby i.IngId descending select i).First().IngId;
                idList.Add(id);
                changedd = true;
            }
            if ((int)cb_5.SelectedValue > 0)
            {
                IngredientsTable iTable = new IngredientsTable();
                iTable.IngQuantity = (double)n_5.Value;
                iTable.ItemId = (int)cb_5.SelectedValue;
                dbe.IngredientsTable.Add(iTable);
                dbe.SaveChanges();
                int id = (from i in dbe.IngredientsTable orderby i.IngId descending select i).First().IngId;
                idList.Add(id);
                changedd = true;
            }
            if ((int)cb_6.SelectedValue > 0)
            {
                IngredientsTable iTable = new IngredientsTable();
                iTable.IngQuantity = (double)n_6.Value;
                iTable.ItemId = (int)cb_6.SelectedValue;
                dbe.IngredientsTable.Add(iTable);
                dbe.SaveChanges();
                int id = (from i in dbe.IngredientsTable orderby i.IngId descending select i).First().IngId;
                idList.Add(id);
                changedd = true;
            }
            if ((int)cb_7.SelectedValue > 0)
            {
                IngredientsTable iTable = new IngredientsTable();
                iTable.IngQuantity = (double)n_7.Value;
                iTable.ItemId = (int)cb_7.SelectedValue;
                dbe.IngredientsTable.Add(iTable);
                dbe.SaveChanges();
                int id = (from i in dbe.IngredientsTable orderby i.IngId descending select i).First().IngId;
                idList.Add(id);
                changedd = true;
            }
            if ((int)cb_8.SelectedValue > 0)
            {
                IngredientsTable iTable = new IngredientsTable();
                iTable.IngQuantity = (double)n_8.Value;
                iTable.ItemId = (int)cb_8.SelectedValue;
                dbe.IngredientsTable.Add(iTable);
                dbe.SaveChanges();
                int id = (from i in dbe.IngredientsTable orderby i.IngId descending select i).First().IngId;
                idList.Add(id);
                changedd = true;
            }
            if ((int)cb_9.SelectedValue > 0)
            {
                IngredientsTable iTable = new IngredientsTable();
                iTable.IngQuantity = (double)n_9.Value;
                iTable.ItemId = (int)cb_9.SelectedValue;
                dbe.IngredientsTable.Add(iTable);
                dbe.SaveChanges();
                int id = (from i in dbe.IngredientsTable orderby i.IngId descending select i).First().IngId;
                idList.Add(id);
                changedd = true;
            }
            if ((int)cb_10.SelectedValue > 0)
            {
                IngredientsTable iTable = new IngredientsTable();
                iTable.IngQuantity = (double)n_10.Value;
                iTable.ItemId = (int)cb_10.SelectedValue;
                dbe.IngredientsTable.Add(iTable);
                dbe.SaveChanges();
                int id = (from i in dbe.IngredientsTable orderby i.IngId descending select i).First().IngId;
                idList.Add(id);
                changedd = true;
            }
            if ((int)cb_11.SelectedValue > 0)
            {
                IngredientsTable iTable = new IngredientsTable();
                iTable.IngQuantity = (double)n_11.Value;
                iTable.ItemId = (int)cb_11.SelectedValue;
                dbe.IngredientsTable.Add(iTable);
                dbe.SaveChanges();
                int id = (from i in dbe.IngredientsTable orderby i.IngId descending select i).First().IngId;
                idList.Add(id);
                changedd = true;
            }
            if ((int)cb_12.SelectedValue > 0)
            {
                IngredientsTable iTable = new IngredientsTable();
                iTable.IngQuantity = (double)n_12.Value;
                iTable.ItemId = (int)cb_12.SelectedValue;
                dbe.IngredientsTable.Add(iTable);
                dbe.SaveChanges();
                int id = (from i in dbe.IngredientsTable orderby i.IngId descending select i).First().IngId;
                idList.Add(id);
                changedd = true;
            }
            if ((int)cb_13.SelectedValue > 0)
            {
                IngredientsTable iTable = new IngredientsTable();
                iTable.IngQuantity = (double)n_13.Value;
                iTable.ItemId = (int)cb_13.SelectedValue;
                dbe.IngredientsTable.Add(iTable);
                dbe.SaveChanges();
                int id = (from i in dbe.IngredientsTable orderby i.IngId descending select i).First().IngId;
                idList.Add(id);
                changedd = true;
            }
            if ((int)cb_14.SelectedValue > 0)
            {
                IngredientsTable iTable = new IngredientsTable();
                iTable.IngQuantity = (double)n_14.Value;
                iTable.ItemId = (int)cb_14.SelectedValue;
                dbe.IngredientsTable.Add(iTable);
                dbe.SaveChanges();
                int id = (from i in dbe.IngredientsTable orderby i.IngId descending select i).First().IngId;
                idList.Add(id);
                changedd = true;
            }
            if ((int)cb_15.SelectedValue > 0)
            {
                IngredientsTable iTable = new IngredientsTable();
                iTable.IngQuantity = (double)n_15.Value;
                iTable.ItemId = (int)cb_15.SelectedValue;
                dbe.IngredientsTable.Add(iTable);
                dbe.SaveChanges();
                int id = (from i in dbe.IngredientsTable orderby i.IngId descending select i).First().IngId;
                idList.Add(id);
                changedd = true;
            }
            if ((int)cb_16.SelectedValue > 0)
            {
                IngredientsTable iTable = new IngredientsTable();
                iTable.IngQuantity = (double)n_16.Value;
                iTable.ItemId = (int)cb_16.SelectedValue;
                dbe.IngredientsTable.Add(iTable);
                dbe.SaveChanges();
                int id = (from i in dbe.IngredientsTable orderby i.IngId descending select i).First().IngId;
                idList.Add(id);
                changedd = true;
            }
            if ((int)cb_17.SelectedValue > 0)
            {
                IngredientsTable iTable = new IngredientsTable();
                iTable.IngQuantity = (double)n_17.Value;
                iTable.ItemId = (int)cb_17.SelectedValue;
                dbe.IngredientsTable.Add(iTable);
                dbe.SaveChanges();
                int id = (from i in dbe.IngredientsTable orderby i.IngId descending select i).First().IngId;
                idList.Add(id);
                changedd = true;
            }
            if ((int)cb_18.SelectedValue > 0)
            {
                IngredientsTable iTable = new IngredientsTable();
                iTable.IngQuantity = (double)n_18.Value;
                iTable.ItemId = (int)cb_18.SelectedValue;
                dbe.IngredientsTable.Add(iTable);
                dbe.SaveChanges();
                int id = (from i in dbe.IngredientsTable orderby i.IngId descending select i).First().IngId;
                idList.Add(id);
                changedd = true;
            }
            if ((int)cb_19.SelectedValue > 0)
            {
                IngredientsTable iTable = new IngredientsTable();
                iTable.IngQuantity = (double)n_19.Value;
                iTable.ItemId = (int)cb_19.SelectedValue;
                dbe.IngredientsTable.Add(iTable);
                dbe.SaveChanges();
                int id = (from i in dbe.IngredientsTable orderby i.IngId descending select i).First().IngId;
                idList.Add(id);
                changedd = true;
            }
            if ((int)cb_20.SelectedValue > 0)
            {
                IngredientsTable iTable = new IngredientsTable();
                iTable.IngQuantity = (double)n_20.Value;
                iTable.ItemId = (int)cb_20.SelectedValue;
                dbe.IngredientsTable.Add(iTable);
                dbe.SaveChanges();
                int id = (from i in dbe.IngredientsTable orderby i.IngId descending select i).First().IngId;
                idList.Add(id);
                changedd = true;
            }

            if (changedd)
            {
                RecipeTable rTable = new RecipeTable();
                rTable.RecIngredients = String.Join(",", idList.Select(x => x.ToString()).ToArray());
                rTable.RecName = tb_recipe_name.Text;
                dbe.RecipeTable.Add(rTable);
                dbe.SaveChanges();

                Form form_main = new Form2();
                form_main.Show();
                this.Close();
            } else
            {
                lbl_warn.Text = "* Lütfen tarifi giriniz.";
            }

        }
    }
}
