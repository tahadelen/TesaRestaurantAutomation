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
    public partial class Form_Stock_List : Form
    {
        public Form_Stock_List()
        {
            InitializeComponent();

            tesaresdbEntities dbe = new tesaresdbEntities();

            dg_stocks.DataSource = (from it in dbe.ItemTable
                                    select new { Name = it.ItemName, Number = it.ItemExists,
                                        Threshold = it.ItemWarn, Unit = it.ItemUnit }).ToList();
            dg_stocks.Columns[0].HeaderText = "Stok Adı";
            dg_stocks.Columns[1].HeaderText = "Adet";
            dg_stocks.Columns[2].HeaderText = "Uyarı Sınırı";
            dg_stocks.Columns[3].HeaderText = "Birim";

        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            Form form_main = new Form2();
            form_main.Show();
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form form_back = new Form_Stock();
            form_back.Show();
            this.Close();
        }
    }
}
