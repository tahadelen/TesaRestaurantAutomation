namespace TESA_Res_v0
{
    partial class Form_Stock_List
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
            this.dg_stocks = new System.Windows.Forms.DataGridView();
            this.btn_main = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_stocks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stokları Görüntüle";
            // 
            // dg_stocks
            // 
            this.dg_stocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_stocks.Location = new System.Drawing.Point(32, 61);
            this.dg_stocks.Name = "dg_stocks";
            this.dg_stocks.RowTemplate.Height = 24;
            this.dg_stocks.Size = new System.Drawing.Size(927, 578);
            this.dg_stocks.TabIndex = 1;
            // 
            // btn_main
            // 
            this.btn_main.Location = new System.Drawing.Point(553, 656);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(200, 100);
            this.btn_main.TabIndex = 2;
            this.btn_main.Text = "Ana Ekran";
            this.btn_main.UseVisualStyleBackColor = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(759, 656);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(200, 100);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Geri";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Form_Stock_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_main);
            this.Controls.Add(this.dg_stocks);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form_Stock_List";
            this.Text = "Form_Stock_List";
            ((System.ComponentModel.ISupportInitialize)(this.dg_stocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_stocks;
        private System.Windows.Forms.Button btn_main;
        private System.Windows.Forms.Button btn_back;
    }
}