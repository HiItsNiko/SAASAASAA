namespace Battle_System
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.timerBattle = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxDerp = new System.Windows.Forms.PictureBox();
            this.pictureBoxUwu = new System.Windows.Forms.PictureBox();
            this.pictureBoxChara = new System.Windows.Forms.PictureBox();
            this.pictureBoxDoge = new System.Windows.Forms.PictureBox();
            this.pictureBoxMonke = new System.Windows.Forms.PictureBox();
            this.pictureBoxFloor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDerp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUwu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFloor)).BeginInit();
            this.SuspendLayout();
            // 
            // timerBattle
            // 
            this.timerBattle.Interval = 1000;
            this.timerBattle.Tick += new System.EventHandler(this.timerBattle_Tick);
            // 
            // pictureBoxDerp
            // 
            this.pictureBoxDerp.Image = global::Battle_System.Properties.Resources.ButtonDerp1;
            this.pictureBoxDerp.Location = new System.Drawing.Point(1202, 231);
            this.pictureBoxDerp.Name = "pictureBoxDerp";
            this.pictureBoxDerp.Size = new System.Drawing.Size(57, 57);
            this.pictureBoxDerp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDerp.TabIndex = 5;
            this.pictureBoxDerp.TabStop = false;
            this.pictureBoxDerp.Click += new System.EventHandler(this.pictureBoxDerp_Click);
            // 
            // pictureBoxUwu
            // 
            this.pictureBoxUwu.Image = global::Battle_System.Properties.Resources.ButtonUwU;
            this.pictureBoxUwu.Location = new System.Drawing.Point(1202, 12);
            this.pictureBoxUwu.Name = "pictureBoxUwu";
            this.pictureBoxUwu.Size = new System.Drawing.Size(57, 57);
            this.pictureBoxUwu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUwu.TabIndex = 2;
            this.pictureBoxUwu.TabStop = false;
            this.pictureBoxUwu.Click += new System.EventHandler(this.pictureBoxUwu_Click);
            // 
            // pictureBoxChara
            // 
            this.pictureBoxChara.Image = global::Battle_System.Properties.Resources.UwUSteadyR;
            this.pictureBoxChara.Location = new System.Drawing.Point(55, 266);
            this.pictureBoxChara.Name = "pictureBoxChara";
            this.pictureBoxChara.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxChara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxChara.TabIndex = 1;
            this.pictureBoxChara.TabStop = false;
            this.pictureBoxChara.Click += new System.EventHandler(this.pictureBoxBody_Click);
            // 
            // pictureBoxDoge
            // 
            this.pictureBoxDoge.Image = global::Battle_System.Properties.Resources.ButtonDoge;
            this.pictureBoxDoge.Location = new System.Drawing.Point(1202, 84);
            this.pictureBoxDoge.Name = "pictureBoxDoge";
            this.pictureBoxDoge.Size = new System.Drawing.Size(57, 57);
            this.pictureBoxDoge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDoge.TabIndex = 3;
            this.pictureBoxDoge.TabStop = false;
            this.pictureBoxDoge.Click += new System.EventHandler(this.pictureBoxDoge_Click);
            // 
            // pictureBoxMonke
            // 
            this.pictureBoxMonke.Image = global::Battle_System.Properties.Resources.ButtonMonke;
            this.pictureBoxMonke.Location = new System.Drawing.Point(1202, 159);
            this.pictureBoxMonke.Name = "pictureBoxMonke";
            this.pictureBoxMonke.Size = new System.Drawing.Size(57, 57);
            this.pictureBoxMonke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMonke.TabIndex = 4;
            this.pictureBoxMonke.TabStop = false;
            this.pictureBoxMonke.Click += new System.EventHandler(this.pictureBoxMonke_Click);
            // 
            // pictureBoxFloor
            // 
            this.pictureBoxFloor.Image = global::Battle_System.Properties.Resources.FloorSteadyUp;
            this.pictureBoxFloor.Location = new System.Drawing.Point(-2, 0);
            this.pictureBoxFloor.Name = "pictureBoxFloor";
            this.pictureBoxFloor.Size = new System.Drawing.Size(1270, 675);
            this.pictureBoxFloor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFloor.TabIndex = 0;
            this.pictureBoxFloor.TabStop = false;
            this.pictureBoxFloor.Click += new System.EventHandler(this.pictureBoxFloor_Click);
            // 
            // FormGameplay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pictureBoxDerp);
            this.Controls.Add(this.pictureBoxUwu);
            this.Controls.Add(this.pictureBoxChara);
            this.Controls.Add(this.pictureBoxDoge);
            this.Controls.Add(this.pictureBoxMonke);
            this.Controls.Add(this.pictureBoxFloor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormGameplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redi Player UwU";
            this.Load += new System.EventHandler(this.FormGameplay_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGameplay_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormGameplay_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormGameplay_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDerp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUwu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFloor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxChara;
        private System.Windows.Forms.PictureBox pictureBoxFloor;
        private System.Windows.Forms.PictureBox pictureBoxMonke;
        private System.Windows.Forms.PictureBox pictureBoxDoge;
        private System.Windows.Forms.PictureBox pictureBoxUwu;
        private System.Windows.Forms.PictureBox pictureBoxDerp;
        private System.Windows.Forms.Timer timerBattle;
    }
}