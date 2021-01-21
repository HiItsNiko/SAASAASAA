namespace Battle_System
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
            this.pictureItem = new System.Windows.Forms.PictureBox();
            this.ItemList = new System.Windows.Forms.ComboBox();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.DeskripsiMakanan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureItem)).BeginInit();
            this.SuspendLayout();
            // 
            // tombol1
            // 
            this.tombol1.Location = new System.Drawing.Point(779, 15);
            this.tombol1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tombol1.Name = "tombol1";
            this.tombol1.Size = new System.Drawing.Size(100, 69);
            this.tombol1.TabIndex = 0;
            this.tombol1.Text = "Player UwU";
            this.tombol1.UseVisualStyleBackColor = true;
            this.tombol1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tombol2
            // 
            this.tombol2.Location = new System.Drawing.Point(779, 112);
            this.tombol2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tombol2.Name = "tombol2";
            this.tombol2.Size = new System.Drawing.Size(100, 74);
            this.tombol2.TabIndex = 1;
            this.tombol2.Text = "button2";
            this.tombol2.UseVisualStyleBackColor = true;
            this.tombol2.Click += new System.EventHandler(this.tombol2_Click);
            // 
            // tombol3
            // 
            this.tombol3.Location = new System.Drawing.Point(779, 215);
            this.tombol3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tombol3.Name = "tombol3";
            this.tombol3.Size = new System.Drawing.Size(100, 74);
            this.tombol3.TabIndex = 2;
            this.tombol3.Text = "button3";
            this.tombol3.UseVisualStyleBackColor = true;
            this.tombol3.Click += new System.EventHandler(this.tombol3_Click);
            // 
            // tombol4
            // 
            this.tombol4.Location = new System.Drawing.Point(779, 315);
            this.tombol4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tombol4.Name = "tombol4";
            this.tombol4.Size = new System.Drawing.Size(100, 74);
            this.tombol4.TabIndex = 3;
            this.tombol4.Text = "button4";
            this.tombol4.UseVisualStyleBackColor = true;
            this.tombol4.Click += new System.EventHandler(this.tombol4_Click);
            // 
            // labelNamaMakanan
            // 
            this.labelNamaMakanan.AutoSize = true;
            this.labelNamaMakanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaMakanan.Location = new System.Drawing.Point(47, 215);
            this.labelNamaMakanan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNamaMakanan.Name = "labelNamaMakanan";
            this.labelNamaMakanan.Size = new System.Drawing.Size(0, 39);
            this.labelNamaMakanan.TabIndex = 5;
            this.labelNamaMakanan.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureItem
            // 
            this.pictureItem.Location = new System.Drawing.Point(55, 15);
            this.pictureItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureItem.Name = "pictureItem";
            this.pictureItem.Size = new System.Drawing.Size(169, 171);
            this.pictureItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureItem.TabIndex = 4;
            this.pictureItem.TabStop = false;
            this.pictureItem.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ItemList
            // 
            this.ItemList.FormattingEnabled = true;
            this.ItemList.Location = new System.Drawing.Point(289, 15);
            this.ItemList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(160, 24);
            this.ItemList.TabIndex = 6;
            this.ItemList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Location = new System.Drawing.Point(512, 18);
            this.labelJumlah.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(0, 17);
            this.labelJumlah.TabIndex = 7;
            this.labelJumlah.Click += new System.EventHandler(this.label2_Click);
            // 
            // DeskripsiMakanan
            // 
            this.DeskripsiMakanan.AutoSize = true;
            this.DeskripsiMakanan.Location = new System.Drawing.Point(105, 315);
            this.DeskripsiMakanan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeskripsiMakanan.Name = "DeskripsiMakanan";
            this.DeskripsiMakanan.Size = new System.Drawing.Size(0, 17);
            this.DeskripsiMakanan.TabIndex = 8;
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureItem)).EndInit();
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
    }
}