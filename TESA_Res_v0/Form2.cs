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
        }

        private void exitProgram_Click(object sender, EventArgs e)
        {
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
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Program.Form_Tables.Show();
            Program.Form_Main.Hide();
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
    }
}
