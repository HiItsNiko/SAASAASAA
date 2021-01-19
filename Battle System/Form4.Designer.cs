namespace Battle_System
{
    partial class FormGameplay
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
            this.pictureBoxFloor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFloor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFloor
            // 
            this.pictureBoxFloor.Image = global::Battle_System.Properties.Resources.FloorSteady;
            this.pictureBoxFloor.Location = new System.Drawing.Point(-2, 0);
            this.pictureBoxFloor.Name = "pictureBoxFloor";
            this.pictureBoxFloor.Size = new System.Drawing.Size(1264, 675);
            this.pictureBoxFloor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFloor.TabIndex = 0;
            this.pictureBoxFloor.TabStop = false;
            this.pictureBoxFloor.Click += new System.EventHandler(this.pictureBoxFloor_Click);
            // 
            // FormGameplay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1262, 673);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFloor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFloor;
    }
}