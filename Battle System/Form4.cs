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
            //biar transparan
            pictureBoxFloor.Controls.Add(pictureBoxChara);
            pictureBoxChara.BackColor = Color.Transparent;
        }
        public battlephase formbattle = new battlephase();
        public int count = 0;
        public int countto = 0;
        public Random random = new Random();
        //counter karakter
        public static int counterChara = 1;
        //counter kiri atau kanan
        public static int counterArah = 1;
        private void FormGameplay_Load(object sender, EventArgs e)
        {
            countto = random.Next(8, 13);
            timer1.Stop();
        }

        private void FormGameplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void FormGameplay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                timer1.Start();
                pictureBoxFloor.Image = Properties.Resources.FloorD;
            }
            if (e.KeyCode == Keys.A)
            {
                timer1.Start();
                pictureBoxFloor.Image = Properties.Resources.FloorA1;
            }
            if (e.KeyCode == Keys.S)
            {
                pictureBoxFloor.Image = Properties.Resources.FloorSteady;
                timer1.Stop();
                countto = random.Next(1, 13);
            }
        }

        
        

        private void FormGameplay_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                counterArah =  1;
                if (counterChara == 1)
                {
                    pictureBoxChara.Image = Properties.Resources.UwUSteadyR;
                }
                if (counterChara == 2)
                {
                    pictureBoxChara.Image = Properties.Resources.DogeSR;
                }
                if (counterChara == 3)
                {
                    pictureBoxChara.Image = Properties.Resources.MonkeSR;
                }
                if (counterChara == 4)
                {
                    pictureBoxChara.Image = Properties.Resources.DerpSR;
                }

            }
            if (e.KeyCode == Keys.A)
            {
                counterArah = 0;
                if (counterChara == 1)
                {
                    pictureBoxChara.Image = Properties.Resources.UwUSteadyL;
                }
                if (counterChara == 2)
                {
                    pictureBoxChara.Image = Properties.Resources.DogeSL;
                }
                if (counterChara == 3)
                {
                    pictureBoxChara.Image = Properties.Resources.MonkeSL;
                }
                if (counterChara == 4)
                {
                    pictureBoxChara.Image = Properties.Resources.DerpSL;
                }
            }


        }

        private void pictureBoxFloor_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBody_Click(object sender, EventArgs e)
        {

        }


        private void pictureBoxHead_Click(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void FormGameplau_KeyUp(object sender, KeyEventArgs e)
        {

        }
        private void radioButtonUwU_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void radioButtonDoge_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void radioButtonMonke_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void RadioButtonDerp_CheckedChanged(object sender, EventArgs e)
        {
            
        }


        private void pictureBoxUwu_Click(object sender, EventArgs e)
        {
            counterChara = 1;

            pictureBoxFloor.Image = Properties.Resources.FloorSteady;
            if (counterArah == 1)
            {
                pictureBoxChara.Image = Properties.Resources.UwUSteadyR;
            }
            if(counterArah == 0)
            {
                pictureBoxChara.Image = Properties.Resources.UwUSteadyL;
            }
        }

        private void pictureBoxDoge_Click(object sender, EventArgs e)
        {
            counterChara = 2;

            pictureBoxFloor.Image = Properties.Resources.FloorSteady;
            if (counterArah == 1)
            {
                pictureBoxChara.Image = Properties.Resources.DogeSR;
            }
            if (counterArah == 0)
            {
                pictureBoxChara.Image = Properties.Resources.DogeSL;
            }
        }

        private void pictureBoxMonke_Click(object sender, EventArgs e)
        {
            counterChara = 3;

            pictureBoxFloor.Image = Properties.Resources.FloorSteady;
            if (counterArah == 1)
            {
                pictureBoxChara.Image = Properties.Resources.MonkeSR;
            }
            if (counterArah == 0)
            {
                pictureBoxChara.Image = Properties.Resources.MonkeSL;
            }
        }

        private void pictureBoxDerp_Click(object sender, EventArgs e)
        {
            counterChara = 4;

            pictureBoxFloor.Image = Properties.Resources.FloorSteady;
            if (counterArah == 1)
            {
                pictureBoxChara.Image = Properties.Resources.DerpSR;
            }
            if (counterArah == 0)
            {
                pictureBoxChara.Image = Properties.Resources.DerpSL;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick();
        }
        private void tick()
        {
            if (count < countto) count++;
            else if (count == countto)
            {
                timer1.Stop();
                formbattle.ShowDialog();
                count = 0;
                
            }
        }
    }
}
