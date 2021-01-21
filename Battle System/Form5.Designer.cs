namespace Battle_System
{
    partial class SystemAttack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemAttack));
            this.ButtonFirst = new System.Windows.Forms.RadioButton();
            this.ButtonSecond = new System.Windows.Forms.RadioButton();
            this.ButtonThird = new System.Windows.Forms.RadioButton();
            this.ButtonFourth = new System.Windows.Forms.RadioButton();
            this.comboBoxMenuWeapon = new System.Windows.Forms.ComboBox();
            this.labelJudul = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.None = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonFirst
            // 
            this.ButtonFirst.AutoSize = true;
            this.ButtonFirst.Location = new System.Drawing.Point(643, 37);
            this.ButtonFirst.Name = "ButtonFirst";
            this.ButtonFirst.Size = new System.Drawing.Size(91, 17);
            this.ButtonFirst.TabIndex = 1;
            this.ButtonFirst.TabStop = true;
            this.ButtonFirst.Text = "Player UWu 1";
            this.ButtonFirst.UseVisualStyleBackColor = true;
            this.ButtonFirst.CheckedChanged += new System.EventHandler(this.ButtonFirst_CheckedChanged);
            // 
            // ButtonSecond
            // 
            this.ButtonSecond.AutoSize = true;
            this.ButtonSecond.Location = new System.Drawing.Point(643, 148);
            this.ButtonSecond.Name = "ButtonSecond";
            this.ButtonSecond.Size = new System.Drawing.Size(91, 17);
            this.ButtonSecond.TabIndex = 2;
            this.ButtonSecond.TabStop = true;
            this.ButtonSecond.Text = "Player UWu 2";
            this.ButtonSecond.UseVisualStyleBackColor = true;
            this.ButtonSecond.CheckedChanged += new System.EventHandler(this.ButtonSecond_CheckedChanged);
            // 
            // ButtonThird
            // 
            this.ButtonThird.AutoSize = true;
            this.ButtonThird.Location = new System.Drawing.Point(643, 258);
            this.ButtonThird.Name = "ButtonThird";
            this.ButtonThird.Size = new System.Drawing.Size(91, 17);
            this.ButtonThird.TabIndex = 3;
            this.ButtonThird.TabStop = true;
            this.ButtonThird.Text = "Player UWu 3";
            this.ButtonThird.UseVisualStyleBackColor = true;
            this.ButtonThird.CheckedChanged += new System.EventHandler(this.ButtonThird_CheckedChanged);
            // 
            // ButtonFourth
            // 
            this.ButtonFourth.AutoSize = true;
            this.ButtonFourth.Location = new System.Drawing.Point(643, 375);
            this.ButtonFourth.Name = "ButtonFourth";
            this.ButtonFourth.Size = new System.Drawing.Size(91, 17);
            this.ButtonFourth.TabIndex = 4;
            this.ButtonFourth.TabStop = true;
            this.ButtonFourth.Text = "Player UWu 4";
            this.ButtonFourth.UseVisualStyleBackColor = true;
            this.ButtonFourth.CheckedChanged += new System.EventHandler(this.ButtonFourth_CheckedChanged);
            // 
            // comboBoxMenuWeapon
            // 
            this.comboBoxMenuWeapon.FormattingEnabled = true;
            this.comboBoxMenuWeapon.Location = new System.Drawing.Point(319, 37);
            this.comboBoxMenuWeapon.Name = "comboBoxMenuWeapon";
            this.comboBoxMenuWeapon.Size = new System.Drawing.Size(282, 21);
            this.comboBoxMenuWeapon.TabIndex = 5;
            this.comboBoxMenuWeapon.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenuWeapon_SelectedIndexChanged);
            this.comboBoxMenuWeapon.SelectedValueChanged += new System.EventHandler(this.comboBoxMenuWeapon_SelectedValueChanged);
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(31, 236);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(173, 35);
            this.labelJudul.TabIndex = 6;
            this.labelJudul.Text = "Equipment";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc.Location = new System.Drawing.Point(32, 282);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(120, 25);
            this.labelDesc.TabIndex = 7;
            this.labelDesc.Text = "Description";
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDisplay.Image")));
            this.pictureBoxDisplay.Location = new System.Drawing.Point(24, 37);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(228, 167);
            this.pictureBoxDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDisplay.TabIndex = 0;
            this.pictureBoxDisplay.TabStop = false;
            // 
            // None
            // 
            this.None.AutoSize = true;
            this.None.Location = new System.Drawing.Point(37, 421);
            this.None.Name = "None";
            this.None.Size = new System.Drawing.Size(51, 17);
            this.None.TabIndex = 8;
            this.None.TabStop = true;
            this.None.Text = "None";
            this.None.UseVisualStyleBackColor = true;
            this.None.CheckedChanged += new System.EventHandler(this.None_CheckedChanged);
            // 
            // SystemAttack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.None);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.comboBoxMenuWeapon);
            this.Controls.Add(this.ButtonFourth);
            this.Controls.Add(this.ButtonThird);
            this.Controls.Add(this.ButtonSecond);
            this.Controls.Add(this.ButtonFirst);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Name = "SystemAttack";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.RadioButton ButtonFirst;
        private System.Windows.Forms.RadioButton ButtonSecond;
        private System.Windows.Forms.RadioButton ButtonThird;
        private System.Windows.Forms.RadioButton ButtonFourth;
        private System.Windows.Forms.ComboBox comboBoxMenuWeapon;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.RadioButton None;
    }
}