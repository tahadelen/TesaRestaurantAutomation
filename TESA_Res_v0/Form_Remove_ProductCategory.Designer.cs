namespace TESA_Res_v0
{
    partial class Form_Remove_ProductCategory
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
            this.product_category = new System.Windows.Forms.DataGridView();
            this.remove = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.anamenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.product_category)).BeginInit();
            this.SuspendLayout();
            // 
            // product_category
            // 
            this.product_category.ColumnHeadersHeight = 30;
            this.product_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.product_category.Location = new System.Drawing.Point(41, 62);
            this.product_category.Name = "product_category";
            this.product_category.RowTemplate.Height = 24;
            this.product_category.Size = new System.Drawing.Size(785, 578);
            this.product_category.TabIndex = 3;
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(797, 646);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(103, 44);
            this.remove.TabIndex = 4;
            this.remove.Text = "SİL";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(815, 22);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(85, 34);
            this.geri.TabIndex = 5;
            this.geri.Text = "GERİ";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // anamenu
            // 
            this.anamenu.Location = new System.Drawing.Point(921, 22);
            this.anamenu.Name = "anamenu";
            this.anamenu.Size = new System.Drawing.Size(75, 34);
            this.anamenu.TabIndex = 6;
            this.anamenu.Text = "ANA MENÜ";
            this.anamenu.UseVisualStyleBackColor = true;
            this.anamenu.Click += new System.EventHandler(this.anamenu_Click);
            // 
            // Form_Remove_ProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 702);
            this.Controls.Add(this.anamenu);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.product_category);
            this.Name = "Form_Remove_ProductCategory";
            this.Text = "KATEGORİ SİL";
            ((System.ComponentModel.ISupportInitialize)(this.product_category)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView product_category;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button anamenu;
    }
}