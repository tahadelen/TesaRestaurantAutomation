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
    public partial class Form_Kasa_Giris : Form
    {
        public Form_Kasa_Giris()
        {
            InitializeComponent();
        }

        private void carihesaplar_Click(object sender, EventArgs e)
        {

        }

        private void stok_Click(object sender, EventArgs e)
        {

        }

        private void urunler_Click(object sender, EventArgs e)
        {
            Form kasa_giris = new Form_Products_General();
            kasa_giris.Show();
            this.Close();
        }

        private void adisyonlar_Click(object sender, EventArgs e)
        {

        }



        private void anamenu_Click(object sender, EventArgs e)
        {
            Form backScreen = new Form2();
            backScreen.Show();
            this.Close();
        }
    }
}
