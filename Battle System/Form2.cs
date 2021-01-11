using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battle_System
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }


        private void picBoxUIMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void picBoxPlay_Click(object sender, EventArgs e)
        {
            
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            //transparent play button
            picBoxUIMenu.Controls.Add(buttonPlay);
            buttonPlay.BackColor = Color.Transparent;

            //transparent game name
            picBoxUIMenu.Controls.Add(picBoxName);
            picBoxName.BackColor = Color.Transparent;
        }

        private void picBoxPlay_MouseClick(object sender, MouseEventArgs e)
        {
            //to open a new form
            FormGameplay myForm = new FormGameplay();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
            
        }

        private void picBoxName_Click(object sender, EventArgs e)
        {

        }
    }
}
