namespace TESA_Res_v0
{
    partial class Form_Product_Options
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
            this.show_products = new System.Windows.Forms.Button();
            this.add_product = new System.Windows.Forms.Button();
            this.remove_product = new System.Windows.Forms.Button();
            this.edit_product = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.anamenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // show_products
            // 
            this.show_products.Location = new System.Drawing.Point(114, 206);
            this.show_products.Name = "show_products";
            this.show_products.Size = new System.Drawing.Size(148, 113);
            this.show_products.TabIndex = 0;
            this.show_products.Text = "ÜRÜNLERİ GÖRÜNTÜLE";
            this.show_products.UseVisualStyleBackColor = true;
            this.show_products.Click += new System.EventHandler(this.show_products_Click);
            // 
            // add_product
            // 
            this.add_product.Location = new System.Drawing.Point(339, 206);
            this.add_product.Name = "add_product";
            this.add_product.Size = new System.Drawing.Size(148, 113);
            this.add_product.TabIndex = 1;
            this.add_product.Text = "ÜRÜN EKLE";
            this.add_product.UseVisualStyleBackColor = true;
            this.add_product.Click += new System.EventHandler(this.add_product_Click);
            // 
            // remove_product
            // 
            this.remove_product.Location = new System.Drawing.Point(580, 206);
            this.remove_product.Name = "remove_product";
            this.remove_product.Size = new System.Drawing.Size(148, 113);
            this.remove_product.TabIndex = 2;
            this.remove_product.Text = "ÜRÜN SİL";
            this.remove_product.UseVisualStyleBackColor = true;
            this.remove_product.Click += new System.EventHandler(this.remove_product_Click);
            // 
            // edit_product
            // 
            this.edit_product.Location = new System.Drawing.Point(805, 204);
            this.edit_product.Name = "edit_product";
            this.edit_product.Size = new System.Drawing.Size(148, 113);
            this.edit_product.TabIndex = 3;
            this.edit_product.Text = "ÜRÜN DÜZENLE";
            this.edit_product.UseVisualStyleBackColor = true;
            this.edit_product.Click += new System.EventHandler(this.edit_product_Click);
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(753, 40);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(86, 38);
            this.geri.TabIndex = 4;
            this.geri.Text = "GERİ";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // anamenu
            // 
            this.anamenu.Location = new System.Drawing.Point(878, 40);
            this.anamenu.Name = "anamenu";
            this.anamenu.Size = new System.Drawing.Size(84, 38);
            this.anamenu.TabIndex = 5;
            this.anamenu.Text = "ANA MENÜ";
            this.anamenu.UseVisualStyleBackColor = true;
            this.anamenu.Click += new System.EventHandler(this.anamenu_Click);
            // 
            // Form_Product_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 702);
            this.Controls.Add(this.anamenu);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.edit_product);
            this.Controls.Add(this.remove_product);
            this.Controls.Add(this.add_product);
            this.Controls.Add(this.show_products);
            this.Name = "Form_Product_Options";
            this.Text = "Ürünler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button show_products;
        private System.Windows.Forms.Button add_product;
        private System.Windows.Forms.Button remove_product;
        private System.Windows.Forms.Button edit_product;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button anamenu;
    }
}