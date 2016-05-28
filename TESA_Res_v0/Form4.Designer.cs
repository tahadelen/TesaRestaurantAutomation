namespace TESA_Res_v0
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.categoryTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tesaresdbDataSet = new TESA_Res_v0.tesaresdbDataSet();
            this.lb_orders = new System.Windows.Forms.ListBox();
            this.categoryTableTableAdapter = new TESA_Res_v0.tesaresdbDataSetTableAdapters.CategoryTableTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_addToOrder = new System.Windows.Forms.Button();
            this.btn_removeFromOrder = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_get_order = new System.Windows.Forms.Button();
            this.btn_get_ticket = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_adet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_porsiyon = new System.Windows.Forms.Label();
            this.btn_get_payment = new System.Windows.Forms.Button();
            this.btn_get_return = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_order_cost = new System.Windows.Forms.Label();
            this.lbl_order_info = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesaresdbDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryTableBindingSource
            // 
            this.categoryTableBindingSource.DataMember = "CategoryTable";
            this.categoryTableBindingSource.DataSource = this.tesaresdbDataSet;
            // 
            // tesaresdbDataSet
            // 
            this.tesaresdbDataSet.DataSetName = "tesaresdbDataSet";
            this.tesaresdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lb_orders
            // 
            this.lb_orders.FormattingEnabled = true;
            this.lb_orders.ItemHeight = 16;
            this.lb_orders.Location = new System.Drawing.Point(664, 49);
            this.lb_orders.Name = "lb_orders";
            this.lb_orders.Size = new System.Drawing.Size(333, 452);
            this.lb_orders.TabIndex = 1;
            // 
            // categoryTableTableAdapter
            // 
            this.categoryTableTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Masalar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_addToOrder
            // 
            this.btn_addToOrder.Location = new System.Drawing.Point(922, 593);
            this.btn_addToOrder.Name = "btn_addToOrder";
            this.btn_addToOrder.Size = new System.Drawing.Size(75, 43);
            this.btn_addToOrder.TabIndex = 3;
            this.btn_addToOrder.Text = "Ekle";
            this.btn_addToOrder.UseVisualStyleBackColor = true;
            this.btn_addToOrder.Click += new System.EventHandler(this.btn_addToOrder_Click);
            // 
            // btn_removeFromOrder
            // 
            this.btn_removeFromOrder.Location = new System.Drawing.Point(823, 593);
            this.btn_removeFromOrder.Name = "btn_removeFromOrder";
            this.btn_removeFromOrder.Size = new System.Drawing.Size(75, 43);
            this.btn_removeFromOrder.TabIndex = 4;
            this.btn_removeFromOrder.Text = "Sil";
            this.btn_removeFromOrder.UseVisualStyleBackColor = true;
            this.btn_removeFromOrder.Click += new System.EventHandler(this.btn_removeFromOrder_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(823, 551);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 36);
            this.button4.TabIndex = 5;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_get_order
            // 
            this.btn_get_order.Location = new System.Drawing.Point(637, 551);
            this.btn_get_order.Name = "btn_get_order";
            this.btn_get_order.Size = new System.Drawing.Size(75, 36);
            this.btn_get_order.TabIndex = 6;
            this.btn_get_order.Text = "Sipariş";
            this.btn_get_order.UseVisualStyleBackColor = true;
            this.btn_get_order.Click += new System.EventHandler(this.btn_get_order_Click);
            // 
            // btn_get_ticket
            // 
            this.btn_get_ticket.Location = new System.Drawing.Point(637, 594);
            this.btn_get_ticket.Name = "btn_get_ticket";
            this.btn_get_ticket.Size = new System.Drawing.Size(75, 32);
            this.btn_get_ticket.TabIndex = 7;
            this.btn_get_ticket.Text = "Adisyon";
            this.btn_get_ticket.UseVisualStyleBackColor = true;
            this.btn_get_ticket.Click += new System.EventHandler(this.btn_get_ticket_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(922, 551);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 36);
            this.button7.TabIndex = 8;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(664, 508);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(131, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(32, 24);
            this.toolStripButton1.Text = "0,5";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton2.Text = "1";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(32, 24);
            this.toolStripButton3.Text = "1,5";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton4.Text = "2";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(823, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Porsiyon:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_adet
            // 
            this.lbl_adet.AutoSize = true;
            this.lbl_adet.Location = new System.Drawing.Point(973, 514);
            this.lbl_adet.Name = "lbl_adet";
            this.lbl_adet.Size = new System.Drawing.Size(16, 17);
            this.lbl_adet.TabIndex = 10;
            this.lbl_adet.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(935, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Adet:";
            // 
            // lbl_porsiyon
            // 
            this.lbl_porsiyon.AutoSize = true;
            this.lbl_porsiyon.Location = new System.Drawing.Point(887, 514);
            this.lbl_porsiyon.Name = "lbl_porsiyon";
            this.lbl_porsiyon.Size = new System.Drawing.Size(16, 17);
            this.lbl_porsiyon.TabIndex = 12;
            this.lbl_porsiyon.Text = "1";
            // 
            // btn_get_payment
            // 
            this.btn_get_payment.Location = new System.Drawing.Point(720, 551);
            this.btn_get_payment.Name = "btn_get_payment";
            this.btn_get_payment.Size = new System.Drawing.Size(75, 36);
            this.btn_get_payment.TabIndex = 13;
            this.btn_get_payment.Text = "Ödeme";
            this.btn_get_payment.UseVisualStyleBackColor = true;
            this.btn_get_payment.Click += new System.EventHandler(this.btn_get_payment_Click);
            // 
            // btn_get_return
            // 
            this.btn_get_return.Location = new System.Drawing.Point(720, 593);
            this.btn_get_return.Name = "btn_get_return";
            this.btn_get_return.Size = new System.Drawing.Size(75, 33);
            this.btn_get_return.TabIndex = 14;
            this.btn_get_return.Text = "İade";
            this.btn_get_return.UseVisualStyleBackColor = true;
            this.btn_get_return.Click += new System.EventHandler(this.btn_get_return_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.categoryTableBindingSource, "CatName", true));
            this.tabControl1.DataBindings.Add(new System.Windows.Forms.Binding("TabIndex", this.categoryTableBindingSource, "CatName", true));
            this.tabControl1.Location = new System.Drawing.Point(30, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 556);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Siparişler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(885, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Toplam: ";
            // 
            // lbl_order_cost
            // 
            this.lbl_order_cost.AutoSize = true;
            this.lbl_order_cost.Location = new System.Drawing.Point(953, 480);
            this.lbl_order_cost.Name = "lbl_order_cost";
            this.lbl_order_cost.Size = new System.Drawing.Size(37, 17);
            this.lbl_order_cost.TabIndex = 17;
            this.lbl_order_cost.Text = "0 TL";
            // 
            // lbl_order_info
            // 
            this.lbl_order_info.AutoSize = true;
            this.lbl_order_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_order_info.ForeColor = System.Drawing.Color.OliveDrab;
            this.lbl_order_info.Location = new System.Drawing.Point(249, 597);
            this.lbl_order_info.Name = "lbl_order_info";
            this.lbl_order_info.Size = new System.Drawing.Size(0, 20);
            this.lbl_order_info.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(189, 600);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Durum:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1167, 705);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_order_info);
            this.Controls.Add(this.lbl_order_cost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_get_return);
            this.Controls.Add(this.btn_get_payment);
            this.Controls.Add(this.lbl_porsiyon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_adet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btn_get_ticket);
            this.Controls.Add(this.btn_get_order);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_removeFromOrder);
            this.Controls.Add(this.btn_addToOrder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_orders);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = " TESA Restoran Otomasyonu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesaresdbDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lb_orders;
        private tesaresdbDataSet tesaresdbDataSet;
        private System.Windows.Forms.BindingSource categoryTableBindingSource;
        private tesaresdbDataSetTableAdapters.CategoryTableTableAdapter categoryTableTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_addToOrder;
        private System.Windows.Forms.Button btn_removeFromOrder;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_get_order;
        private System.Windows.Forms.Button btn_get_ticket;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_adet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_porsiyon;
        private System.Windows.Forms.Button btn_get_payment;
        private System.Windows.Forms.Button btn_get_return;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_order_cost;
        private System.Windows.Forms.Label lbl_order_info;
        private System.Windows.Forms.Label label5;
    }
}