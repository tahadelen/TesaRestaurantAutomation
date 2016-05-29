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
        public int pageNumber = 0;
        public int totalTable;
        public int totalPage;
        public tesaresdbEntities dbe = new tesaresdbEntities();
        public int selectedPaymentType = -1;
        public List<TableTable> listTableNames;
        public const int B_ROW = 4;
        public const int B_COL = 5;
        public const int width = 150;
        public const int height = 100;
        public const int space = 50;

        Button[] btn;

        public Form3()
        {
            InitializeComponent();

            fillTableNames(B_ROW * B_COL, -1);

            createTableButtons();

            updateTableButtons();
            pageChecker();
        }

        void createTableButtons()
        {
            btn = new Button[totalTable];
            for (int p = 0; p < totalPage + 1; ++p)
            {
                for (int i = 0; i < B_ROW; ++i)
                {
                    for (int j = 0; j < B_COL; ++j)
                    {
                        int elementIndex = i * B_COL + j + p * (B_ROW * B_COL);
                        int checkRC = elementIndex - p * (B_ROW * B_COL);
                        
                        if (elementIndex < totalTable)
                        {
                            btn[elementIndex] = new Button();
                            btn[elementIndex].SetBounds(width * j + space, height * i + (space / 2), width, height);
                            btn[elementIndex].Hide();
                            btn[elementIndex].Text = listTableNames.ElementAt(elementIndex).TableName;
                            btn[elementIndex].Font = new Font("Microsoft Sans Serif", 15);
                            btn[elementIndex].Click += (s, e) =>
                            {
                                CommonVars.Instance.Tableid = listTableNames.ElementAt(checkRC).TableId;
                                Form form_orders = new Form4();
                                form_orders.Show();
                                this.Close();
                            };
                            Controls.Add(btn[elementIndex]);
                        }
                    }
                }
            }
        }

        void updateTableButtons()
        {
            fillTableNames(B_ROW * B_COL, pageNumber);

            int btnCounter = listTableNames.Count<TableTable>();
            foreach (Button bt in btn)
                bt.Hide();

            for (int i = 0; i < B_ROW; ++i)
            {
                for (int j = 0; j < B_COL; ++j)
                {
                    int elementIndex = i * B_COL + j + pageNumber * (B_ROW * B_COL);
                    int checkRC = elementIndex - pageNumber * (B_ROW * B_COL);
                    if (checkRC < btnCounter)
                    {
                        btn[elementIndex].Show();
                    }
                }
            }
        }

        void fillTableNames(int numberOfObjectsPerPage, int pageNumber)
        {
            var query = (from a in dbe.TableTable
                         orderby a.TableId ascending
                         select a);
            totalTable = query.Count();
            totalPage = query.Count() / numberOfObjectsPerPage;

            if (pageNumber > -1)
            {
                listTableNames = query.Skip(numberOfObjectsPerPage * pageNumber)
                                    .Take(numberOfObjectsPerPage)
                        .ToList();
            }else
            {
                listTableNames = query.ToList();
            }
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

        private void btnNextTables_Click(object sender, EventArgs e)
        {
            if (pageNumber < totalPage)
            {
                ++pageNumber;
                pageChecker();
                updateTableButtons();
            }
        }

        private void btnPrevTables_Click(object sender, EventArgs e)
        {
            if (pageNumber > 0)
            {
                --pageNumber;
                pageChecker();
                updateTableButtons();
            }

        }

        private void pageChecker()
        {
            if (pageNumber > 0)
            {
                btnPrevTables.Enabled = true;
            }
            else
            {
                btnPrevTables.Enabled = false;
            }

            if (pageNumber < totalPage)
            {
                btnNextTables.Enabled = true;
            }
            else
            {
                btnNextTables.Enabled = false;
            }
        }
    }
}
