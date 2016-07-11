namespace TESA_Res_v0
{
    partial class Form_Show_Products
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
            this.category_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.main = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // category_combobox
            // 
            this.category_combobox.FormattingEnabled = true;
            this.category_combobox.Location = new System.Drawing.Point(55, 47);
            this.category_combobox.Name = "category_combobox";
            this.category_combobox.Size = new System.Drawing.Size(121, 21);
            this.category_combobox.TabIndex = 0;
            this.category_combobox.SelectedIndexChanged += new System.EventHandler(this.category_combobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "KATEGORİYE GÖRE LİSTELE";
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(215, 47);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 2;
            this.show.Text = "LİSTELE";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(758, 47);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(81, 38);
            this.back.TabIndex = 3;
            this.back.Text = "GERİ";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // main
            // 
            this.main.Location = new System.Drawing.Point(877, 47);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(78, 38);
            this.main.TabIndex = 4;
            this.main.Text = "ANA MENÜ";
            this.main.UseVisualStyleBackColor = true;
            this.main.Click += new System.EventHandler(this.main_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(659, 590);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(78, 38);
            this.remove.TabIndex = 5;
            this.remove.Text = "SİL";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // Form_Show_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 702);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.main);
            this.Controls.Add(this.back);
            this.Controls.Add(this.show);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.category_combobox);
            this.Name = "Form_Show_Products";
            this.Text = "ÜRÜNLER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox category_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button main;
        private System.Windows.Forms.Button remove;
    }
}