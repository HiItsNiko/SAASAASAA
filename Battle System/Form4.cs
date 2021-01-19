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
    public partial class FormGameplay : Form
    {
        public FormGameplay()
        {
            InitializeComponent();
        }

        private void FormGameplay_Load(object sender, EventArgs e)
        {
            
        }

        private void FormGameplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void FormGameplay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                pictureBoxFloor.Image = Properties.Resources.FloorD;
            }
            if (e.KeyCode == Keys.A)
            {
                pictureBoxFloor.Image = Properties.Resources.FloorA;
            }
            if (e.KeyCode == Keys.S)
            {
                pictureBoxFloor.Image = Properties.Resources.FloorSteady;
            }
        }

        private void FormGameplau_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void FormGameplay_KeyUp(object sender, KeyEventArgs e)
        {
            
            

        }
    }
}
