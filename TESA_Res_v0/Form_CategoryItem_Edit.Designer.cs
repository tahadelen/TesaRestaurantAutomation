﻿namespace TESA_Res_v0
{
    partial class Form_CategoryItem_Edit
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
            this.label3 = new System.Windows.Forms.Label();
            this.category_desc = new System.Windows.Forms.TextBox();
            this.category_image = new System.Windows.Forms.PictureBox();
            this.select_image = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.edit_category = new System.Windows.Forms.Button();
            this.anamenu = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.category_image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kategori İsmi";
            // 
            // category_name
            // 
            this.category_name.Location = new System.Drawing.Point(32, 70);
            this.category_name.Name = "category_name";
            this.category_name.Size = new System.Drawing.Size(166, 20);
            this.category_name.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Kategori Açıklama";
            // 
            // category_desc
            // 
            this.category_desc.Location = new System.Drawing.Point(32, 159);
            this.category_desc.Name = "category_desc";
            this.category_desc.Size = new System.Drawing.Size(166, 20);
            this.category_desc.TabIndex = 17;
            // 
            // category_image
            // 
            this.category_image.Location = new System.Drawing.Point(34, 198);
            this.category_image.Name = "category_image";
            this.category_image.Size = new System.Drawing.Size(114, 58);
            this.category_image.TabIndex = 18;
            this.category_image.TabStop = false;
            // 
            // select_image
            // 
            this.select_image.Location = new System.Drawing.Point(32, 276);
            this.select_image.Name = "select_image";
            this.select_image.Size = new System.Drawing.Size(116, 43);
            this.select_image.TabIndex = 19;
            this.select_image.Text = "Fotoğraf Seç";
            this.select_image.UseVisualStyleBackColor = true;
            this.select_image.Click += new System.EventHandler(this.select_image_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(181, 276);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(116, 43);
            this.save.TabIndex = 20;
            this.save.Text = "Kaydet";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // edit_category
            // 
            this.edit_category.Location = new System.Drawing.Point(34, 372);
            this.edit_category.Name = "edit_category";
            this.edit_category.Size = new System.Drawing.Size(116, 43);
            this.edit_category.TabIndex = 21;
            this.edit_category.Text = "Kategori Düzenle";
            this.edit_category.UseVisualStyleBackColor = true;
            this.edit_category.Click += new System.EventHandler(this.edit_category_Click);
            // 
            // anamenu
            // 
            this.anamenu.Location = new System.Drawing.Point(740, 121);
            this.anamenu.Name = "anamenu";
            this.anamenu.Size = new System.Drawing.Size(91, 54);
            this.anamenu.TabIndex = 22;
            this.anamenu.Text = "ANA MENÜ";
            this.anamenu.UseVisualStyleBackColor = true;
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(878, 121);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(91, 54);
            this.geri.TabIndex = 23;
            this.geri.Text = "GERİ";
            this.geri.UseVisualStyleBackColor = true;
            // 
            // Form_CategoryItem_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 702);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.anamenu);
            this.Controls.Add(this.edit_category);
            this.Controls.Add(this.save);
            this.Controls.Add(this.select_image);
            this.Controls.Add(this.category_image);
            this.Controls.Add(this.category_desc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.category_name);
            this.Controls.Add(this.label1);
            this.Name = "Form_CategoryItem_Edit";
            this.Text = "Form_CategoryItem_Edit";
            ((System.ComponentModel.ISupportInitialize)(this.category_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox category_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox category_desc;
        private System.Windows.Forms.PictureBox category_image;
        private System.Windows.Forms.Button select_image;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button edit_category;
        private System.Windows.Forms.Button anamenu;
        private System.Windows.Forms.Button geri;
    }
}