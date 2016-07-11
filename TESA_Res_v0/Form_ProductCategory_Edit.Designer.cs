namespace TESA_Res_v0
{
    partial class Form_ProductCategory_Edit
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
            this.product_category_list = new System.Windows.Forms.DataGridView();
            this.edit = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.anamenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.product_category_list)).BeginInit();
            this.SuspendLayout();
            // 
            // product_category_list
            // 
            this.product_category_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_category_list.Location = new System.Drawing.Point(24, 28);
            this.product_category_list.Name = "product_category_list";
            this.product_category_list.Size = new System.Drawing.Size(751, 416);
            this.product_category_list.TabIndex = 0;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(755, 576);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(112, 55);
            this.edit.TabIndex = 1;
            this.edit.Text = "DÜZENLE";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(892, 28);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(87, 35);
            this.geri.TabIndex = 2;
            this.geri.Text = "GERİ";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // anamenu
            // 
            this.anamenu.Location = new System.Drawing.Point(797, 26);
            this.anamenu.Name = "anamenu";
            this.anamenu.Size = new System.Drawing.Size(89, 35);
            this.anamenu.TabIndex = 3;
            this.anamenu.Text = "ANA MENÜ";
            this.anamenu.UseVisualStyleBackColor = true;
            this.anamenu.Click += new System.EventHandler(this.anamenu_Click);
            // 
            // Form_ProductCategory_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 702);
            this.Controls.Add(this.anamenu);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.product_category_list);
            this.Name = "Form_ProductCategory_Edit";
            this.Text = "ÜRÜN KATEGORİ DÜZENLE";
            ((System.ComponentModel.ISupportInitialize)(this.product_category_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView product_category_list;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button anamenu;
    }
}