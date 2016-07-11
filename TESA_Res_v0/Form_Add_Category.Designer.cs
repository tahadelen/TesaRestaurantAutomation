namespace TESA_Res_v0
{
    partial class Form_Add_Category
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
            this.label1 = new System.Windows.Forms.Label();
            this.category_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.category_description = new System.Windows.Forms.TextBox();
            this.select_image = new System.Windows.Forms.Button();
            this.category_image = new System.Windows.Forms.PictureBox();
            this.add_category = new System.Windows.Forms.Button();
            this.anamenu = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.category_image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kategori İsmi";
            // 
            // category_name
            // 
            this.category_name.Location = new System.Drawing.Point(51, 91);
            this.category_name.Name = "category_name";
            this.category_name.Size = new System.Drawing.Size(166, 20);
            this.category_name.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kategori Açıklama";
            // 
            // category_description
            // 
            this.category_description.Location = new System.Drawing.Point(51, 177);
            this.category_description.Name = "category_description";
            this.category_description.Size = new System.Drawing.Size(166, 20);
            this.category_description.TabIndex = 8;
            // 
            // select_image
            // 
            this.select_image.Location = new System.Drawing.Point(51, 281);
            this.select_image.Name = "select_image";
            this.select_image.Size = new System.Drawing.Size(116, 43);
            this.select_image.TabIndex = 9;
            this.select_image.Text = "Fotoğraf Seç";
            this.select_image.UseVisualStyleBackColor = true;
            this.select_image.Click += new System.EventHandler(this.select_image_Click);
            // 
            // category_image
            // 
            this.category_image.Location = new System.Drawing.Point(51, 217);
            this.category_image.Name = "category_image";
            this.category_image.Size = new System.Drawing.Size(114, 58);
            this.category_image.TabIndex = 10;
            this.category_image.TabStop = false;
            // 
            // add_category
            // 
            this.add_category.Location = new System.Drawing.Point(51, 371);
            this.add_category.Name = "add_category";
            this.add_category.Size = new System.Drawing.Size(116, 43);
            this.add_category.TabIndex = 11;
            this.add_category.Text = "Kategori Ekle";
            this.add_category.UseVisualStyleBackColor = true;
            this.add_category.Click += new System.EventHandler(this.add_category_Click);
            // 
            // anamenu
            // 
            this.anamenu.Location = new System.Drawing.Point(747, 57);
            this.anamenu.Name = "anamenu";
            this.anamenu.Size = new System.Drawing.Size(91, 54);
            this.anamenu.TabIndex = 12;
            this.anamenu.Text = "ANA MENÜ";
            this.anamenu.UseVisualStyleBackColor = true;
            this.anamenu.Click += new System.EventHandler(this.anamenu_Click);
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(862, 57);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(91, 54);
            this.geri.TabIndex = 13;
            this.geri.Text = "GERİ";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(213, 281);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(116, 43);
            this.save.TabIndex = 14;
            this.save.Text = "Kaydet";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Form_Add_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 702);
            this.Controls.Add(this.save);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.anamenu);
            this.Controls.Add(this.add_category);
            this.Controls.Add(this.category_image);
            this.Controls.Add(this.select_image);
            this.Controls.Add(this.category_description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.category_name);
            this.Controls.Add(this.label1);
            this.Name = "Form_Add_Category";
            this.Text = "Kategori Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.category_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox category_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox category_description;
        private System.Windows.Forms.Button select_image;
        private System.Windows.Forms.PictureBox category_image;
        private System.Windows.Forms.Button add_category;
        private System.Windows.Forms.Button anamenu;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button save;
    }
}