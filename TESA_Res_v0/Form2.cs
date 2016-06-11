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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            lbl_user.Text = CommonVars.Instance.Username;
        }

      
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tesaresdbDataSet2.UserTable' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'tesaresdbDataSet.TableTable' table. You can move, or remove it, as needed.

        }

      
       
     
        private void button2_Click(object sender, EventArgs e)
        {
            Form form_food = new Form_Food();
            form_food.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form_add_product = new Form_Add_Product();
            form_add_product.Show();
            this.Close();
        }

 
        private void btn_exit_program_Click(object sender, EventArgs e)
        {
#if AAA
            DialogResult dialogResult = TopMostMessageBox.Show(
    "Programı kapatmak istediğinize emin misiniz?",
    "Programı Kapat", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
#endif
            Application.Exit();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form form_login = new Form1();
            CommonVars.Instance.Userid = -1;
            CommonVars.Instance.Username = "";
            form_login.Show();
            this.Close();
        }

        private void btn_tables_Click_1(object sender, EventArgs e)
        {
            Form form_tables = new Form3();
            form_tables.Show();
            this.Close();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            Form form_stock = new Form_Stock();
            form_stock.Show();
            this.Close();
        }
    }
}
