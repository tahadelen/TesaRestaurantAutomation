namespace TESA_Res_v0
{
    partial class Form_Items
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
            this.lbl_item_name = new System.Windows.Forms.Label();
            this.tb_item_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_stock_warn = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel_item_unit = new System.Windows.Forms.Panel();
            this.lblWarning = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.panel_item_unit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_item_name
            // 
            this.lbl_item_name.AutoSize = true;
            this.lbl_item_name.Location = new System.Drawing.Point(136, 148);
            this.lbl_item_name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_item_name.Name = "lbl_item_name";
            this.lbl_item_name.Size = new System.Drawing.Size(194, 32);
            this.lbl_item_name.TabIndex = 0;
            this.lbl_item_name.Text = "Malzeme Adı :";
            // 
            // tb_item_name
            // 
            this.tb_item_name.Location = new System.Drawing.Point(382, 145);
            this.tb_item_name.Margin = new System.Windows.Forms.Padding(6);
            this.tb_item_name.Name = "tb_item_name";
            this.tb_item_name.Size = new System.Drawing.Size(196, 38);
            this.tb_item_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Birimi : ";
            // 
            // tb_stock_warn
            // 
            this.tb_stock_warn.Location = new System.Drawing.Point(382, 423);
            this.tb_stock_warn.Margin = new System.Windows.Forms.Padding(6);
            this.tb_stock_warn.Name = "tb_stock_warn";
            this.tb_stock_warn.Size = new System.Drawing.Size(196, 38);
            this.tb_stock_warn.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 6);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 36);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "Kg";
            this.radioButton1.Text = "Kg";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 54);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 36);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "Adet";
            this.radioButton2.Text = "Adet";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 424);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stok Uyarı Sınırı :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(617, 618);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(230, 101);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(142, 618);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(230, 101);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel_item_unit
            // 
            this.panel_item_unit.Controls.Add(this.radioButton1);
            this.panel_item_unit.Controls.Add(this.radioButton2);
            this.panel_item_unit.Location = new System.Drawing.Point(382, 217);
            this.panel_item_unit.Name = "panel_item_unit";
            this.panel_item_unit.Size = new System.Drawing.Size(200, 100);
            this.panel_item_unit.TabIndex = 9;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Enabled = false;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(142, 560);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(595, 32);
            this.lblWarning.TabIndex = 10;
            this.lblWarning.Text = "* Lütfen tüm alanları uygun olarak doldurunuz.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Stok Miktarı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Stok Ekle";
            // 
            // tb_number
            // 
            this.tb_number.Location = new System.Drawing.Point(382, 329);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(196, 38);
            this.tb_number.TabIndex = 13;
            // 
            // Form_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.tb_number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.panel_item_unit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_stock_warn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_item_name);
            this.Controls.Add(this.lbl_item_name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form_Items";
            this.Text = "Malzeme Ekle";
            this.panel_item_unit.ResumeLayout(false);
            this.panel_item_unit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_item_name;
        protected System.Windows.Forms.TextBox tb_item_name;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox tb_stock_warn;
        protected System.Windows.Forms.RadioButton radioButton1;
        protected System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel_item_unit;
        protected System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox tb_number;
    }
}