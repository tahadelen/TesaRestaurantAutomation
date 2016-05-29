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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string oldPass = enterPass.Text + '1';
            enterPass.Text = oldPass;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string oldPass = enterPass.Text + '2';
            enterPass.Text = oldPass;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string oldPass = enterPass.Text + '3';
            enterPass.Text = oldPass;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string oldPass = enterPass.Text + '4';
            enterPass.Text = oldPass;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            string oldPass = enterPass.Text + '5';
            enterPass.Text = oldPass;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            string oldPass = enterPass.Text + '6';
            enterPass.Text = oldPass;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            string oldPass = enterPass.Text + '7';
            enterPass.Text = oldPass;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            string oldPass = enterPass.Text + '8';
            enterPass.Text = oldPass;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            string oldPass = enterPass.Text + '9';
            enterPass.Text = oldPass;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            string oldPass = enterPass.Text + '0';
            enterPass.Text = oldPass;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            enterPass.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string enteredPass = enterPass.Text;
            tesaresdbEntities context = new tesaresdbEntities();
            IQueryable<UserTable> user = from a in context.UserTable
                                         where a.UserPass == enteredPass
                                         select a;
            if (user.Any())
            {
                UserTable userA = user.First();
                CommonVars common = CommonVars.Instance;
                common.Userid = userA.UserId;
                common.Username = userA.UserName;
                Form form_main = new Form2();
                form_main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hata", "Yanlış şifre", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

    }
}
