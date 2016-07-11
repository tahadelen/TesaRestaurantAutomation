namespace TESA_Res_v0
{
    partial class Paket_Servis_Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peopleCount = new System.Windows.Forms.Label();
            this.customerCountPlusOne = new System.Windows.Forms.Button();
            this.customerCountMinusOne = new System.Windows.Forms.Button();
            this.customerCountText = new System.Windows.Forms.TextBox();
            this.discount = new System.Windows.Forms.Button();
            this.orderCancelled = new System.Windows.Forms.Button();
            this.orderOption = new System.Windows.Forms.Button();
            this.makeItFree = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.orderCountPlusOne = new System.Windows.Forms.Button();
            this.orderCountMinusOne = new System.Windows.Forms.Button();
            this.orderCount = new System.Windows.Forms.TextBox();
            this.halfPortion = new System.Windows.Forms.Button();
            this.onePorsion = new System.Windows.Forms.Button();
            this.oneandhalfPorsion = new System.Windows.Forms.Button();
            this.twoPorsion = new System.Windows.Forms.Button();
            this.addOrder = new System.Windows.Forms.Button();
            this.removeOrder = new System.Windows.Forms.Button();
            this.carrier = new System.Windows.Forms.Button();
            this.printReceipt = new System.Windows.Forms.Button();
            this.sendOrder = new System.Windows.Forms.Button();
            this.payReceipt = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.anamenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(27, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 333);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(321, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 333);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(722, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(268, 333);
            this.dataGridView1.TabIndex = 4;
            // 
            // peopleCount
            // 
            this.peopleCount.AutoSize = true;
            this.peopleCount.Location = new System.Drawing.Point(24, 449);
            this.peopleCount.Name = "peopleCount";
            this.peopleCount.Size = new System.Drawing.Size(53, 13);
            this.peopleCount.TabIndex = 5;
            this.peopleCount.Text = "Kişi Sayısı";
            // 
            // customerCountPlusOne
            // 
            this.customerCountPlusOne.Location = new System.Drawing.Point(83, 449);
            this.customerCountPlusOne.Name = "customerCountPlusOne";
            this.customerCountPlusOne.Size = new System.Drawing.Size(38, 30);
            this.customerCountPlusOne.TabIndex = 6;
            this.customerCountPlusOne.Text = "+";
            this.customerCountPlusOne.UseVisualStyleBackColor = true;
            this.customerCountPlusOne.Click += new System.EventHandler(this.customerCountPlusOne_Click);
            // 
            // customerCountMinusOne
            // 
            this.customerCountMinusOne.Location = new System.Drawing.Point(138, 449);
            this.customerCountMinusOne.Name = "customerCountMinusOne";
            this.customerCountMinusOne.Size = new System.Drawing.Size(41, 30);
            this.customerCountMinusOne.TabIndex = 8;
            this.customerCountMinusOne.Text = "-";
            this.customerCountMinusOne.UseVisualStyleBackColor = true;
            this.customerCountMinusOne.Click += new System.EventHandler(this.customerCountMinusOne_Click);
            // 
            // customerCountText
            // 
            this.customerCountText.Location = new System.Drawing.Point(207, 449);
            this.customerCountText.Name = "customerCountText";
            this.customerCountText.Size = new System.Drawing.Size(35, 20);
            this.customerCountText.TabIndex = 9;
            this.customerCountText.Text = "2";
            this.customerCountText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // discount
            // 
            this.discount.Location = new System.Drawing.Point(27, 541);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(94, 42);
            this.discount.TabIndex = 10;
            this.discount.Text = "İSKONTO";
            this.discount.UseVisualStyleBackColor = true;
            this.discount.Click += new System.EventHandler(this.discount_Click);
            // 
            // orderCancelled
            // 
            this.orderCancelled.Location = new System.Drawing.Point(138, 541);
            this.orderCancelled.Name = "orderCancelled";
            this.orderCancelled.Size = new System.Drawing.Size(95, 42);
            this.orderCancelled.TabIndex = 11;
            this.orderCancelled.Text = "SİPARİŞ İPTAL";
            this.orderCancelled.UseVisualStyleBackColor = true;
            this.orderCancelled.Click += new System.EventHandler(this.orderCancelled_Click);
            // 
            // orderOption
            // 
            this.orderOption.Location = new System.Drawing.Point(321, 434);
            this.orderOption.Name = "orderOption";
            this.orderOption.Size = new System.Drawing.Size(94, 42);
            this.orderOption.TabIndex = 12;
            this.orderOption.Text = "OPSİYON";
            this.orderOption.UseVisualStyleBackColor = true;
            this.orderOption.Click += new System.EventHandler(this.orderOption_Click);
            // 
            // makeItFree
            // 
            this.makeItFree.Location = new System.Drawing.Point(321, 492);
            this.makeItFree.Name = "makeItFree";
            this.makeItFree.Size = new System.Drawing.Size(94, 42);
            this.makeItFree.TabIndex = 13;
            this.makeItFree.Text = "İKRAM";
            this.makeItFree.UseVisualStyleBackColor = true;
            this.makeItFree.Click += new System.EventHandler(this.makeItFree_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "PORSİYON";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 492);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "ADET:";
            // 
            // orderCountPlusOne
            // 
            this.orderCountPlusOne.Location = new System.Drawing.Point(505, 483);
            this.orderCountPlusOne.Name = "orderCountPlusOne";
            this.orderCountPlusOne.Size = new System.Drawing.Size(38, 30);
            this.orderCountPlusOne.TabIndex = 16;
            this.orderCountPlusOne.Text = "+";
            this.orderCountPlusOne.UseVisualStyleBackColor = true;
            this.orderCountPlusOne.Click += new System.EventHandler(this.orderCountPlusOne_Click);
            // 
            // orderCountMinusOne
            // 
            this.orderCountMinusOne.Location = new System.Drawing.Point(573, 483);
            this.orderCountMinusOne.Name = "orderCountMinusOne";
            this.orderCountMinusOne.Size = new System.Drawing.Size(38, 30);
            this.orderCountMinusOne.TabIndex = 17;
            this.orderCountMinusOne.Text = "-";
            this.orderCountMinusOne.UseVisualStyleBackColor = true;
            this.orderCountMinusOne.Click += new System.EventHandler(this.orderCountMinusOne_Click);
            // 
            // orderCount
            // 
            this.orderCount.Location = new System.Drawing.Point(627, 489);
            this.orderCount.Name = "orderCount";
            this.orderCount.Size = new System.Drawing.Size(35, 20);
            this.orderCount.TabIndex = 18;
            this.orderCount.Text = "1";
            // 
            // halfPortion
            // 
            this.halfPortion.Location = new System.Drawing.Point(505, 425);
            this.halfPortion.Name = "halfPortion";
            this.halfPortion.Size = new System.Drawing.Size(38, 30);
            this.halfPortion.TabIndex = 19;
            this.halfPortion.Text = "0,5";
            this.halfPortion.UseVisualStyleBackColor = true;
            this.halfPortion.Click += new System.EventHandler(this.halfPortion_Click);
            // 
            // onePorsion
            // 
            this.onePorsion.Location = new System.Drawing.Point(549, 425);
            this.onePorsion.Name = "onePorsion";
            this.onePorsion.Size = new System.Drawing.Size(38, 30);
            this.onePorsion.TabIndex = 20;
            this.onePorsion.Text = "1";
            this.onePorsion.UseVisualStyleBackColor = true;
            this.onePorsion.Click += new System.EventHandler(this.onePorsion_Click);
            // 
            // oneandhalfPorsion
            // 
            this.oneandhalfPorsion.Location = new System.Drawing.Point(593, 425);
            this.oneandhalfPorsion.Name = "oneandhalfPorsion";
            this.oneandhalfPorsion.Size = new System.Drawing.Size(38, 30);
            this.oneandhalfPorsion.TabIndex = 21;
            this.oneandhalfPorsion.Text = "1,5";
            this.oneandhalfPorsion.UseVisualStyleBackColor = true;
            this.oneandhalfPorsion.Click += new System.EventHandler(this.oneandhalfPorsion_Click);
            // 
            // twoPorsion
            // 
            this.twoPorsion.Location = new System.Drawing.Point(638, 425);
            this.twoPorsion.Name = "twoPorsion";
            this.twoPorsion.Size = new System.Drawing.Size(38, 30);
            this.twoPorsion.TabIndex = 22;
            this.twoPorsion.Text = "2";
            this.twoPorsion.UseVisualStyleBackColor = true;
            this.twoPorsion.Click += new System.EventHandler(this.twoPorsion_Click);
            // 
            // addOrder
            // 
            this.addOrder.Location = new System.Drawing.Point(668, 483);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(94, 42);
            this.addOrder.TabIndex = 23;
            this.addOrder.Text = "EKLE";
            this.addOrder.UseVisualStyleBackColor = true;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // removeOrder
            // 
            this.removeOrder.Location = new System.Drawing.Point(896, 427);
            this.removeOrder.Name = "removeOrder";
            this.removeOrder.Size = new System.Drawing.Size(94, 42);
            this.removeOrder.TabIndex = 24;
            this.removeOrder.Text = "ÜRÜNÜ ÇIKAR";
            this.removeOrder.UseVisualStyleBackColor = true;
            this.removeOrder.Click += new System.EventHandler(this.removeOrder_Click);
            // 
            // carrier
            // 
            this.carrier.Location = new System.Drawing.Point(321, 639);
            this.carrier.Name = "carrier";
            this.carrier.Size = new System.Drawing.Size(94, 42);
            this.carrier.TabIndex = 25;
            this.carrier.Text = "KURYE";
            this.carrier.UseVisualStyleBackColor = true;
            this.carrier.Click += new System.EventHandler(this.carrier_Click);
            // 
            // printReceipt
            // 
            this.printReceipt.Location = new System.Drawing.Point(465, 639);
            this.printReceipt.Name = "printReceipt";
            this.printReceipt.Size = new System.Drawing.Size(94, 42);
            this.printReceipt.TabIndex = 26;
            this.printReceipt.Text = "ADİSYON YAZDIR";
            this.printReceipt.UseVisualStyleBackColor = true;
            this.printReceipt.Click += new System.EventHandler(this.printReceipt_Click);
            // 
            // sendOrder
            // 
            this.sendOrder.Location = new System.Drawing.Point(593, 639);
            this.sendOrder.Name = "sendOrder";
            this.sendOrder.Size = new System.Drawing.Size(94, 42);
            this.sendOrder.TabIndex = 27;
            this.sendOrder.Text = "GÖNDER";
            this.sendOrder.UseVisualStyleBackColor = true;
            this.sendOrder.Click += new System.EventHandler(this.sendOrder_Click);
            // 
            // payReceipt
            // 
            this.payReceipt.Location = new System.Drawing.Point(738, 639);
            this.payReceipt.Name = "payReceipt";
            this.payReceipt.Size = new System.Drawing.Size(94, 42);
            this.payReceipt.TabIndex = 28;
            this.payReceipt.Text = "ÖDEME";
            this.payReceipt.UseVisualStyleBackColor = true;
            this.payReceipt.Click += new System.EventHandler(this.payReceipt_Click);
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(769, 29);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(79, 34);
            this.geri.TabIndex = 29;
            this.geri.Text = "GERİ";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // anamenu
            // 
            this.anamenu.Location = new System.Drawing.Point(878, 29);
            this.anamenu.Name = "anamenu";
            this.anamenu.Size = new System.Drawing.Size(79, 34);
            this.anamenu.TabIndex = 30;
            this.anamenu.Text = "ANA MENÜ";
            this.anamenu.UseVisualStyleBackColor = true;
            this.anamenu.Click += new System.EventHandler(this.anamenu_Click);
            // 
            // Paket_Servis_Menu
            // 
            this.ClientSize = new System.Drawing.Size(1008, 702);
            this.Controls.Add(this.anamenu);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.payReceipt);
            this.Controls.Add(this.sendOrder);
            this.Controls.Add(this.printReceipt);
            this.Controls.Add(this.carrier);
            this.Controls.Add(this.removeOrder);
            this.Controls.Add(this.addOrder);
            this.Controls.Add(this.twoPorsion);
            this.Controls.Add(this.oneandhalfPorsion);
            this.Controls.Add(this.onePorsion);
            this.Controls.Add(this.halfPortion);
            this.Controls.Add(this.orderCount);
            this.Controls.Add(this.orderCountMinusOne);
            this.Controls.Add(this.orderCountPlusOne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.makeItFree);
            this.Controls.Add(this.orderOption);
            this.Controls.Add(this.orderCancelled);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.customerCountText);
            this.Controls.Add(this.customerCountMinusOne);
            this.Controls.Add(this.customerCountPlusOne);
            this.Controls.Add(this.peopleCount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Paket_Servis_Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deneme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label peopleCount;
        private System.Windows.Forms.Button customerCountPlusOne;
        private System.Windows.Forms.Button customerCountMinusOne;
        private System.Windows.Forms.TextBox customerCountText;
        private System.Windows.Forms.Button discount;
        private System.Windows.Forms.Button orderCancelled;
        private System.Windows.Forms.Button orderOption;
        private System.Windows.Forms.Button makeItFree;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button orderCountPlusOne;
        private System.Windows.Forms.Button orderCountMinusOne;
        private System.Windows.Forms.TextBox orderCount;
        private System.Windows.Forms.Button halfPortion;
        private System.Windows.Forms.Button onePorsion;
        private System.Windows.Forms.Button oneandhalfPorsion;
        private System.Windows.Forms.Button twoPorsion;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.Button removeOrder;
        private System.Windows.Forms.Button carrier;
        private System.Windows.Forms.Button printReceipt;
        private System.Windows.Forms.Button sendOrder;
        private System.Windows.Forms.Button payReceipt;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button anamenu;
    }
}