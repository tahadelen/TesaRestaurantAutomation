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
    public partial class Form_Stock_Delete : Form_Stock_List
    {
        private tesaresdbEntities dbe = new tesaresdbEntities();

        public Form_Stock_Delete()
        {
            InitializeComponent();
            this.btn_jobless.Text = "Sil";
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

            DialogResult dr = MessageBox.Show("Kod: " + selected.ItemId + Environment.NewLine + "Malzeme Adı: " + selected.ItemName + Environment.NewLine + "olan malzemeyi silmek istediğinize emin misiniz?",
                      "Silme İşlemi Onay", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:

                    dbe.ItemTable.Remove(selected);
                    dbe.SaveChanges();

                    Form form_del_item = new Form_Stock_Delete();
                    form_del_item.Show();
                    this.Close();

                    break;
                case DialogResult.No: break;
            }

            
        }
    }
}
