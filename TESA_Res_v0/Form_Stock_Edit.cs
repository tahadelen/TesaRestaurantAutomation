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
    public partial class Form_Stock_Edit : Form_Stock_List
    {
        private tesaresdbEntities dbe = new tesaresdbEntities();

        public Form_Stock_Edit()
        {
            InitializeComponent();
            this.btn_jobless.Text = "Düzenle";
            this.btn_jobless.Visible = true;
        }
        protected override void btn_jobless_Click(object sender, EventArgs e)
        {

            if (dg_stocks.SelectedRows == null)
                return;

            DataGridViewRow row = dg_stocks.SelectedRows[0];
            int iId = int.Parse(row.Cells[0].Value.ToString());

            ItemTable selected = (from stock in dbe.ItemTable
                                  where iId == stock.ItemId
                                  select stock).First();

            Form form_edit_item = new Form_Item_Edit(selected);
            form_edit_item.Show();
            this.Close();
        }
    }
}
