namespace TESA_Res_v0
{
    partial class Form_Stock
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_stock_add = new System.Windows.Forms.Button();
            this.btn_stock_view = new System.Windows.Forms.Button();
            this.btn_stock_edit = new System.Windows.Forms.Button();
            this.btn_stock_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(852, 29);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(160, 80);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Geri";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_stock_add
            // 
            this.btn_stock_add.Location = new System.Drawing.Point(142, 291);
            this.btn_stock_add.Name = "btn_stock_add";
            this.btn_stock_add.Size = new System.Drawing.Size(300, 100);
            this.btn_stock_add.TabIndex = 1;
            this.btn_stock_add.Text = "Stok Ekle";
            this.btn_stock_add.UseVisualStyleBackColor = true;
            this.btn_stock_add.Click += new System.EventHandler(this.btn_stock_add_Click);
            // 
            // btn_stock_view
            // 
            this.btn_stock_view.Location = new System.Drawing.Point(518, 290);
            this.btn_stock_view.Name = "btn_stock_view";
            this.btn_stock_view.Size = new System.Drawing.Size(300, 100);
            this.btn_stock_view.TabIndex = 2;
            this.btn_stock_view.Text = "Stokları Görüntüle";
            this.btn_stock_view.UseVisualStyleBackColor = true;
            this.btn_stock_view.Click += new System.EventHandler(this.btn_stock_view_Click);
            // 
            // btn_stock_edit
            // 
            this.btn_stock_edit.Location = new System.Drawing.Point(142, 461);
            this.btn_stock_edit.Name = "btn_stock_edit";
            this.btn_stock_edit.Size = new System.Drawing.Size(300, 100);
            this.btn_stock_edit.TabIndex = 3;
            this.btn_stock_edit.Text = "Stokları Düzenle";
            this.btn_stock_edit.UseVisualStyleBackColor = true;
            this.btn_stock_edit.Click += new System.EventHandler(this.btn_stock_edit_Click);
            // 
            // btn_stock_delete
            // 
            this.btn_stock_delete.Location = new System.Drawing.Point(518, 461);
            this.btn_stock_delete.Name = "btn_stock_delete";
            this.btn_stock_delete.Size = new System.Drawing.Size(300, 100);
            this.btn_stock_delete.TabIndex = 4;
            this.btn_stock_delete.Text = "Stoktan Sil";
            this.btn_stock_delete.UseVisualStyleBackColor = true;
            this.btn_stock_delete.Click += new System.EventHandler(this.btn_stock_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Stok";
            // 
            // Form_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_stock_delete);
            this.Controls.Add(this.btn_stock_edit);
            this.Controls.Add(this.btn_stock_view);
            this.Controls.Add(this.btn_stock_add);
            this.Controls.Add(this.btn_back);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form_Stock";
            this.Text = "Form_Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_stock_add;
        private System.Windows.Forms.Button btn_stock_view;
        private System.Windows.Forms.Button btn_stock_edit;
        private System.Windows.Forms.Button btn_stock_delete;
        private System.Windows.Forms.Label label1;
    }
}