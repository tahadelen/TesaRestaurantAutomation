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
    public partial class Form_Items : Form
    {
        public Form_Items()
        {
            InitializeComponent();
            lblWarning.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form form_main = new Form2();
            form_main.Show();
            this.Close();
        }

        protected virtual void btnAdd_Click(object sender, EventArgs e)
        {
            tesaresdbEntities dbe = new tesaresdbEntities();
            ItemTable item = new ItemTable();
            if (tb_item_name.Text != "" && (radioButton1.Checked || radioButton2.Checked) && tb_stock_warn.Text != "" 
                && tb_number.Text != "") {
                string name = tb_item_name.Text, unit;
                float stockWarn = float.Parse(tb_stock_warn.Text);
                float number = float.Parse(tb_number.Text);
                if (radioButton1.Checked)
                    unit = radioButton1.Tag.ToString();
                else
                    unit = radioButton2.Tag.ToString();

                item.ItemName = name;
                item.ItemUnit = unit;
                item.ItemWarn = stockWarn;
                item.ItemExists = number;
                dbe.ItemTable.Add(item);
                dbe.SaveChanges();

                Form form_main = new Form2();
                form_main.Show();
                this.Close();
            } else
            {
                lblWarning.Show();
            }
        }
    }
}
