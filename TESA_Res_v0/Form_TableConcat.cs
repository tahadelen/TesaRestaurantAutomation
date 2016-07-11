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
    public partial class Form_TableConcat : Form
    {
        public Form_TableConcat()
        {
            InitializeComponent();
            lblInfo.Text = "";

            tesaresdbEntities dbe = new tesaresdbEntities();
            List<TableTable> dataList = (from a in dbe.TableTable
                            orderby a.TableId ascending
                            select a).ToList();
            comboBox1.DataSource = dataList;
            comboBox1.DisplayMember = "TableName";
            comboBox1.ValueMember = "TableId";
            comboBox1.SelectedIndexChanged += new EventHandler(ComboBox1_SelectedIndexChanged);
        }

        private void ComboBox1_SelectedIndexChanged(object sender,
        System.EventArgs e)
        {
            int table1Id = (int)comboBox1.SelectedValue;

            lblInfo.Text = "";

            tesaresdbEntities dbe = new tesaresdbEntities();
            List<TableTable> dataList = (from a in dbe.TableTable
                                         where a.TableId != table1Id
                                         orderby a.TableId ascending
                                         select a).ToList();

            comboBox2.DataSource = dataList;
            comboBox2.DisplayMember = "TableName";
            comboBox2.ValueMember = "TableId";
            comboBox2.SelectedIndexChanged += new EventHandler(ComboBox2_SelectedIndexChanged);

            comboBox2.Enabled = true;


        }
        private void ComboBox2_SelectedIndexChanged(object sender,
       System.EventArgs e)
        {
            lblInfo.Text = comboBox1.Text + " ile " + comboBox2.Text + " masaları birleştirilecek!";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConcat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
