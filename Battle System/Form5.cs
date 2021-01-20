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
        static FormMenu form1 = new FormMenu();

        public int hero1health;
        public int hero1atk;
        public int hero1def;
        public int hero1spd;
        public int hero1lvl;

        public int hero2health;
        public int hero2atk ;
        public int hero2def;
        public int hero2spd;
        public int hero2lvl;

        public int hero3health ;
        public int hero3atk;
        public int hero3def;
        public int hero3spd;
        public int hero3lvl;

        public int hero4health;
        public int hero4atk;
        public int hero4def;
        public int hero4spd ;
        public int hero4lvl;

        
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

            hero1health = FormMenu.player1health;
            hero1atk = FormMenu.player1attack;
            hero1def = FormMenu.player1defense;
            hero1spd = FormMenu.player1speed;
            hero1lvl = FormMenu.player1lvl;

            hero2health = FormMenu.player2health;
            hero2atk = FormMenu.player2attack;
            hero2def = FormMenu.player2defense;
            hero2spd = FormMenu.player2speed;
            hero2lvl = FormMenu.player2lvl;

            hero3health = FormMenu.player1health;
            hero3atk = FormMenu.player3attack;
            hero3def = FormMenu.player3defense;
            hero3spd = FormMenu.player3speed;
            hero3lvl = FormMenu.player3lvl;

            hero4health = FormMenu.player4health;
            hero4atk = FormMenu.player4attack;
            hero4def = FormMenu.player4defense;
            hero4spd = FormMenu.player4speed;
            hero4lvl = FormMenu.player4lvl;
        }

        private void comboBoxMenuWeapon_SelectedValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void ButtonFirst_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ButtonSecond_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ButtonThird_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ButtonFourth_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
