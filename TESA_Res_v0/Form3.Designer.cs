﻿namespace TESA_Res_v0
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
            this.tableConcat = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btnNextTables = new System.Windows.Forms.Button();
            this.btnPrevTables = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(114, 635);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(150, 77);
            this.button10.TabIndex = 9;
            this.button10.Text = "Ana Menü";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // tableConcat
            // 
            this.tableConcat.Location = new System.Drawing.Point(289, 635);
            this.tableConcat.Name = "tableConcat";
            this.tableConcat.Size = new System.Drawing.Size(111, 77);
            this.tableConcat.TabIndex = 10;
            this.tableConcat.Text = "Masa Birleştir";
            this.tableConcat.UseVisualStyleBackColor = true;
            this.tableConcat.Click += new System.EventHandler(this.tableConcat_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(420, 635);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(96, 77);
            this.button12.TabIndex = 11;
            this.button12.Text = "Masa Taşı";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // btnNextTables
            // 
            this.btnNextTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNextTables.Location = new System.Drawing.Point(667, 635);
            this.btnNextTables.Name = "btnNextTables";
            this.btnNextTables.Size = new System.Drawing.Size(75, 77);
            this.btnNextTables.TabIndex = 12;
            this.btnNextTables.Text = ">";
            this.btnNextTables.UseVisualStyleBackColor = true;
            this.btnNextTables.Click += new System.EventHandler(this.btnNextTables_Click);
            // 
            // btnPrevTables
            // 
            this.btnPrevTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrevTables.Location = new System.Drawing.Point(586, 635);
            this.btnPrevTables.Name = "btnPrevTables";
            this.btnPrevTables.Size = new System.Drawing.Size(75, 77);
            this.btnPrevTables.TabIndex = 13;
            this.btnPrevTables.Text = "<";
            this.btnPrevTables.UseVisualStyleBackColor = true;
            this.btnPrevTables.Click += new System.EventHandler(this.btnPrevTables_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 742);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kullanıcı:";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userName.Location = new System.Drawing.Point(92, 742);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(45, 17);
            this.userName.TabIndex = 15;
            this.userName.Text = "Emre";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrevTables);
            this.Controls.Add(this.btnNextTables);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.tableConcat);
            this.Controls.Add(this.button10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button tableConcat;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btnNextTables;
        private System.Windows.Forms.Button btnPrevTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userName;
    }
}