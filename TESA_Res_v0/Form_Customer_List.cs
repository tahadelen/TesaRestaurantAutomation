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
    public partial class Form_Customer_List : Form
    {
        public Form_Customer_List()
        {
            InitializeComponent();

            tesaresdbEntities dbe = new tesaresdbEntities();

            customer_list.DataSource = (from ct in dbe.CustomerTable
                                        select new
                                        {
                                            Id = ct.customerID,
                                            Name = ct.nameSurname,
                                            Ord= ct.discountPer

                                        }).ToList();
            customer_list.ColumnHeadersHeight = 35;
            customer_list.RowTemplate.Height = 35;
            customer_list.Columns[0].HeaderText = "Müşteri Numarası";
            customer_list.Columns[0].Width = 500;
            customer_list.Columns[1].HeaderText = "Müşteri Adı";
            customer_list.Columns[1].Width = 500;
            customer_list.Columns[2].HeaderText = "Toplam Sipariş";
            customer_list.Columns[2].Width = 500;


            customer_list.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customer_list.MultiSelect = false;
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form backScreen = new Musteriler();
            backScreen.Show();
            this.Close();
        }

        private void anamenu_Click(object sender, EventArgs e)
        {
            Form backScreen = new Form2();
            backScreen.Show();
            this.Close();
        }

        private void musteriDetay_Click(object sender, EventArgs e)
        {

            tesaresdbEntities dbe = new tesaresdbEntities();

            if (customer_list.SelectedRows == null)
                return;

            DataGridViewRow row = customer_list.SelectedRows[0];
            int iId = int.Parse(row.Cells[0].Value.ToString());

            CustomerTable selected = (from customer in dbe.CustomerTable
                                      where iId == customer.customerID
                                      select customer).First();


            Form customer_order = new Form_Customer_Order_Detail(selected);
            customer_order.Show();
            this.Close();
        }
    }
}

