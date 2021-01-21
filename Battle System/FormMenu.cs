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

        public static int player1health;
        public static int player1attack;
        public static int player1defense;
        public static int player1speed;
        public static int player1lvl;

        public static int player2health;
        public static int player2attack;
        public static int player2defense;
        public static int player2speed;
        public static int player2lvl;

        public static int player3health;
        public static int player3attack;
        public static int player3defense;
        public static int player3speed;
        public static int player3lvl;

        public static int player4health;
        public static int player4attack;
        public static int player4defense;
        public static int player4speed;
        public static int player4lvl;


        private void picBoxBegin_Click(object sender, EventArgs e)
        {
            //to open a new form
            FormStory myForm = new FormStory();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
        private void FormMenu_Load_1(object sender, EventArgs e)
        {
            //transparent begin picture box
            pictureBoxMenu.Controls.Add(pictureBoxBegin);
            pictureBoxBegin.BackColor = Color.Transparent;

            //transparent game name picture box
            pictureBoxMenu.Controls.Add(pictureBoxName);
            pictureBoxName.BackColor = Color.Transparent;
        }







        private void picBoxPlay_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void picBoxName_Click(object sender, EventArgs e)
        {

        }

        private void picBoxPlay_Click_1(object sender, EventArgs e)
        {

        }
        private void picBoxUIMenu_Click(object sender, EventArgs e)
        {

        }

        private void picBoxPlay_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxName_Click(object sender, EventArgs e)
        {

        }
    }
}
