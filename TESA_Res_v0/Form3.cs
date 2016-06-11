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
        private int totalFloor;
        public int totalTable;
        public int totalPage;
        private int floor_id;
        public tesaresdbEntities dbe = new tesaresdbEntities();
        public int selectedPaymentType = -1;
        public List<TableTable> listTableNames;
        private List<FloorTable> listFloors;
        public const int B_ROW = 4;
        public const int B_COL = 5;
        public const int width = 160;
        public const int height = 110;
        public const int space = 20;
        private const int FLOOR_X = 860;
        private const int FLOOR_Y = 100;
        private const int FLOOR_W = 130;
        private const int FLOOR_H = 50;
        private const int FLOOR_S = 10;
        Button[] btn;
        Button[] btn_floors;

        public Form3()
        {
            InitializeComponent();

            refreshButtons();

            totalFloor = dbe.FloorTable.Count();
            listFloors = (from fl in dbe.FloorTable select fl).ToList();
            lbl_floor.Text = listFloors.First().FloorName;
            btn_floors = new Button[totalFloor];

            for(int i=0; i<totalFloor; ++i)
            {
                int j = i;
                btn_floors[i] = new Button();
                btn_floors[i].SetBounds(FLOOR_X, FLOOR_Y + i*(FLOOR_H+FLOOR_S), FLOOR_W, FLOOR_H);
                btn_floors[i].BackColor = SystemColors.Control;
                btn_floors[i].Text = listFloors.ElementAt(i).FloorName;
                btn_floors[i].Font = new Font("Microsoft Sans Serif", 15);
                btn_floors[i].Click += (s, e) =>
                {
                    floor_id = listFloors.ElementAt(j).FloorId;
                    refreshButtons(floor_id);
                };
                Controls.Add(btn_floors[i]);

            }

        }

        void refreshButtons(int floorId=-1)
        {
            if (btn != null)
            {
                foreach (Button bt in btn)
                    bt.Hide();
                btn = null;
            }
            pageNumber = 0;

            floor_id = floorId;
            if(floorId < 0)
            {
                floor_id = (from fId in dbe.FloorTable
                           orderby fId.FloorId ascending
                           select fId).First().FloorId;
            }
            lbl_floor.Text = (from fl in dbe.FloorTable where fl.FloorId == floor_id select fl).First().FloorName;
            fillTableNames(floor_id, B_ROW * B_COL, -1);
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
                            btn[elementIndex].SetBounds(width * j + (space / 2), height * i + (space / 2), width, height);
                            btn[elementIndex].Hide();
                            btn[elementIndex].BackColor = SystemColors.Control;
                            btn[elementIndex].Text = listTableNames.ElementAt(elementIndex).TableName;
                            btn[elementIndex].Font = new Font("Microsoft Sans Serif", 15);
                            btn[elementIndex].Click += (s, e) =>
                            {
                                CommonVars.Instance.Tableid = listTableNames.ElementAt(checkRC).TableId;
                                Form form_orders = new Form4();
                                form_orders.Show();
                                this.Close();
                            };
                            gb_tables.Controls.Add(btn[elementIndex]);
                        }
                    }
                }
            }
        }

        void updateTableButtons()
        {
            fillTableNames(floor_id, B_ROW * B_COL, pageNumber);

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

        void fillTableNames(int floorId, int numberOfObjectsPerPage, int pageNumber)
        {
            var query = (from a in dbe.TableTable
                         where a.FloorId == floorId
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

        private void tableConcat_Click(object sender, EventArgs e)
        {
            Form tCo = new Form_TableConcat();
            tCo.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form form_login = new Form1();
            CommonVars.Instance.Userid = -1;
            CommonVars.Instance.Username = "";
            form_login.Show();
            this.Close();
        }
    }
}
