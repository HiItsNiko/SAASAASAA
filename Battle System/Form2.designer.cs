﻿namespace Battle_System
{
    partial class FormItem
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
            this.tombol1 = new System.Windows.Forms.Button();
            this.tombol2 = new System.Windows.Forms.Button();
            this.tombol3 = new System.Windows.Forms.Button();
            this.tombol4 = new System.Windows.Forms.Button();
            this.labelNamaMakanan = new System.Windows.Forms.Label();
            this.ItemList = new System.Windows.Forms.ComboBox();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.DeskripsiMakanan = new System.Windows.Forms.Label();
            this.pictureItem = new System.Windows.Forms.PictureBox();
            this.pictureBoxBgItem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBgItem)).BeginInit();
            this.SuspendLayout();
            // 
            // tombol1
            // 
            this.tombol1.Location = new System.Drawing.Point(990, 213);
            this.tombol1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tombol1.Name = "tombol1";
            this.tombol1.Size = new System.Drawing.Size(100, 74);
            this.tombol1.TabIndex = 0;
            this.tombol1.Text = "Player UwU";
            this.tombol1.UseVisualStyleBackColor = true;
            this.tombol1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tombol2
            // 
            this.tombol2.Location = new System.Drawing.Point(990, 317);
            this.tombol2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tombol2.Name = "tombol2";
            this.tombol2.Size = new System.Drawing.Size(100, 74);
            this.tombol2.TabIndex = 1;
            this.tombol2.Text = "Player Doge";
            this.tombol2.UseVisualStyleBackColor = true;
            this.tombol2.Click += new System.EventHandler(this.tombol2_Click);
            // 
            // tombol3
            // 
            this.tombol3.Location = new System.Drawing.Point(1125, 213);
            this.tombol3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tombol3.Name = "tombol3";
            this.tombol3.Size = new System.Drawing.Size(100, 74);
            this.tombol3.TabIndex = 2;
            this.tombol3.Text = "Player Monke";
            this.tombol3.UseVisualStyleBackColor = true;
            this.tombol3.Click += new System.EventHandler(this.tombol3_Click);
            // 
            // tombol4
            // 
            this.tombol4.Location = new System.Drawing.Point(1125, 317);
            this.tombol4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tombol4.Name = "tombol4";
            this.tombol4.Size = new System.Drawing.Size(100, 74);
            this.tombol4.TabIndex = 3;
            this.tombol4.Text = "Player Derp";
            this.tombol4.UseVisualStyleBackColor = true;
            this.tombol4.Click += new System.EventHandler(this.tombol4_Click);
            // 
            // labelNamaMakanan
            // 
            this.labelNamaMakanan.AutoSize = true;
            this.labelNamaMakanan.BackColor = System.Drawing.SystemColors.GrayText;
            this.labelNamaMakanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaMakanan.ForeColor = System.Drawing.SystemColors.Window;
            this.labelNamaMakanan.Location = new System.Drawing.Point(591, 241);
            this.labelNamaMakanan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNamaMakanan.Name = "labelNamaMakanan";
            this.labelNamaMakanan.Size = new System.Drawing.Size(0, 39);
            this.labelNamaMakanan.TabIndex = 5;
            this.labelNamaMakanan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNamaMakanan.Click += new System.EventHandler(this.label1_Click);
            // 
            // ItemList
            // 
            this.ItemList.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ItemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemList.ForeColor = System.Drawing.SystemColors.Window;
            this.ItemList.FormattingEnabled = true;
            this.ItemList.Location = new System.Drawing.Point(266, 213);
            this.ItemList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(172, 26);
            this.ItemList.TabIndex = 6;
            this.ItemList.Text = "Choose your Food!";
            this.ItemList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.BackColor = System.Drawing.SystemColors.GrayText;
            this.labelJumlah.ForeColor = System.Drawing.SystemColors.Window;
            this.labelJumlah.Location = new System.Drawing.Point(468, 222);
            this.labelJumlah.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(0, 17);
            this.labelJumlah.TabIndex = 7;
            this.labelJumlah.Click += new System.EventHandler(this.label2_Click);
            // 
            // DeskripsiMakanan
            // 
            this.DeskripsiMakanan.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.DeskripsiMakanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskripsiMakanan.ForeColor = System.Drawing.SystemColors.Window;
            this.DeskripsiMakanan.Location = new System.Drawing.Point(261, 466);
            this.DeskripsiMakanan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeskripsiMakanan.Name = "DeskripsiMakanan";
            this.DeskripsiMakanan.Size = new System.Drawing.Size(801, 89);
            this.DeskripsiMakanan.TabIndex = 8;
            this.DeskripsiMakanan.Click += new System.EventHandler(this.DeskripsiMakanan_Click);
            // 
            // pictureItem
            // 
            this.pictureItem.Location = new System.Drawing.Point(38, 201);
            this.pictureItem.Margin = new System.Windows.Forms.Padding(4);
            this.pictureItem.Name = "pictureItem";
            this.pictureItem.Size = new System.Drawing.Size(196, 171);
            this.pictureItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureItem.TabIndex = 4;
            this.pictureItem.TabStop = false;
            this.pictureItem.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxBgItem
            // 
            this.pictureBoxBgItem.Image = global::Battle_System.Properties.Resources.Kitchen;
            this.pictureBoxBgItem.Location = new System.Drawing.Point(0, -3);
            this.pictureBoxBgItem.Name = "pictureBoxBgItem";
            this.pictureBoxBgItem.Size = new System.Drawing.Size(1263, 678);
            this.pictureBoxBgItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBgItem.TabIndex = 9;
            this.pictureBoxBgItem.TabStop = false;
            // 
            // FormItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.DeskripsiMakanan);
            this.Controls.Add(this.labelJumlah);
            this.Controls.Add(this.ItemList);
            this.Controls.Add(this.labelNamaMakanan);
            this.Controls.Add(this.pictureItem);
            this.Controls.Add(this.tombol4);
            this.Controls.Add(this.tombol3);
            this.Controls.Add(this.tombol2);
            this.Controls.Add(this.tombol1);
            this.Controls.Add(this.pictureBoxBgItem);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBgItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tombol1;
        private System.Windows.Forms.Button tombol2;
        private System.Windows.Forms.Button tombol3;
        private System.Windows.Forms.Button tombol4;
        private System.Windows.Forms.PictureBox pictureItem;
        private System.Windows.Forms.Label labelNamaMakanan;
        private System.Windows.Forms.ComboBox ItemList;
        private System.Windows.Forms.Label labelJumlah;
        private System.Windows.Forms.Label DeskripsiMakanan;
        private System.Windows.Forms.PictureBox pictureBoxBgItem;
    }
}