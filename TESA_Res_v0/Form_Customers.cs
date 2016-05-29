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
    public partial class Form_Customers : Form
    {
        public Form_Customers()
        {
            InitializeComponent();
        }

        private void customers_menu_close_Click(object sender, EventArgs e)
        {   
            Program.Form_Customers.Hide();
        }
    }
}
