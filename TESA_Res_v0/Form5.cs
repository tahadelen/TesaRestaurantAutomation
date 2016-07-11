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
    public partial class Form5 : Form
    {
        public int userIdValue = CommonVars.Instance.Userid;
        public int tableIdValue = CommonVars.Instance.Tableid;
        public tesaresdbEntities dbe = new tesaresdbEntities();
        public int selectedPaymentType = -1;
        public List<PaymentTypeTable> listPaymentTypes;
        public const int B_ROW = 2;
        public const int B_COL = 4;
        public const int width = 200;
        public const int height = 200;
        public const int space = 100;

        Button[,] btn = new Button[B_ROW, B_COL];

        public Form5()
        {
            InitializeComponent();
            fillPaymentTypes();

            for (int i = 0; i < B_ROW; ++i)
            {
                for (int j = 0; j < B_COL; ++j)
                {
                    btn[i, j] = new Button();
                    btn[i, j].SetBounds(width * j + space, height * i + (space / 2), width, height);
                    int elementIndex = i * B_COL + j;
                    btn[i, j].Text = listPaymentTypes.ElementAt(elementIndex).PTTName;
                    btn[i, j].Font = new Font("Microsoft Sans Serif", 15);
                    btn[i, j].Click += (s, e) => {
                        label1.ForeColor = Color.Black;
                        label1.Text = listPaymentTypes.ElementAt(elementIndex).PTTName;
                        selectedPaymentType = listPaymentTypes.ElementAt(elementIndex).PTTId;
                    };                
                    Controls.Add(btn[i, j]);
                }
            }
        }

        void fillPaymentTypes()
        {
            listPaymentTypes = (from a in dbe.PaymentTypeTable
                         orderby a.PTTId ascending
                         select a).ToList();
        }

        private void btnPayCancel_Click(object sender, EventArgs e)
        {
            Form order = new Form4();
            order.Show();
            this.Close();
        }

        /*
         * process orders to transaction table and payment table ..
         * delete orders
        */
        private void btnPayment_Click(object sender, EventArgs e)
        {
            if(selectedPaymentType<0)
            {
                MessageBox.Show("Ödeme Türü Seçiniz!", "Ödeme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            List<int> orderIds = new List<int>();
            double totalCost = 0;

            var orders = (from o in dbe.OrderTable
                          where o.TableId == tableIdValue
                          join p in dbe.ProductTable on o.ProductId equals p.ProductId
                          orderby o.OrderId ascending
                          select new { OrderId = o.OrderId, TableId = o.TableId, ProductId = o.ProductId, UserId = userIdValue, Number = o.Number, Cost = o.Cost,
                          PaymentType = selectedPaymentType, Dlt = o.Dlt, OTime = o.Time}).ToList();

            foreach( var ord in orders)
            {
                // fill transcaction
                TransactionTable trTable = new TransactionTable();
                trTable.OrderId = ord.OrderId;
                trTable.TableId = ord.TableId;
                trTable.ProductId = ord.ProductId;
                trTable.UserId = ord.UserId;
                trTable.Number = ord.Number;
                trTable.Cost = ord.Cost;
                trTable.PaymentType = ord.PaymentType;
                trTable.Dlt = ord.Dlt;
                trTable.Time = ord.OTime;

                // add to database
                dbe.TransactionTable.Add(trTable);

                // sum costs and add orderIds to list
                if (!ord.Dlt)
                {
                    totalCost += ord.Cost;
                    orderIds.Add(ord.OrderId);
                }
            }
            string csvOrders = String.Join(",", orderIds.Select(x => x.ToString()).ToArray());


            // fill payment table
            PaymentTable payTable = new PaymentTable();
            payTable.TableId = tableIdValue;
            payTable.OrderIds = csvOrders;
            payTable.TotalCost = totalCost;
            payTable.Time = DateTime.Now;

            // add to database
            dbe.PaymentTable.Add(payTable);

            // remove order from table

            
            var oTableList = (from o in dbe.OrderTable
                            where o.TableId == tableIdValue
                            orderby o.OrderId ascending
                            select o).ToList(); 
            foreach(OrderTable ot in oTableList)
            {
                dbe.OrderTable.Remove(ot);
            }

            dbe.SaveChanges();
            Form tables = new Form3();
            tables.Show();
            this.Close();
        }
    }
}
