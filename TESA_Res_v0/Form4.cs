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
    public partial class Form4 : Form
    {
        private ListView[] lv_menus;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tesaresdbDataSet.CategoryTable' table. You can move, or remove it, as needed.
            this.categoryTableTableAdapter.Fill(this.tesaresdbDataSet.CategoryTable);


            tesaresdbEntities context = new tesaresdbEntities();

            lbl_order_info.Text = "";

            /*fill orders*/
            var oList = (from a in context.OrderTable
                         where a.TableId == CommonVars.Instance.Tableid && !(a.Dlt)
                         join b in context.ProductTable on a.ProductId equals b.ProductId
                         orderby a.OrderId ascending
                         select new { ProductName = b.ProductName, Number = a.Number, Cost = a.Cost, Price = b.ProCost }).ToList();
            string oDetails;
            double firstCost = 0;
            foreach(var item in oList)
            {
                oDetails = item.Cost/(item.Price*item.Number) + " p. " + item.ProductName + " x " + item.Number
                    + " = " + item.Cost + " TL";
                firstCost += item.Cost;
                lb_orders.Items.Add(oDetails);
            }
            updateOrderCost(firstCost);

            /*end fill*/

            String[] cats = context.CategoryTable.Select(x => x.CatName).ToArray();
            int[] catIds = context.CategoryTable.Select(x => x.CatId).ToArray();
            lv_menus = new ListView[catIds.Length];
            if (cats.Any())
            {
                int i = 0;
                foreach (String c in cats)
                {
                    TabPage tabPage = new TabPage();
                    tabPage.Text = c.ToString();
                    int tmpId = catIds[i];

                    var pd = context.ProductTable
                        .Where(item => item.CatId == tmpId)
                        .Select(item => new { item.ProductId, item.ProductName, item.ProCost });
                    /*
                    var pd = from item in context.ProductTable
                           where item.CatId == tmpId
                           select item;*/
                    if (pd.Any())
                    {
                        lv_menus[i] = new ListView();
                        //lv_menus[i].HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;

                        foreach (var itm in pd)
                        {
                            ListViewItem lvi = new ListViewItem(itm.ProductName);
                            lvi.Tag = itm.ProductId + "*" + itm.ProCost;
                            lv_menus[i].Items.Add(lvi);
                        }
                        /*
                        DataGrid grid = new DataGrid();
                        grid.Dock = DockStyle.Fill;
                        var list = pd.ToList();
                        grid.DataSource = list;
                        tabPage.Controls.Add(grid);
                        */
                        lv_menus[i].Dock = DockStyle.Fill;
                        tabPage.Controls.Add(lv_menus[i]);
                    }
                    tabControl1.Controls.Add(tabPage);
                    ++i;
                }

                this.Controls.Add(tabControl1);
            }
            else
            {
                MessageBox.Show("Hata", "Kategori bulunamadı!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            lbl_porsiyon.Text = "0,5";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            lbl_porsiyon.Text = "1";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            lbl_porsiyon.Text = "1,5";
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            lbl_porsiyon.Text = "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int adet = int.Parse(lbl_adet.Text) + 1;
            lbl_adet.Text = adet.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int adet = int.Parse(lbl_adet.Text) - 1;
            if (adet > 0)
                lbl_adet.Text = adet.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form_tables = new Form3();
            form_tables.Show();
            this.Close();
        }

        private void btn_addToOrder_Click(object sender, EventArgs e)
        {
            int tabPageId = tabControl1.SelectedIndex;
            ListViewItem selectedItem;
            String pName, orderDetails;
            double p, a, price, calc;
            if (lv_menus[tabPageId].SelectedItems.Count > 0)
            {
                selectedItem = lv_menus[tabPageId].SelectedItems[0];
                pName = selectedItem.Text;
                p = double.Parse(lbl_porsiyon.Text);
                a = double.Parse(lbl_adet.Text);
                price = double.Parse(selectedItem.Tag.ToString().Split('*')[1]);
                calc = p * a * price;
                orderDetails = lbl_porsiyon.Text + " p. " + pName + " x " + lbl_adet.Text
                    + " = " + calc.ToString() + " TL";


                /* database process*/
                OrderTable order = new OrderTable();
                order.TableId = CommonVars.Instance.Tableid;
                order.ProductId = int.Parse(selectedItem.Tag.ToString().Split('*')[0]);
                order.UserId = CommonVars.Instance.Userid;
                order.Number = a;
                order.Cost = calc;
                order.Time = DateTime.Now;

                tesaresdbEntities dbe = new tesaresdbEntities();
                dbe.OrderTable.Add(order);
                dbe.SaveChanges();

                lb_orders.Items.Add(orderDetails);
                updateOrderCost(calc);
            }
            lbl_adet.Text = "1";
            lbl_porsiyon.Text = "1";
        }

        private void updateOrderCost(double cost)
        {
            string[] orderCostStr = lbl_order_cost.Text.ToString().Split(null);

            double current = double.Parse(orderCostStr[0]);
            current += cost;
            lbl_order_cost.Text = current.ToString() + " TL";
        }

        private void btn_removeFromOrder_Click(object sender, EventArgs e)
        {
            tesaresdbEntities dbe = new tesaresdbEntities();
            var dataList = (from a in dbe.OrderTable
                        where a.TableId == CommonVars.Instance.Tableid && !(a.Dlt)
                        orderby a.OrderId ascending
                        select a).ToList();

            if (lb_orders.SelectedItems.Count > 0)
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lb_orders);
                selectedItems = lb_orders.SelectedItems;

                if (lb_orders.SelectedIndex != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                    {
                        //selectedItems[i].ToString
                        OrderTable ot = dataList.ElementAt(lb_orders.SelectedIndex);
                        double cost = -1 * ot.Cost;
                        ot.Dlt = true;
                        //dbe.OrderTable.Remove(ot);
                        updateOrderCost(cost);
                        lb_orders.Items.Remove(selectedItems[i]);
                    }
                    dbe.SaveChanges();
                }
                else
                    MessageBox.Show("Hata oluştu!");
            }
        }

        private void btn_get_order_Click(object sender, EventArgs e)
        {
            bool done = true; //printer function will be called here
            if (done)
                lbl_order_info.Text = "Sipariş iletildi";
            else
                lbl_order_info.Text = "Hata! Sipariş yazdırılamadı!";
        }

        private void btn_get_ticket_Click(object sender, EventArgs e)
        {
            bool done = true; //printer function will be called here
            if (done)
                lbl_order_info.Text = "Adisyon yazdırıldı";
            else
                lbl_order_info.Text = "Hata! Adisyon yazdırılamadı!";
        }

        private void btn_get_return_Click(object sender, EventArgs e)
        {
            tesaresdbEntities dbe = new tesaresdbEntities();
            var dataList = (from a in dbe.OrderTable
                            where a.TableId == CommonVars.Instance.Tableid
                            orderby a.OrderId ascending
                            select a).ToList();
            var oList = (from a in dbe.OrderTable
                         where a.TableId == CommonVars.Instance.Tableid
                         join b in dbe.ProductTable on a.ProductId equals b.ProductId
                         orderby a.OrderId ascending
                         select new { ProductName = b.ProductName, Number = a.Number, Cost = a.Cost, Price = b.ProCost }).ToList();


            if (lb_orders.SelectedItems.Count > 0)
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lb_orders);
                selectedItems = lb_orders.SelectedItems;
                string oDetails;
                if (lb_orders.SelectedIndex != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                    {
                        //selectedItems[i].ToString
                        OrderTable ot = dataList.ElementAt(lb_orders.SelectedIndex);
                        double cost = -1 * ot.Cost;
                        int j = lb_orders.SelectedIndex;
                       
                        updateOrderCost(cost);
                        oDetails = oList.ElementAt(j).Cost / (oList.ElementAt(j).Price * oList.ElementAt(j).Number) 
                            + " p. " + oList.ElementAt(j).ProductName + " x " + oList.ElementAt(j).Number
                     + " = " + 0 + " TL";

                        lb_orders.Items[lb_orders.SelectedIndex] = oDetails;
                       
                    }
                    
                }
                else
                    MessageBox.Show("Hata oluştu!");
            }
        }

        private void btn_get_payment_Click(object sender, EventArgs e)
        {
            Form pay = new Form5();
            pay.ShowDialog();
        }
    }
}
