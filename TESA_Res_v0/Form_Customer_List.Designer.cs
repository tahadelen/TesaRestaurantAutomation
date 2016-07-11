namespace TESA_Res_v0
{
    partial class Form_Customer_List
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
            this.customer_list = new System.Windows.Forms.DataGridView();
            this.geri = new System.Windows.Forms.Button();
            this.anamenu = new System.Windows.Forms.Button();
            this.musteriDetay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customer_list)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_list
            // 
            this.customer_list.ColumnHeadersHeight = 30;
            this.customer_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customer_list.Location = new System.Drawing.Point(41, 62);
            this.customer_list.Name = "customer_list";
            this.customer_list.RowTemplate.Height = 24;
            this.customer_list.Size = new System.Drawing.Size(927, 578);
            this.customer_list.TabIndex = 2;
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(876, 21);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(92, 35);
            this.geri.TabIndex = 3;
            this.geri.Text = "GERİ";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // anamenu
            // 
            this.anamenu.Location = new System.Drawing.Point(757, 21);
            this.anamenu.Name = "anamenu";
            this.anamenu.Size = new System.Drawing.Size(101, 35);
            this.anamenu.TabIndex = 4;
            this.anamenu.Text = "ANA MENÜ";
            this.anamenu.UseVisualStyleBackColor = true;
            this.anamenu.Click += new System.EventHandler(this.anamenu_Click);
            // 
            // musteriDetay
            // 
            this.musteriDetay.Location = new System.Drawing.Point(839, 653);
            this.musteriDetay.Name = "musteriDetay";
            this.musteriDetay.Size = new System.Drawing.Size(107, 37);
            this.musteriDetay.TabIndex = 5;
            this.musteriDetay.Text = "GİT";
            this.musteriDetay.UseVisualStyleBackColor = true;
            this.musteriDetay.Click += new System.EventHandler(this.musteriDetay_Click);
            // 
            // Form_Customer_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 702);
            this.Controls.Add(this.musteriDetay);
            this.Controls.Add(this.anamenu);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.customer_list);
            this.Name = "Form_Customer_List";
            this.Text = "Form_Customer_List";
            ((System.ComponentModel.ISupportInitialize)(this.customer_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView customer_list;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button anamenu;
        private System.Windows.Forms.Button musteriDetay;
    }
}