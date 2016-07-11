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
    public partial class Form_Stock : Form
    {
        public Form_Stock()
        {
            InitializeComponent();
        }

        private void btn_stock_edit_Click(object sender, EventArgs e)
        {
            Form form_edit_item = new Form_Stock_Edit();
            form_edit_item.Show();
            this.Close();
        }

        private void btn_stock_add_Click(object sender, EventArgs e)
        {
            Form form_add_item = new Form_Items();
            form_add_item.Show();
            this.Close();
        }

        private void btn_stock_view_Click(object sender, EventArgs e)
        {
            Form form_stock_list = new Form_Stock_List();
            form_stock_list.Show();
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form form_main = new Form2();
            form_main.Show();
            this.Close();
        }

        private void btn_stock_delete_Click(object sender, EventArgs e)
        {
            Form form_stock_delete = new Form_Stock_Delete();
            form_stock_delete.Show();
            this.Close();
        }
    }
}
