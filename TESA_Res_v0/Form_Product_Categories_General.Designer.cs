namespace TESA_Res_v0
{
    partial class Form_Product_Categories_General
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
            this.show_categories = new System.Windows.Forms.Button();
            this.add_category = new System.Windows.Forms.Button();
            this.delete_category = new System.Windows.Forms.Button();
            this.change_category = new System.Windows.Forms.Button();
            this.anamenu = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // show_categories
            // 
            this.show_categories.Location = new System.Drawing.Point(185, 187);
            this.show_categories.Name = "show_categories";
            this.show_categories.Size = new System.Drawing.Size(118, 62);
            this.show_categories.TabIndex = 0;
            this.show_categories.Text = "KATEGORİLERİ GÖRÜNTÜLE";
            this.show_categories.UseVisualStyleBackColor = true;
            this.show_categories.Click += new System.EventHandler(this.show_categories_Click);
            // 
            // add_category
            // 
            this.add_category.Location = new System.Drawing.Point(370, 187);
            this.add_category.Name = "add_category";
            this.add_category.Size = new System.Drawing.Size(118, 62);
            this.add_category.TabIndex = 1;
            this.add_category.Text = "KATEGORİ EKLE";
            this.add_category.UseVisualStyleBackColor = true;
            this.add_category.Click += new System.EventHandler(this.add_category_Click);
            // 
            // delete_category
            // 
            this.delete_category.Location = new System.Drawing.Point(533, 187);
            this.delete_category.Name = "delete_category";
            this.delete_category.Size = new System.Drawing.Size(118, 62);
            this.delete_category.TabIndex = 2;
            this.delete_category.Text = "KATEGORİ SİL";
            this.delete_category.UseVisualStyleBackColor = true;
            this.delete_category.Click += new System.EventHandler(this.delete_category_Click);
            // 
            // change_category
            // 
            this.change_category.Location = new System.Drawing.Point(685, 187);
            this.change_category.Name = "change_category";
            this.change_category.Size = new System.Drawing.Size(118, 62);
            this.change_category.TabIndex = 3;
            this.change_category.Text = "KATEGORİ DÜZENLE";
            this.change_category.UseVisualStyleBackColor = true;
            this.change_category.Click += new System.EventHandler(this.change_category_Click);
            // 
            // anamenu
            // 
            this.anamenu.Location = new System.Drawing.Point(770, 47);
            this.anamenu.Name = "anamenu";
            this.anamenu.Size = new System.Drawing.Size(98, 48);
            this.anamenu.TabIndex = 4;
            this.anamenu.Text = "ANA MENÜ";
            this.anamenu.UseVisualStyleBackColor = true;
            this.anamenu.Click += new System.EventHandler(this.anamenu_Click);
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(898, 46);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(98, 49);
            this.geri.TabIndex = 5;
            this.geri.Text = "GERİ";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // Form_Product_Categories_General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 702);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.anamenu);
            this.Controls.Add(this.change_category);
            this.Controls.Add(this.delete_category);
            this.Controls.Add(this.add_category);
            this.Controls.Add(this.show_categories);
            this.Name = "Form_Product_Categories_General";
            this.Text = "Ürün Kategorileri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button show_categories;
        private System.Windows.Forms.Button add_category;
        private System.Windows.Forms.Button delete_category;
        private System.Windows.Forms.Button change_category;
        private System.Windows.Forms.Button anamenu;
        private System.Windows.Forms.Button geri;
    }
}