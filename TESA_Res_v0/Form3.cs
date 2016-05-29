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
        public int userIdValue = 1;
        public int tableIdValue = 1;
        public tesaresdbEntities dbe = new tesaresdbEntities();
        public int selectedPaymentType = -1;
        public List<TableTable> listTableNames;
        public const int B_ROW = 4;
        public const int B_COL = 5;
        public const int width = 150;
        public const int height = 100;
        public const int space = 50;

        Button[,] btn = new Button[B_ROW, B_COL];

        public Form3()
        {
            InitializeComponent();
            fillTableNames();
            for (int i = 0; i < B_ROW; ++i)
            {
                for (int j = 0; j < B_COL; ++j)
                {
                    btn[i, j] = new Button();
                    btn[i, j].SetBounds(width * j + space, height * i + (space / 2), width, height);
                    int elementIndex = i * B_COL + j;
                    btn[i, j].Text = listTableNames.ElementAt(elementIndex).TableName;
                    btn[i, j].Font = new Font("Microsoft Sans Serif", 15);
                    btn[i, j].Click += (s, e) => {
                        CommonVars.Instance.Tableid = listTableNames.ElementAt(elementIndex).TableId;
                        Form form_orders = new Form4();
                        form_orders.Show();
                        this.Close();
                    };
                    Controls.Add(btn[i, j]);
                }
            }
        }

        void fillTableNames()
        {
            listTableNames = (from a in dbe.TableTable
                                orderby a.TableId ascending
                                select a).ToList();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form form_main = new Form2();
            form_main.Show();
            this.Close();
        }
    }
}
