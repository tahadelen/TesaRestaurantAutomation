namespace TESA_Res_v0
{
    partial class Musteriler
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
            this.sirketEkle = new System.Windows.Forms.Button();
            this.sahisEkle = new System.Windows.Forms.Button();
            this.musterileriListele = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sirketEkle
            // 
            this.sirketEkle.Location = new System.Drawing.Point(193, 164);
            this.sirketEkle.Name = "sirketEkle";
            this.sirketEkle.Size = new System.Drawing.Size(167, 79);
            this.sirketEkle.TabIndex = 0;
            this.sirketEkle.Text = "Şirket Ekle";
            this.sirketEkle.UseVisualStyleBackColor = true;
            this.sirketEkle.Click += new System.EventHandler(this.sirketEkleClicked);
            // 
            // sahisEkle
            // 
            this.sahisEkle.Location = new System.Drawing.Point(431, 164);
            this.sahisEkle.Name = "sahisEkle";
            this.sahisEkle.Size = new System.Drawing.Size(167, 79);
            this.sahisEkle.TabIndex = 1;
            this.sahisEkle.Text = "Şahıs Ekle";
            this.sahisEkle.UseVisualStyleBackColor = true;
            this.sahisEkle.Click += new System.EventHandler(this.sahisEkle_Click);
            // 
            // musterileriListele
            // 
            this.musterileriListele.Location = new System.Drawing.Point(667, 164);
            this.musterileriListele.Name = "musterileriListele";
            this.musterileriListele.Size = new System.Drawing.Size(167, 79);
            this.musterileriListele.TabIndex = 2;
            this.musterileriListele.Text = "Müşterileri Listele";
            this.musterileriListele.UseVisualStyleBackColor = true;
            this.musterileriListele.Click += new System.EventHandler(this.musterileriListele_Click);
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(878, 42);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(82, 32);
            this.geri.TabIndex = 3;
            this.geri.Text = "GERİ";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 702);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.musterileriListele);
            this.Controls.Add(this.sahisEkle);
            this.Controls.Add(this.sirketEkle);
            this.Name = "Musteriler";
            this.Text = "Musteriler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sirketEkle;
        private System.Windows.Forms.Button sahisEkle;
        private System.Windows.Forms.Button musterileriListele;
        private System.Windows.Forms.Button geri;
    }
}