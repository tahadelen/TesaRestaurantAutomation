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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tesaresdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tesaresdbDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesaresdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesaresdbDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.btn_stock.Location = new System.Drawing.Point(332, 364);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(160, 100);
            this.btn_stock.TabIndex = 23;
            this.btn_stock.Text = "Stok Giriş";
            this.btn_stock.UseVisualStyleBackColor = true;
            // 
            // btn_cashreg
            // 
            this.btn_cashreg.Location = new System.Drawing.Point(169, 364);
            this.btn_cashreg.Name = "btn_cashreg";
            this.btn_cashreg.Size = new System.Drawing.Size(160, 100);
            this.btn_cashreg.TabIndex = 22;
            this.btn_cashreg.Text = "Kasa Giriş";
            this.btn_cashreg.UseVisualStyleBackColor = true;
            // 
            // btn_caller_list
            // 
            this.btn_caller_list.Location = new System.Drawing.Point(495, 364);
            this.btn_caller_list.Name = "btn_caller_list";
            this.btn_caller_list.Size = new System.Drawing.Size(160, 100);
            this.btn_caller_list.TabIndex = 21;
            this.btn_caller_list.Text = "Arama Listesi";
            this.btn_caller_list.UseVisualStyleBackColor = true;
            // 
            // btn_reports
            // 
            this.btn_reports.Location = new System.Drawing.Point(6, 364);
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
            // 
            // btn_takeaway_service
            // 
            this.btn_takeaway_service.Location = new System.Drawing.Point(169, 30);
            this.btn_takeaway_service.Name = "btn_takeaway_service";
            this.btn_takeaway_service.Size = new System.Drawing.Size(160, 100);
            this.btn_takeaway_service.TabIndex = 16;
            this.btn_takeaway_service.Text = "Paket Servis";
            this.btn_takeaway_service.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(300, 204);
            this.label1.MaximumSize = new System.Drawing.Size(250, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 68);
            this.label1.TabIndex = 27;
            this.label1.Text = "TESA Restoran Otomasyon";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle41;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle45;
            this.dataGridView1.Location = new System.Drawing.Point(661, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(351, 434);
            this.dataGridView1.TabIndex = 28;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle42;
            this.Column1.HeaderText = "Gelen Arama";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle43;
            this.Column2.HeaderText = "Ad";
            this.Column2.Name = "Column2";
            this.Column2.Width = 63;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle44;
            this.Column3.HeaderText = "Soyad";
            this.Column3.Name = "Column3";
            this.Column3.Width = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 680);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 29;
            this.label2.Text = "Kullanıcı :";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(324, 680);
            this.lbl_user.MaximumSize = new System.Drawing.Size(300, 64);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(82, 32);
            this.lbl_user.TabIndex = 30;
            this.lbl_user.Text = "Emre";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
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
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesaresdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesaresdbDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_user;
    }
}