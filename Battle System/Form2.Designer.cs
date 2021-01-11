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
            this.picBoxName = new System.Windows.Forms.PictureBox();
            this.buttonPlay = new System.Windows.Forms.PictureBox();
            this.picBoxUIMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUIMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxName
            // 
            this.picBoxName.Image = global::Battle_System.Properties.Resources.Name;
            this.picBoxName.Location = new System.Drawing.Point(-22, -116);
            this.picBoxName.Name = "picBoxName";
            this.picBoxName.Size = new System.Drawing.Size(834, 495);
            this.picBoxName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxName.TabIndex = 2;
            this.picBoxName.TabStop = false;
            this.picBoxName.Click += new System.EventHandler(this.picBoxName_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Image = global::Battle_System.Properties.Resources.ClickToBegin;
            this.buttonPlay.Location = new System.Drawing.Point(84, 231);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(645, 268);
            this.buttonPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.TabStop = false;
            this.buttonPlay.Click += new System.EventHandler(this.picBoxPlay_Click);
            this.buttonPlay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBoxPlay_MouseClick);
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
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBoxName);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.picBoxUIMenu);
            this.Name = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUIMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxUIMenu;
        private System.Windows.Forms.PictureBox buttonPlay;
        private System.Windows.Forms.PictureBox picBoxName;
    }
}