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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Form_Orders.Show();
            Program.Form_Tables.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Program.Form_Main.Show();
            //Program.Form_Tables.Hide();
        }
    }
}
