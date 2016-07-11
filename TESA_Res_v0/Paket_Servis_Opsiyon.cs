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
    public partial class Paket_Servis_Opsiyon : Form
    {
        public Paket_Servis_Opsiyon()
        {
            InitializeComponent();
        }

        private void servisEkleClicked(object sender, EventArgs e)
        {
            Form form_tables = new PaketServisEkle();
            form_tables.Show();
            this.Close();
        }

        private void servisleriListeleClicked(object sender, EventArgs e)
        {

        }

        private void GERİ_Click(object sender, EventArgs e)
        {
            Form form_tables = new Form2();
            form_tables.Show();
            this.Close();
        }
    }
}
