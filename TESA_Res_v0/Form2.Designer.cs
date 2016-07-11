namespace TESA_Res_v0
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_exit_program = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_stock = new System.Windows.Forms.Button();
            this.btn_cashreg = new System.Windows.Forms.Button();
            this.btn_caller_list = new System.Windows.Forms.Button();
            this.btn_reports = new System.Windows.Forms.Button();
            this.btn_payment = new System.Windows.Forms.Button();
            this.btn_online_order = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.btn_takeaway_service = new System.Windows.Forms.Button();
            this.btn_tables = new System.Windows.Forms.Button();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_user_l = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tesaresdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tesaresdbDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesaresdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesaresdbDataSet3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "adisyon.jpg");
            this.ımageList1.Images.SetKeyName(1, "cancel.png");
            this.ımageList1.Images.SetKeyName(2, "rapor.png");
            this.ımageList1.Images.SetKeyName(3, "sil.jpg");
            this.ımageList1.Images.SetKeyName(4, "yazdir.png");
            this.ımageList1.Images.SetKeyName(5, "yenile.jpg");
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(847, 645);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(165, 100);
            this.btn_logout.TabIndex = 26;
            this.btn_logout.Text = "Çıkış";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_exit_program
            // 
            this.btn_exit_program.Location = new System.Drawing.Point(6, 645);
            this.btn_exit_program.Name = "btn_exit_program";
            this.btn_exit_program.Size = new System.Drawing.Size(160, 100);
            this.btn_exit_program.TabIndex = 25;
            this.btn_exit_program.Text = "Programı Kapat";
            this.btn_exit_program.UseVisualStyleBackColor = true;
            this.btn_exit_program.Click += new System.EventHandler(this.btn_exit_program_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Location = new System.Drawing.Point(661, 645);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(180, 100);
            this.btn_settings.TabIndex = 24;
            this.btn_settings.Text = "Ayarlar";
            this.btn_settings.UseVisualStyleBackColor = true;
            // 
            // btn_stock
            // 
            this.btn_stock.Location = new System.Drawing.Point(332, 489);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(160, 100);
            this.btn_stock.TabIndex = 23;
            this.btn_stock.Text = "Stok";
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // btn_cashreg
            // 
            this.btn_cashreg.Location = new System.Drawing.Point(169, 489);
            this.btn_cashreg.Name = "btn_cashreg";
            this.btn_cashreg.Size = new System.Drawing.Size(160, 100);
            this.btn_cashreg.TabIndex = 22;
            this.btn_cashreg.Text = "Kasa Giriş";
            this.btn_cashreg.UseVisualStyleBackColor = true;
            this.btn_cashreg.Click += new System.EventHandler(this.btn_cashreg_Click);
            // 
            // btn_caller_list
            // 
            this.btn_caller_list.Location = new System.Drawing.Point(495, 489);
            this.btn_caller_list.Name = "btn_caller_list";
            this.btn_caller_list.Size = new System.Drawing.Size(160, 100);
            this.btn_caller_list.TabIndex = 21;
            this.btn_caller_list.Text = "Arama Listesi";
            this.btn_caller_list.UseVisualStyleBackColor = true;
            // 
            // btn_reports
            // 
            this.btn_reports.Location = new System.Drawing.Point(6, 489);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(160, 100);
            this.btn_reports.TabIndex = 20;
            this.btn_reports.Text = "Raporlar";
            this.btn_reports.UseVisualStyleBackColor = true;
            // 
            // btn_payment
            // 
            this.btn_payment.Location = new System.Drawing.Point(6, 139);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(160, 100);
            this.btn_payment.TabIndex = 19;
            this.btn_payment.Text = "Ödeme";
            this.btn_payment.UseVisualStyleBackColor = true;
            // 
            // btn_online_order
            // 
            this.btn_online_order.Location = new System.Drawing.Point(495, 30);
            this.btn_online_order.Name = "btn_online_order";
            this.btn_online_order.Size = new System.Drawing.Size(160, 100);
            this.btn_online_order.TabIndex = 18;
            this.btn_online_order.Text = "Yemek Sepeti";
            this.btn_online_order.UseVisualStyleBackColor = true;
            // 
            // btn_customers
            // 
            this.btn_customers.Location = new System.Drawing.Point(332, 30);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(160, 100);
            this.btn_customers.TabIndex = 17;
            this.btn_customers.Text = "Müşteriler";
            this.btn_customers.UseVisualStyleBackColor = true;
            this.btn_customers.Click += new System.EventHandler(this.musterilerClicked);
            // 
            // btn_takeaway_service
            // 
            this.btn_takeaway_service.Location = new System.Drawing.Point(169, 30);
            this.btn_takeaway_service.Name = "btn_takeaway_service";
            this.btn_takeaway_service.Size = new System.Drawing.Size(160, 100);
            this.btn_takeaway_service.TabIndex = 16;
            this.btn_takeaway_service.Text = "Paket Servis";
            this.btn_takeaway_service.UseVisualStyleBackColor = true;
            this.btn_takeaway_service.Click += new System.EventHandler(this.btn_takeaway_service_Click);
            // 
            // btn_tables
            // 
            this.btn_tables.Location = new System.Drawing.Point(6, 30);
            this.btn_tables.Margin = new System.Windows.Forms.Padding(6);
            this.btn_tables.Name = "btn_tables";
            this.btn_tables.Size = new System.Drawing.Size(160, 100);
            this.btn_tables.TabIndex = 15;
            this.btn_tables.Text = "Masalar";
            this.btn_tables.UseVisualStyleBackColor = true;
            this.btn_tables.Click += new System.EventHandler(this.btn_tables_Click_1);
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_brand.Location = new System.Drawing.Point(297, 259);
            this.lbl_brand.MaximumSize = new System.Drawing.Size(250, 150);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(174, 52);
            this.lbl_brand.TabIndex = 27;
            this.lbl_brand.Text = "TESA Restoran Otomasyon";
            this.lbl_brand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.dataGridView1.Location = new System.Drawing.Point(689, 30);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(323, 559);
            this.dataGridView1.TabIndex = 28;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "Gelen Arama";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 166;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "Ad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 64;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.HeaderText = "Soyad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 99;
            // 
            // lbl_user_l
            // 
            this.lbl_user_l.AutoSize = true;
            this.lbl_user_l.Location = new System.Drawing.Point(190, 680);
            this.lbl_user_l.Name = "lbl_user_l";
            this.lbl_user_l.Size = new System.Drawing.Size(106, 26);
            this.lbl_user_l.TabIndex = 29;
            this.lbl_user_l.Text = "Kullanıcı :";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(324, 680);
            this.lbl_user.MaximumSize = new System.Drawing.Size(300, 64);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(65, 26);
            this.lbl_user.TabIndex = 30;
            this.lbl_user.Text = "Emre";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 741);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_user_l);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_brand);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_exit_program);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_stock);
            this.Controls.Add(this.btn_cashreg);
            this.Controls.Add(this.btn_caller_list);
            this.Controls.Add(this.btn_reports);
            this.Controls.Add(this.btn_payment);
            this.Controls.Add(this.btn_online_order);
            this.Controls.Add(this.btn_customers);
            this.Controls.Add(this.btn_takeaway_service);
            this.Controls.Add(this.btn_tables);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesaresdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesaresdbDataSet3BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.BindingSource tableTableBindingSource;
        private System.Windows.Forms.BindingSource tesaresdbDataSetBindingSource;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private System.Windows.Forms.BindingSource tesaresdbDataSet3BindingSource;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_exit_program;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.Button btn_cashreg;
        private System.Windows.Forms.Button btn_caller_list;
        private System.Windows.Forms.Button btn_reports;
        private System.Windows.Forms.Button btn_payment;
        private System.Windows.Forms.Button btn_online_order;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Button btn_takeaway_service;
        private System.Windows.Forms.Button btn_tables;
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.Label lbl_user_l;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}