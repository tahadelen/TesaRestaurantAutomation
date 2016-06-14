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
    public partial class Form_Item_Edit : Form_Items
    {
        private ItemTable itemE;
        public Form_Item_Edit(ItemTable itemSelected)
        {
            InitializeComponent();
            this.itemE = itemSelected;
            tb_item_name.Text = itemE.ItemName;
            tb_number.Text = itemE.ItemExists.ToString();
            tb_stock_warn.Text = itemE.ItemWarn.ToString();

            if(itemE.ItemUnit.ToString() == "Kg")
            {
                radioButton1.Checked = true;
            } else
            {
                radioButton2.Checked = true;
            }

            btnAdd.Text = "Düzenle";
        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            tesaresdbEntities dbe = new tesaresdbEntities();
            ItemTable iUp = (from it in dbe.ItemTable
                             where itemE.ItemId == it.ItemId
                             select it).First();
            if (tb_item_name.Text != "" && (radioButton1.Checked || radioButton2.Checked) && tb_stock_warn.Text != ""
                && tb_number.Text != "")
            {
                string name = tb_item_name.Text, unit;
                float stockWarn = float.Parse(tb_stock_warn.Text);
                float number = float.Parse(tb_number.Text);
                if (radioButton1.Checked)
                    unit = radioButton1.Tag.ToString();
                else
                    unit = radioButton2.Tag.ToString();

                iUp.ItemName = name;
                iUp.ItemUnit = unit;
                iUp.ItemWarn = stockWarn;
                iUp.ItemExists = number;
                dbe.SaveChanges();

                Form form_main = new Form2();
                form_main.Show();
                this.Close();
            }
            else
            {
                lblWarning.Show();
            }
        }
    }
}
