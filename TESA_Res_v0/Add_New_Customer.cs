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
    public partial class Add_New_Customer : Form
    {
        public Add_New_Customer()
        {
            InitializeComponent();
            tesaresdbEntities dbe = new tesaresdbEntities();
            List<Product_Categories_Table> dataList = (from a in dbe.Product_Categories_Table
                                                       orderby a.productID ascending
                                         select a).ToList();

            companyDropdown.DataSource = dataList;
            companyDropdown.DisplayMember = "companyName";
            companyDropdown.ValueMember = "companyID";
            companyDropdown.SelectedIndexChanged += new EventHandler(companyDropdown_SelectedIndexChanged);

        }

        private void anamenu_Click(object sender, EventArgs e)
        {
            Form form_tables = new Form2();
            form_tables.Show();
            this.Close();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form form_tables = new Musteriler();
            form_tables.Show();
            this.Close();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            tesaresdbEntities dbe = new tesaresdbEntities();
            CustomerTable item = new CustomerTable();

            int companyID = (int)companyDropdown.SelectedValue;


            item.address1 = address1.Text;
            item.address2 = address2.Text;
            item.discountPer = Int32.Parse(discountPer.Text);
            item.mail = mail.Text;
            item.nameSurname = nameSurname.Text;
            item.phoneNumber = phoneNumber.Text;
            item.companyID = companyID;

            dbe.CustomerTable.Add(item);
            dbe.SaveChanges();

            Form backScreen = new Musteriler();
            backScreen.Show();
            this.Close();


        }

        private void companyDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
