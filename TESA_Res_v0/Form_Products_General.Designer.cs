namespace TESA_Res_v0
{
    partial class Form_Products_General
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
            this.product_categories = new System.Windows.Forms.Button();
            this.products = new System.Windows.Forms.Button();
            this.menus = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.anamenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // product_categories
            // 
            this.product_categories.Location = new System.Drawing.Point(130, 301);
            this.product_categories.Name = "product_categories";
            this.product_categories.Size = new System.Drawing.Size(143, 67);
            this.product_categories.TabIndex = 0;
            this.product_categories.Text = "Ürün Kategorileri";
            this.product_categories.UseVisualStyleBackColor = true;
            this.product_categories.Click += new System.EventHandler(this.product_categories_Click);
            // 
            // products
            // 
            this.products.Location = new System.Drawing.Point(384, 301);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(143, 67);
            this.products.TabIndex = 1;
            this.products.Text = "Ürünler";
            this.products.UseVisualStyleBackColor = true;
            this.products.Click += new System.EventHandler(this.products_Click);
            // 
            // menus
            // 
            this.menus.Location = new System.Drawing.Point(669, 301);
            this.menus.Name = "menus";
            this.menus.Size = new System.Drawing.Size(143, 67);
            this.menus.TabIndex = 2;
            this.menus.Text = "Menüler";
            this.menus.UseVisualStyleBackColor = true;
            this.menus.Click += new System.EventHandler(this.menus_Click);
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(669, 26);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(112, 40);
            this.geri.TabIndex = 3;
            this.geri.Text = "GERİ";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // anamenu
            // 
            this.anamenu.Location = new System.Drawing.Point(817, 26);
            this.anamenu.Name = "anamenu";
            this.anamenu.Size = new System.Drawing.Size(107, 40);
            this.anamenu.TabIndex = 4;
            this.anamenu.Text = "ANA MENÜ";
            this.anamenu.UseVisualStyleBackColor = true;
            this.anamenu.Click += new System.EventHandler(this.anamenu_Click);
            // 
            // Form_Products_General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 702);
            this.Controls.Add(this.anamenu);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.menus);
            this.Controls.Add(this.products);
            this.Controls.Add(this.product_categories);
            this.Name = "Form_Products_General";
            this.Text = "Form_Products_General";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button product_categories;
        private System.Windows.Forms.Button products;
        private System.Windows.Forms.Button menus;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button anamenu;
    }
}