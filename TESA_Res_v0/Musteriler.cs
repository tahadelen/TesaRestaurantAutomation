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
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }

  

        private void sahisEkle_Click(object sender, EventArgs e)
        {
            Form form_new_customer = new Add_New_Customer();
            form_new_customer.Show();
            this.Close();
        }

        private void musterileriListele_Click(object sender, EventArgs e)
        {
            Form form_customer_list = new Form_Customer_List();
            form_customer_list.Show();
            this.Close();
        }

        private void sirketEkleClicked(object sender, EventArgs e)
        {
            Form form_new_company = new AddNewCompany();
            form_new_company.Show();
            this.Close();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form form_main = new Form2();
            form_main.Show();
            this.Close();
        }
    }
}
