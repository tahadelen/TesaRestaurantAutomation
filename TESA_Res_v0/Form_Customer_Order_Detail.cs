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
    public partial class Form_Customer_Order_Detail : Form
    {
        private CustomerTable ct;
        public Form_Customer_Order_Detail(CustomerTable customer)
        {
            InitializeComponent();
            this.ct = customer;

            nameSurname.Text = customer.nameSurname;
            phoneNumber.Text = customer.phoneNumber;
            address.Text = customer.address1 + customer.address2;

        }

        private void Form_Customer_Order_Detail_Load(object sender, EventArgs e)
        {

        }

        private void anamenu_Click(object sender, EventArgs e)
        {
            Form backScreen = new Form2();
            backScreen.Show();
            this.Close();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form backScreen = new Musteriler();
            backScreen.Show();
            this.Close();
        }

        private void menu_Click(object sender, EventArgs e)
        {

        }
    }
}
