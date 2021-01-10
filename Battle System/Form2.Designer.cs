namespace Battle_System
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.picBoxUIMenu = new System.Windows.Forms.PictureBox();
            this.buttonPlay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUIMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxUIMenu
            // 
            this.picBoxUIMenu.Image = ((System.Drawing.Image)(resources.GetObject("picBoxUIMenu.Image")));
            this.picBoxUIMenu.Location = new System.Drawing.Point(-3, 0);
            this.picBoxUIMenu.Name = "picBoxUIMenu";
            this.picBoxUIMenu.Size = new System.Drawing.Size(805, 451);
            this.picBoxUIMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUIMenu.TabIndex = 0;
            this.picBoxUIMenu.TabStop = false;
            this.picBoxUIMenu.Click += new System.EventHandler(this.picBoxUIMenu_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlay.Image")));
            this.buttonPlay.Location = new System.Drawing.Point(82, 245);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(645, 268);
            this.buttonPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.TabStop = false;
            this.buttonPlay.Click += new System.EventHandler(this.picBoxPlay_Click);
            this.buttonPlay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBoxPlay_MouseClick);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.picBoxUIMenu);
            this.Name = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUIMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxUIMenu;
        private System.Windows.Forms.PictureBox buttonPlay;
    }
}