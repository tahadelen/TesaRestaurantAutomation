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
    public partial class AddNewCompany : Form
    {
        public AddNewCompany()
        {
            InitializeComponent();
        }

        private void anamenu_Click(object sender, EventArgs e)
        {
            Form anaMenu = new Form2();
            anaMenu.Show();
            this.Close();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form backScreen = new Musteriler();
            backScreen.Show();
            this.Close();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            tesaresdbEntities dbe = new tesaresdbEntities();
            CompanyTable item = new CompanyTable();

            item.companyName = companyName.Text;
            item.address1 = address1.Text;
            item.address2 = address2.Text;
            item.discountPer = Int32.Parse(discountPer.Text); 
            item.fax = faxNumber.Text;
            item.phoneNumber = phoneNumber.Text;
            item.taxAdmin = taxAdmin.Text;
            item.taxNum = taxNum.Text;
            item.mail = mail.Text;
           
            dbe.CompanyTable.Add(item);
            dbe.SaveChanges();

            Form backScreen = new Musteriler();
            backScreen.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }
    }
}
