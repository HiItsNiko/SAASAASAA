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
    public partial class SystemAttack : Form
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

        public int saveSkill1 = 0;
        public int saveSkill2 = 0;
        public int saveSkill3 = 0;
        public int saveSkill4 = 0;
        //public  saveEquipment;
        public SystemAttack()
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
                labelDesc.Text = "";
                
                if (saveSkill1 == 0 )
                {
                    None.Checked = true;
                }
                else if (saveSkill1 == 1)
                {
                    ButtonFirst.Checked = true;
                }
                else if (saveSkill1 == 2)
                {
                    ButtonSecond.Checked = true;
                }
                else if (saveSkill1 == 3)
                {
                    ButtonThird.Checked = true;
                }
                else if (saveSkill1 == 4)
                {
                    ButtonFourth.Checked = true;
                }
                
            }
            else if (comboBoxMenuWeapon.Text.ToString() == "Shield")
            {
                labelJudul.Text = "Shield Gun";
                labelDesc.Text = "";
               
                if (saveSkill2 == 0)
                {
                    None.Checked = true;
                }
                else if (saveSkill2 == 1)
                {
                    ButtonFirst.Checked = true;
                }
                else if (saveSkill2 == 2)
                {
                    ButtonSecond.Checked = true;
                }
                else if (saveSkill2 == 3)
                {
                    ButtonThird.Checked = true;
                }
                else if (saveSkill2 == 4)
                {
                    ButtonFourth.Checked = true;
                }
            }
            else if (comboBoxMenuWeapon.Text.ToString() == "Arrow")
            {
                labelJudul.Text = "Dark Arrow";
                labelDesc.Text = "";
                
                if (saveSkill1 == 0)
                {
                    None.Checked = true;
                }
                else if (saveSkill3 == 1)
                {
                    ButtonFirst.Checked = true;
                }
                else if (saveSkill3 == 2)
                {
                    ButtonSecond.Checked = true;
                }
                else if (saveSkill3 == 3)
                {
                    ButtonThird.Checked = true;
                }
                else if (saveSkill3 == 4)
                {
                    ButtonFourth.Checked = true;
                }

            }
            else if (comboBoxMenuWeapon.Text.ToString() == "Axe")
            {
                labelJudul.Text = "Diamond Axe";
                labelDesc.Text = "";
                
                if (saveSkill4 == 0)
                {
                    None.Checked = true;
                }
                else if (saveSkill4 == 1)
                {
                    ButtonFirst.Checked = true;
                }
                else if (saveSkill4 == 2)
                {
                    ButtonSecond.Checked = true;
                }
                else if (saveSkill4 == 3)
                {
                    ButtonThird.Checked = true;
                }
                else if (saveSkill4 == 4)
                {
                    ButtonFourth.Checked = true;
                }
            }            
           
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            None.Checked = true;
            //ButtonFirst.Checked = false;
            //ButtonSecond.Checked = false;
            //ButtonSecond.Checked = false;
            //ButtonFourth.Checked = false;

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
            if (comboBoxMenuWeapon.Text.ToString() == "Sword")
            {
                saveSkill1 = 1;
            }
            else if (comboBoxMenuWeapon.Text.ToString() == "Shield")
            {
                saveSkill2 = 1;
            }
            else if (comboBoxMenuWeapon.Text.ToString() == "Arrow")
            {
                saveSkill3 = 1;
            }
            else if (comboBoxMenuWeapon.Text.ToString() == "Axe")
            {
                saveSkill4 = 1;
            }
        }

        private void ButtonSecond_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBoxMenuWeapon.Text.ToString() == "Sword")
            {
                saveSkill1 = 2;
            }
            else if (comboBoxMenuWeapon.Text.ToString() == "Shield")
            {
                saveSkill2 = 2;
            }
            else if (comboBoxMenuWeapon.Text.ToString() == "Arrow")
            {
                saveSkill3 = 2;
            }
            else if (comboBoxMenuWeapon.Text.ToString() == "Axe")
            {
                saveSkill4 = 2;
            }
        }

        private void ButtonThird_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBoxMenuWeapon.Text.ToString() == "Sword")
            {
                saveSkill1 = 3;
            }
            else if (comboBoxMenuWeapon.Text.ToString() == "Shield")
            {
                saveSkill2 = 3;
            }
            else if (comboBoxMenuWeapon.Text.ToString() == "Arrow")
            {
                saveSkill3 = 3;
            }
            else if (comboBoxMenuWeapon.Text.ToString() == "Axe")
            {
                saveSkill4 = 3;
            }
            
        }

        private void ButtonFourth_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBoxMenuWeapon.Text.ToString() == "Sword")
            {
                saveSkill1 = 4;
            }
            else if (comboBoxMenuWeapon.Text.ToString() == "Shield")
            {
                saveSkill2 = 4;
            }
            else if (comboBoxMenuWeapon.Text.ToString() == "Arrow")
            {
                saveSkill3 = 4;
            }
            else if (comboBoxMenuWeapon.Text.ToString() == "Axe")
            {
                saveSkill4 = 4;
            }

        }
        private void None_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBoxMenuWeapon.Text.ToString() == "Sword")
            {
                saveSkill1 = 0;
            }
            else if (comboBoxMenuWeapon.Text.ToString() == "Shield")
            {
                saveSkill2 = 0;
            }
            else if (comboBoxMenuWeapon.Text.ToString() == "Arrow")
            {
                saveSkill3 = 0;
            }
            else if (comboBoxMenuWeapon.Text.ToString() == "Axe")
            {
                saveSkill4 = 0;
            }
        }
    }
}
