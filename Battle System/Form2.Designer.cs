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
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUIMenu)).BeginInit();
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
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBoxUIMenu);
            this.Name = "FormMenu";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUIMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxUIMenu;
    }
}