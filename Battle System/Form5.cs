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
    public partial class Form5 : Form
    {

        public Form5()
        {
            InitializeComponent();
            comboBoxMenuWeapon.Items.Add("Sword");
            comboBoxMenuWeapon.Items.Add("Shield");
            comboBoxMenuWeapon.Items.Add("Arrow");
            comboBoxMenuWeapon.Items.Add("Axe");
            
            
        }

        //public int Khopesh = "Khopesh";

        private void comboBoxMenuWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMenuWeapon.Text.ToString() == "Sword")
            {
                labelJudul.Text = "Khopesh";
                //"Khopesh".Font = new Font("")
            }
            else if (comboBoxMenuWeapon.Text.ToString() == "Shield")
            {
                labelJudul.Text = "Shield Gun";
            }
            else if (comboBoxMenuWeapon.Text.ToString() == "Arrow")
            {
                labelJudul.Text = "Dark Arrow";
            }
            else if (comboBoxMenuWeapon.Text.ToString() == "Axe")
            {
                labelJudul.Text = "Diamond Axe";
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            ButtonFirst.Checked = false;
            ButtonSecond.Checked = false;
            ButtonSecond.Checked = false;
            ButtonFourth.Checked = false;
        }

        private void comboBoxMenuWeapon_SelectedValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void ButtonFirst_CheckedChanged(object sender, EventArgs e)
        {
            //if (ButtonFirst.Checked == false)
            //{
            //    ButtonFirst.Checked = false;
            //}
            //else
            //{
            //    ButtonFirst.Checked = true;
            //}
        }

        private void ButtonSecond_CheckedChanged(object sender, EventArgs e)
        {
            //ButtonSecond.Checked = false;
        }

        private void ButtonThird_CheckedChanged(object sender, EventArgs e)
        {
            //ButtonThird.Checked = false;
        }

        private void ButtonFourth_CheckedChanged(object sender, EventArgs e)
        {
            //ButtonFourth.Checked = false;
        }
    }
}
