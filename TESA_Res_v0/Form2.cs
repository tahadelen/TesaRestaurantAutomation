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
            toolStripUserName.Text = CommonVars.Instance.Username;
        }

        private void exitProgram_Click(object sender, EventArgs e)
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form form_tables = new Form3();
            form_tables.Show();
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cb_dealers.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cb_dealers.Enabled = false;
        }

        //top_menu_customers
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           //Program.Form_Tables.Show();
           //Program.Form_Main.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tesaresdbDataSet2.UserTable' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'tesaresdbDataSet.TableTable' table. You can move, or remove it, as needed.

        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            Form form_login = new Form1();
            CommonVars.Instance.Userid = -1;
            CommonVars.Instance.Username = "";
            form_login.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form_add_item = new Form_Items();
            form_add_item.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form_food = new Form_Food();
            form_food.Show();
            this.Close();
        }
    }
}
