namespace TESA_Res_v0
{
    partial class Form_Customer_Order_Detail
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
            this.label4 = new System.Windows.Forms.Label();
            this.customerType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customerNote = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.Button();
            this.payment_type = new System.Windows.Forms.Button();
            this.completed = new System.Windows.Forms.Button();
            this.anamenu = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.customer_list = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customer_list)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Müşteri Tipi";
            // 
            // customerType
            // 
            this.customerType.Location = new System.Drawing.Point(29, 77);
            this.customerType.Name = "customerType";
            this.customerType.Size = new System.Drawing.Size(100, 20);
            this.customerType.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "İsim Soyisim";
            // 
            // nameSurname
            // 
            this.nameSurname.Location = new System.Drawing.Point(30, 157);
            this.nameSurname.Name = "nameSurname";
            this.nameSurname.Size = new System.Drawing.Size(100, 20);
            this.nameSurname.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Telefon";
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(30, 224);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(100, 20);
            this.phoneNumber.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Adres";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(29, 291);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(450, 20);
            this.address.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(27, 338);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Müşteri Notu";
            // 
            // customerNote
            // 
            this.customerNote.Location = new System.Drawing.Point(29, 373);
            this.customerNote.Name = "customerNote";
            this.customerNote.Size = new System.Drawing.Size(450, 20);
            this.customerNote.TabIndex = 21;
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(30, 447);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(101, 47);
            this.menu.TabIndex = 22;
            this.menu.Text = "MENÜ";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // payment_type
            // 
            this.payment_type.Location = new System.Drawing.Point(181, 447);
            this.payment_type.Name = "payment_type";
            this.payment_type.Size = new System.Drawing.Size(100, 47);
            this.payment_type.TabIndex = 23;
            this.payment_type.Text = "ÖDEME ŞEKLİ";
            this.payment_type.UseVisualStyleBackColor = true;
            // 
            // completed
            // 
            this.completed.Location = new System.Drawing.Point(30, 528);
            this.completed.Name = "completed";
            this.completed.Size = new System.Drawing.Size(101, 46);
            this.completed.TabIndex = 24;
            this.completed.Text = "TAMAMLA";
            this.completed.UseVisualStyleBackColor = true;
            // 
            // anamenu
            // 
            this.anamenu.Location = new System.Drawing.Point(768, 50);
            this.anamenu.Name = "anamenu";
            this.anamenu.Size = new System.Drawing.Size(88, 47);
            this.anamenu.TabIndex = 25;
            this.anamenu.Text = "ANA MENÜ";
            this.anamenu.UseVisualStyleBackColor = true;
            this.anamenu.Click += new System.EventHandler(this.anamenu_Click);
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(873, 50);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(79, 47);
            this.geri.TabIndex = 26;
            this.geri.Text = "GERİ";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // customer_list
            // 
            this.customer_list.ColumnHeadersHeight = 30;
            this.customer_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customer_list.Location = new System.Drawing.Point(552, 117);
            this.customer_list.Name = "customer_list";
            this.customer_list.RowTemplate.Height = 24;
            this.customer_list.Size = new System.Drawing.Size(433, 468);
            this.customer_list.TabIndex = 27;
            // 
            // Form_Customer_Order_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 702);
            this.Controls.Add(this.customer_list);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.anamenu);
            this.Controls.Add(this.completed);
            this.Controls.Add(this.payment_type);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.customerNote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerType);
            this.Controls.Add(this.label4);
            this.Name = "Form_Customer_Order_Detail";
            this.Text = "Müşteri Sipariş Detay";
            this.Load += new System.EventHandler(this.Form_Customer_Order_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customer_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox customerNote;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button payment_type;
        private System.Windows.Forms.Button completed;
        private System.Windows.Forms.Button anamenu;
        private System.Windows.Forms.Button geri;
        public System.Windows.Forms.DataGridView customer_list;
    }
}