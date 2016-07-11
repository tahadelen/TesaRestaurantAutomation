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

    
    public partial class Paket_Servis_Menu : Form
    {
        public tesaresdbEntities dbe = new tesaresdbEntities();
        public List<Product_Categories_Table> productCategoreis;
        private int categoriesCount;

        public Paket_Servis_Menu(String phoneNumber, String nameSurname, String address1, String address2)
        {
            InitializeComponent();
            
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void geri_Click(object sender, EventArgs e)
        {

        }

        private void anamenu_Click(object sender, EventArgs e)
        {

        }

        private void customerCountPlusOne_Click(object sender, EventArgs e)
        {

        }

        private void customerCountMinusOne_Click(object sender, EventArgs e)
        {

        }

        private void discount_Click(object sender, EventArgs e)
        {

        }

        private void orderCancelled_Click(object sender, EventArgs e)
        {

        }

        private void orderOption_Click(object sender, EventArgs e)
        {

        }

        private void makeItFree_Click(object sender, EventArgs e)
        {

        }

        private void halfPortion_Click(object sender, EventArgs e)
        {

        }

        private void onePorsion_Click(object sender, EventArgs e)
        {

        }

        private void oneandhalfPorsion_Click(object sender, EventArgs e)
        {

        }

        private void twoPorsion_Click(object sender, EventArgs e)
        {

        }

        private void orderCountPlusOne_Click(object sender, EventArgs e)
        {

        }

        private void orderCountMinusOne_Click(object sender, EventArgs e)
        {

        }

        private void addOrder_Click(object sender, EventArgs e)
        {

        }

        private void carrier_Click(object sender, EventArgs e)
        {

        }

        private void printReceipt_Click(object sender, EventArgs e)
        {

        }

        private void sendOrder_Click(object sender, EventArgs e)
        {

        }

        private void payReceipt_Click(object sender, EventArgs e)
        {

        }

        private void removeOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
