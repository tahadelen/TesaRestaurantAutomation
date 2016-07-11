namespace TESA_Res_v0
{
    partial class Form3
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
            this.button10 = new System.Windows.Forms.Button();
            this.btn_table_concat = new System.Windows.Forms.Button();
            this.btn_table_move = new System.Windows.Forms.Button();
            this.btnNextTables = new System.Windows.Forms.Button();
            this.btnPrevTables = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.btn_table_separate = new System.Windows.Forms.Button();
            this.lbl_floor = new System.Windows.Forms.Label();
            this.gb_tables = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(816, 9);
            this.button10.Margin = new System.Windows.Forms.Padding(6);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(144, 45);
            this.button10.TabIndex = 9;
            this.button10.Text = "GERİ";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // btn_table_concat
            // 
            this.btn_table_concat.Location = new System.Drawing.Point(156, 611);
            this.btn_table_concat.Margin = new System.Windows.Forms.Padding(6);
            this.btn_table_concat.Name = "btn_table_concat";
            this.btn_table_concat.Size = new System.Drawing.Size(130, 110);
            this.btn_table_concat.TabIndex = 10;
            this.btn_table_concat.Text = "Masa Birleştir";
            this.btn_table_concat.UseVisualStyleBackColor = true;
            this.btn_table_concat.Click += new System.EventHandler(this.tableConcat_Click);
            // 
            // btn_table_move
            // 
            this.btn_table_move.Location = new System.Drawing.Point(15, 611);
            this.btn_table_move.Margin = new System.Windows.Forms.Padding(6);
            this.btn_table_move.Name = "btn_table_move";
            this.btn_table_move.Size = new System.Drawing.Size(130, 110);
            this.btn_table_move.TabIndex = 11;
            this.btn_table_move.Text = "Masa Taşı";
            this.btn_table_move.UseVisualStyleBackColor = true;
            // 
            // btnNextTables
            // 
            this.btnNextTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNextTables.Location = new System.Drawing.Point(737, 521);
            this.btnNextTables.Margin = new System.Windows.Forms.Padding(6);
            this.btnNextTables.Name = "btnNextTables";
            this.btnNextTables.Size = new System.Drawing.Size(100, 78);
            this.btnNextTables.TabIndex = 12;
            this.btnNextTables.Text = ">";
            this.btnNextTables.UseVisualStyleBackColor = true;
            this.btnNextTables.Click += new System.EventHandler(this.btnNextTables_Click);
            // 
            // btnPrevTables
            // 
            this.btnPrevTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrevTables.Location = new System.Drawing.Point(625, 521);
            this.btnPrevTables.Margin = new System.Windows.Forms.Padding(6);
            this.btnPrevTables.Name = "btnPrevTables";
            this.btnPrevTables.Size = new System.Drawing.Size(100, 78);
            this.btnPrevTables.TabIndex = 13;
            this.btnPrevTables.Text = "<";
            this.btnPrevTables.UseVisualStyleBackColor = true;
            this.btnPrevTables.Click += new System.EventHandler(this.btnPrevTables_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 742);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kullanıcı:";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userName.Location = new System.Drawing.Point(101, 742);
            this.userName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(35, 13);
            this.userName.TabIndex = 15;
            this.userName.Text = "Emre";
            // 
            // btn_table_separate
            // 
            this.btn_table_separate.Location = new System.Drawing.Point(297, 611);
            this.btn_table_separate.Name = "btn_table_separate";
            this.btn_table_separate.Size = new System.Drawing.Size(130, 110);
            this.btn_table_separate.TabIndex = 17;
            this.btn_table_separate.Text = "Masa Ayır";
            this.btn_table_separate.UseVisualStyleBackColor = true;
            // 
            // lbl_floor
            // 
            this.lbl_floor.AutoSize = true;
            this.lbl_floor.Location = new System.Drawing.Point(138, 9);
            this.lbl_floor.Name = "lbl_floor";
            this.lbl_floor.Size = new System.Drawing.Size(74, 26);
            this.lbl_floor.TabIndex = 18;
            this.lbl_floor.Text = "Bahçe";
            // 
            // gb_tables
            // 
            this.gb_tables.BackColor = System.Drawing.SystemColors.Control;
            this.gb_tables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gb_tables.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_tables.Location = new System.Drawing.Point(18, 64);
            this.gb_tables.Margin = new System.Windows.Forms.Padding(0);
            this.gb_tables.Name = "gb_tables";
            this.gb_tables.Padding = new System.Windows.Forms.Padding(0);
            this.gb_tables.Size = new System.Drawing.Size(819, 460);
            this.gb_tables.TabIndex = 19;
            this.gb_tables.TabStop = false;
            this.gb_tables.Enter += new System.EventHandler(this.gb_tables_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "Konum :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(854, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 26);
            this.label4.TabIndex = 21;
            this.label4.Text = "Konumlar";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1024, 741);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gb_tables);
            this.Controls.Add(this.lbl_floor);
            this.Controls.Add(this.btn_table_separate);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrevTables);
            this.Controls.Add(this.btnNextTables);
            this.Controls.Add(this.btn_table_move);
            this.Controls.Add(this.btn_table_concat);
            this.Controls.Add(this.button10);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form3";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btn_table_concat;
        private System.Windows.Forms.Button btn_table_move;
        private System.Windows.Forms.Button btnNextTables;
        private System.Windows.Forms.Button btnPrevTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button btn_table_separate;
        private System.Windows.Forms.Label lbl_floor;
        private System.Windows.Forms.GroupBox gb_tables;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}