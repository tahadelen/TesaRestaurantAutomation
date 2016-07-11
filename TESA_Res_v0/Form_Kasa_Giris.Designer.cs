namespace TESA_Res_v0
{
    partial class Form_Kasa_Giris
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
            this.carihesaplar = new System.Windows.Forms.Button();
            this.stok = new System.Windows.Forms.Button();
            this.urunler = new System.Windows.Forms.Button();
            this.adisyonlar = new System.Windows.Forms.Button();
            this.anamenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // carihesaplar
            // 
            this.carihesaplar.Location = new System.Drawing.Point(87, 204);
            this.carihesaplar.Name = "carihesaplar";
            this.carihesaplar.Size = new System.Drawing.Size(160, 109);
            this.carihesaplar.TabIndex = 0;
            this.carihesaplar.Text = "Cari Hesaplar";
            this.carihesaplar.UseVisualStyleBackColor = true;
            this.carihesaplar.Click += new System.EventHandler(this.carihesaplar_Click);
            // 
            // stok
            // 
            this.stok.Location = new System.Drawing.Point(316, 204);
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(160, 109);
            this.stok.TabIndex = 1;
            this.stok.Text = "Stok";
            this.stok.UseVisualStyleBackColor = true;
            this.stok.Click += new System.EventHandler(this.stok_Click);
            // 
            // urunler
            // 
            this.urunler.Location = new System.Drawing.Point(541, 204);
            this.urunler.Name = "urunler";
            this.urunler.Size = new System.Drawing.Size(160, 109);
            this.urunler.TabIndex = 2;
            this.urunler.Text = "Ürünler";
            this.urunler.UseVisualStyleBackColor = true;
            this.urunler.Click += new System.EventHandler(this.urunler_Click);
            // 
            // adisyonlar
            // 
            this.adisyonlar.Location = new System.Drawing.Point(753, 204);
            this.adisyonlar.Name = "adisyonlar";
            this.adisyonlar.Size = new System.Drawing.Size(160, 109);
            this.adisyonlar.TabIndex = 3;
            this.adisyonlar.Text = "Adisyonlar";
            this.adisyonlar.UseVisualStyleBackColor = true;
            this.adisyonlar.Click += new System.EventHandler(this.adisyonlar_Click);
            // 
            // anamenu
            // 
            this.anamenu.Location = new System.Drawing.Point(881, 42);
            this.anamenu.Name = "anamenu";
            this.anamenu.Size = new System.Drawing.Size(83, 41);
            this.anamenu.TabIndex = 5;
            this.anamenu.Text = "GERİ";
            this.anamenu.UseVisualStyleBackColor = true;
            this.anamenu.Click += new System.EventHandler(this.anamenu_Click);
            // 
            // Form_Kasa_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 702);
            this.Controls.Add(this.anamenu);
            this.Controls.Add(this.adisyonlar);
            this.Controls.Add(this.urunler);
            this.Controls.Add(this.stok);
            this.Controls.Add(this.carihesaplar);
            this.Name = "Form_Kasa_Giris";
            this.Text = "Kasa Giriş";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button carihesaplar;
        private System.Windows.Forms.Button stok;
        private System.Windows.Forms.Button urunler;
        private System.Windows.Forms.Button adisyonlar;
        private System.Windows.Forms.Button anamenu;
    }
}