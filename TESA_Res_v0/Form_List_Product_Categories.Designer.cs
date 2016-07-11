namespace TESA_Res_v0
{
    partial class Form_List_Product_Categories
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
            this.anamenu = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // anamenu
            // 
            this.anamenu.Location = new System.Drawing.Point(704, 51);
            this.anamenu.Name = "anamenu";
            this.anamenu.Size = new System.Drawing.Size(99, 35);
            this.anamenu.TabIndex = 3;
            this.anamenu.Text = "ANA MENÜ";
            this.anamenu.UseVisualStyleBackColor = true;
            this.anamenu.Click += new System.EventHandler(this.anamenu_Click);
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(593, 51);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(89, 35);
            this.geri.TabIndex = 4;
            this.geri.Text = "GERİ";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click_1);
            // 
            // Form_List_Product_Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 702);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.anamenu);
            this.Name = "Form_List_Product_Categories";
            this.Text = "Ürün Kategorileri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button anamenu;
        private System.Windows.Forms.Button geri;
    }
}