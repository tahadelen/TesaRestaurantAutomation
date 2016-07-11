namespace TESA_Res_v0
{
    partial class Paket_Servis_Opsiyon
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
            this.btn_tables = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.geriButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_tables
            // 
            this.btn_tables.Location = new System.Drawing.Point(563, 199);
            this.btn_tables.Margin = new System.Windows.Forms.Padding(6);
            this.btn_tables.Name = "btn_tables";
            this.btn_tables.Size = new System.Drawing.Size(202, 117);
            this.btn_tables.TabIndex = 16;
            this.btn_tables.Text = "Servis Ekle";
            this.btn_tables.UseVisualStyleBackColor = true;
            this.btn_tables.Click += new System.EventHandler(this.servisEkleClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 199);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 117);
            this.button1.TabIndex = 17;
            this.button1.Text = "Servisleri Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.servisleriListeleClicked);
            // 
            // geriButton
            // 
            this.geriButton.Location = new System.Drawing.Point(874, 22);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(106, 47);
            this.geriButton.TabIndex = 18;
            this.geriButton.Text = "GERİ";
            this.geriButton.UseVisualStyleBackColor = true;
            this.geriButton.Click += new System.EventHandler(this.GERİ_Click);
            // 
            // Paket_Servis_Opsiyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 702);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_tables);
            this.Name = "Paket_Servis_Opsiyon";
            this.Text = "Paket Servis";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_tables;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button geriButton;
    }
}