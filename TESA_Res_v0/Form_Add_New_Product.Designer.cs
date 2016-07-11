namespace TESA_Res_v0
{
    partial class Form_Add_New_Product
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_product_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.product_cat_combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.product_desc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.product_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.prepTime = new System.Windows.Forms.TextBox();
            this.prepPlace = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.productImage = new System.Windows.Forms.PictureBox();
            this.select_image = new System.Windows.Forms.Button();
            this.prepİngre = new System.Windows.Forms.Button();
            this.add_product = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.mainmenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ürün Adı";
            // 
            // tb_product_name
            // 
            this.tb_product_name.Location = new System.Drawing.Point(38, 67);
            this.tb_product_name.Name = "tb_product_name";
            this.tb_product_name.Size = new System.Drawing.Size(266, 20);
            this.tb_product_name.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ürün Kategori";
            // 
            // product_cat_combo
            // 
            this.product_cat_combo.FormattingEnabled = true;
            this.product_cat_combo.Location = new System.Drawing.Point(38, 132);
            this.product_cat_combo.Name = "product_cat_combo";
            this.product_cat_combo.Size = new System.Drawing.Size(121, 21);
            this.product_cat_combo.TabIndex = 11;
            this.product_cat_combo.SelectedIndexChanged += new System.EventHandler(this.product_cat_combo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ürün Açıklama";
            // 
            // product_desc
            // 
            this.product_desc.Location = new System.Drawing.Point(41, 224);
            this.product_desc.Name = "product_desc";
            this.product_desc.Size = new System.Drawing.Size(266, 20);
            this.product_desc.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(35, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Porsiyon Fiyatı";
            // 
            // product_price
            // 
            this.product_price.Location = new System.Drawing.Point(38, 299);
            this.product_price.Name = "product_price";
            this.product_price.Size = new System.Drawing.Size(84, 20);
            this.product_price.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(469, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ürün Hazırlanma Süresi";
            // 
            // prepTime
            // 
            this.prepTime.Location = new System.Drawing.Point(472, 67);
            this.prepTime.Name = "prepTime";
            this.prepTime.Size = new System.Drawing.Size(266, 20);
            this.prepTime.TabIndex = 17;
            // 
            // prepPlace
            // 
            this.prepPlace.FormattingEnabled = true;
            this.prepPlace.Location = new System.Drawing.Point(472, 132);
            this.prepPlace.Name = "prepPlace";
            this.prepPlace.Size = new System.Drawing.Size(121, 21);
            this.prepPlace.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(472, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ürün Hazırlanma Yeri";
            // 
            // productImage
            // 
            this.productImage.Location = new System.Drawing.Point(475, 182);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(100, 50);
            this.productImage.TabIndex = 20;
            this.productImage.TabStop = false;
            // 
            // select_image
            // 
            this.select_image.Location = new System.Drawing.Point(602, 193);
            this.select_image.Name = "select_image";
            this.select_image.Size = new System.Drawing.Size(94, 38);
            this.select_image.TabIndex = 21;
            this.select_image.Text = "Resim Seç";
            this.select_image.UseVisualStyleBackColor = true;
            this.select_image.Click += new System.EventHandler(this.select_image_Click);
            // 
            // prepİngre
            // 
            this.prepİngre.Location = new System.Drawing.Point(475, 257);
            this.prepİngre.Name = "prepİngre";
            this.prepİngre.Size = new System.Drawing.Size(94, 38);
            this.prepİngre.TabIndex = 22;
            this.prepİngre.Text = "Reçete Oluştur";
            this.prepİngre.UseVisualStyleBackColor = true;
            // 
            // add_product
            // 
            this.add_product.Location = new System.Drawing.Point(321, 365);
            this.add_product.Name = "add_product";
            this.add_product.Size = new System.Drawing.Size(164, 81);
            this.add_product.TabIndex = 23;
            this.add_product.Text = "Ürün Ekle";
            this.add_product.UseVisualStyleBackColor = true;
            this.add_product.Click += new System.EventHandler(this.add_product_Click);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(774, 49);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(94, 38);
            this.backbutton.TabIndex = 24;
            this.backbutton.Text = "GERİ";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // mainmenu
            // 
            this.mainmenu.Location = new System.Drawing.Point(888, 49);
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.Size = new System.Drawing.Size(94, 38);
            this.mainmenu.TabIndex = 25;
            this.mainmenu.Text = "ANA MENÜ";
            this.mainmenu.UseVisualStyleBackColor = true;
            this.mainmenu.Click += new System.EventHandler(this.mainmenu_Click);
            // 
            // Form_Add_New_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 702);
            this.Controls.Add(this.mainmenu);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.add_product);
            this.Controls.Add(this.prepİngre);
            this.Controls.Add(this.select_image);
            this.Controls.Add(this.productImage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prepPlace);
            this.Controls.Add(this.prepTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.product_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.product_desc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.product_cat_combo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_product_name);
            this.Controls.Add(this.label2);
            this.Name = "Form_Add_New_Product";
            this.Text = "Yeni Ürün Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_product_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox product_cat_combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox product_desc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox product_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prepTime;
        private System.Windows.Forms.ComboBox prepPlace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox productImage;
        private System.Windows.Forms.Button select_image;
        private System.Windows.Forms.Button prepİngre;
        private System.Windows.Forms.Button add_product;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button mainmenu;
    }
}