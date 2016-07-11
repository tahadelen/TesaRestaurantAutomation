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
    public partial class PaketServisEkle : Form
    {
        public PaketServisEkle()
        {
            InitializeComponent();
        }


        private void anaMenuClicked(object sender, EventArgs e)
        {
            Form form_main = new Form2();
            form_main.Show();
            this.Close();
        }

        private void geriClicked(object sender, EventArgs e)
        {
            Form form_paket_servis_opsiyon = new Paket_Servis_Opsiyon();
            form_paket_servis_opsiyon.Show();
            this.Close();
        }

        private void siparisHazırla(object sender, EventArgs e)
        {
            tesaresdbEntities dbe = new tesaresdbEntities();
            CallerIdCustomer item = new CallerIdCustomer();

            item.nameSurname = nameSurname.Text;
            item.phoneNumber = phoneNumber.Text;
            item.address1 = address1.Text;
            item.address2 = address2.Text;
            
            dbe.CallerIdCustomer.Add(item);
            dbe.SaveChanges();


            Form form_paket_servis_menu = new Paket_Servis_Menu(phoneNumber.Text, nameSurname.Text, address1.Text, address2.Text);
            form_paket_servis_menu.Show();
            this.Close();


        }
    }
}
