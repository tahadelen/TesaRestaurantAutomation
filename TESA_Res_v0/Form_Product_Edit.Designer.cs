namespace TESA_Res_v0
{
    partial class Form_Product_Edit
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
            this.category_combobox = new System.Windows.Forms.ComboBox();
            this.show = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.anamenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "KATEGORİYE GÖRE LİSTELE";
            // 
            // category_combobox
            // 
            this.category_combobox.FormattingEnabled = true;
            this.category_combobox.Location = new System.Drawing.Point(27, 37);
            this.category_combobox.Name = "category_combobox";
            this.category_combobox.Size = new System.Drawing.Size(121, 21);
            this.category_combobox.TabIndex = 3;
            this.category_combobox.SelectedIndexChanged += new System.EventHandler(this.category_combobox_SelectedIndexChanged);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(187, 37);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 4;
            this.show.Text = "LİSTELE";
            this.show.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(756, 35);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(81, 39);
            this.back.TabIndex = 5;
            this.back.Text = "GERİ";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // anamenu
            // 
            this.anamenu.Location = new System.Drawing.Point(867, 35);
            this.anamenu.Name = "anamenu";
            this.anamenu.Size = new System.Drawing.Size(82, 39);
            this.anamenu.TabIndex = 6;
            this.anamenu.Text = "ANA MENÜ";
            this.anamenu.UseVisualStyleBackColor = true;
            this.anamenu.Click += new System.EventHandler(this.anamenu_Click);
            // 
            // Form_Product_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 702);
            this.Controls.Add(this.anamenu);
            this.Controls.Add(this.back);
            this.Controls.Add(this.show);
            this.Controls.Add(this.category_combobox);
            this.Controls.Add(this.label1);
            this.Name = "Form_Product_Edit";
            this.Text = "Ürün Güncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox category_combobox;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button anamenu;
    }
}