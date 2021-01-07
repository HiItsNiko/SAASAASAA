﻿using System;
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
    public partial class battlephase : Form
    {


        public int gamecount = 0;

        public int atkchose;

        public Random random = new Random();
        public static Yuushadono example;
        public Yuushadono example2;
        public Yuushadono example3;
        public Yuushadono example4;

        public int enemychoose = 0;

        public int minigame1count = 0;
        public int minigame2count = 0;
        public int minigame3count = 0;
        

        public int count3 = 0;
        public int count2 = 0;

        public int enemy1atk;
        public int enemy2atk;
        public int enemy3atk;

        public int enemy1health;
        public int enemy2health;
        public int enemy3health;

        public int enemy1speed;
        public int enemy2speed;
        public int enemy3speed;

        public int enemy1choice;
        public int enemy2choice;
        public int enemy3choice;

        public string enemyname1;
        public string enemyname2;
        public string enemyname3;
        public battlephase()
            
        {
            example = new Yuushadono();
            example2 = new Yuushadono();
            example3 = new Yuushadono();
            example4 = new Yuushadono();
            example.luck = 25;
            example.attack = 12;
            example.defend = 2;
            example.lvl = 1;
            example.health = 100 + ((example.lvl - 1) * 8);
            example.speed = 10;
            example.number = 0;
            example.luck = 25;
            example2.attack = 12;
            example2.defend = 2;
            example2.lvl = 1;
            example2.health = 100 + ((example.lvl - 1) * 8);
            example2.speed = 10;
            example2.number = 1;
            example3.luck = 25;
            example3.attack = 12;
            example3.defend = 2;
            example3.lvl = 1;
            example3.health = 100 + ((example.lvl - 1) * 8);
            example3.speed = 10;
            example3.number = 2;
            example4.luck = 25;
            example4.attack = 12;
            example4.defend = 2;
            example4.lvl = 1;
            example4.health = 100 + ((example.lvl - 1) * 8);
            example4.speed = 10;
            example4.number = 3;
            enemyloader();
            InitializeComponent();
        }
        
        

        private void enemyloader()
        {
            gamecount++;
            if (gamecount == 1)
            {
                enemyname1 = "";
                enemy1atk = 3;
                enemy1health = 120;
                enemyhealth1.Maximum = enemy1health;
                enemy1speed = 9;
                enemyname2 = "";
                enemy2atk = 3;
                enemy2health = 120;
                enemyhealth2.Maximum = enemy2health;
                enemy2speed = 9;
                enemyname3 = "";
                enemy3atk = 3;
                enemy3health = 120;
                enemyhealth3.Maximum = enemy3health;
                enemy3speed = 9;
                healthupdate();
            }
            if (gamecount == 2)
            {
                enemyname1 = "";
                enemy1atk = 3;
                enemy1health = 120;
                enemyhealth1.Maximum = enemy1health;
                enemy1speed = 9;
                enemyname2 = "";
                enemy2atk = 3;
                enemy2health = 120;
                enemyhealth2.Maximum = enemy2health;
                enemy2speed = 9;
                enemyname3 = "";
                enemy3atk = 3;
                enemy3health = 120;
                enemyhealth3.Maximum = enemy3health;
                enemy3speed = 9;
                healthupdate();

            }
            if (gamecount == 3)
            {
                enemyname1 = "";
                enemy1atk = 3;
                enemy1health = 120;
                enemyhealth1.Maximum = enemy1health;
                enemy1speed = 9;
                enemyname2 = "";
                enemy2atk = 3;
                enemy2health = 120;
                enemyhealth2.Maximum = enemy2health;
                enemy2speed = 9;
                enemyname3 = "";
                enemy3atk = 3;
                enemy3health = 120;
                enemyhealth3.Maximum = enemy3health;
                enemy3speed = 9;
                healthupdate();

            }
            if (gamecount == 4)
            {
                enemyname1 = "";
                enemy1atk = 3;
                enemy1health = 120;
                enemyhealth1.Maximum = enemy1health;
                enemy1speed = 9;
                enemyname2 = "";
                enemy2atk = 3;
                enemy2health = 120;
                enemyhealth2.Maximum = enemy2health;
                enemy2speed = 9;
                enemyname3 = "";
                enemy3atk = 3;
                enemy3health = 120;
                enemyhealth3.Maximum = enemy3health;
                enemy3speed = 9;
                healthupdate();
            }
            if (gamecount == 5)
            {
                enemyname1 = "";
                enemy1atk = 3;
                enemy1health = 120;
                enemyhealth1.Maximum = enemy1health;
                enemy1speed = 9;
                enemyname2 = "";
                enemy2atk = 3;
                enemy2health = 120;
                enemyhealth2.Maximum = enemy2health;
                enemy2speed = 9;
                enemyname3 = "";
                enemy3atk = 3;
                enemy3health = 120;
                enemyhealth3.Maximum = enemy3health;
                enemy3speed = 9;
                healthupdate();

            }
            if (gamecount == 6)
            {
                enemyname1 = "";
                enemy1atk = 3;
                enemy1health = 120;
                enemyhealth1.Maximum = enemy1health;
                enemy1speed = 9;
                enemyname2 = "";
                enemy2atk = 3;
                enemy2health = 120;
                enemyhealth2.Maximum = enemy2health;
                enemy2speed = 9;
                enemyname3 = "";
                enemy3atk = 3;
                enemy3health = 120;
                enemyhealth3.Maximum = enemy3health;
                enemy3speed = 9;
                healthupdate();

            }
            if (gamecount == 7)
            {
                enemyname1 = "";
                enemy1atk = 3;
                enemy1health = 120;
                enemyhealth1.Maximum = enemy1health;
                enemy1speed = 9;
                enemyname2 = "";
                enemy2atk = 3;
                enemy2health = 120;
                enemyhealth2.Maximum = enemy2health;
                enemy2speed = 9;
                enemyname3 = "";
                enemy3atk = 3;
                enemy3health = 120;
                enemyhealth3.Maximum = enemy3health;
                enemy3speed = 9;
                healthupdate();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            minigametimer1.Interval = 1000;
            minigametimer1.Tick += minigame1;
            minigame3button.Hide();
            minigametimer2.Interval = 1000;
            minigametimer2.Tick += minigame2;
            minigametimer3.Interval = 5000;
            minigametimer3.Tick += minigame3;
            label2.Hide();
            textBox1.Hide();
            herotimer1.Tick += wait1;
            herotimer2.Tick += wait2;
            herotimer3.Tick += wait3;
            herotimer4.Tick += wait4;
            herotimer1.Interval = 1000;
            herotimer2.Interval = 1000;
            herotimer3.Interval = 1000;
            herotimer4.Interval = 1000;
            herotimer1.Start();
            herotimer2.Start();
            herotimer3.Start();
            herotimer4.Start();
            globaltimer.Interval = 1000;
            globaltimer.Start();
            globaltimer.Tick += enemyaction;
            speedbar1.Value = 0;
            speedbar1.Minimum = 0;
            speedbar1.Maximum = 100;
            HealthBar1.Maximum = Convert.ToInt32(example.health);
            Healthbar2.Maximum = Convert.ToInt32(example.health);
            Healthbar3.Maximum = Convert.ToInt32(example.health);
            Healthbar4.Maximum = Convert.ToInt32(example.health);
            HealthBar1.Minimum = 0;
            Healthbar2.Minimum = 0;
            Healthbar3.Minimum = 0;
            Healthbar4.Minimum = 0;
            HealthBar1.Value = Convert.ToInt32(example.health);
            Healthbar2.Value = Convert.ToInt32(example.health);
            Healthbar3.Value = Convert.ToInt32(example.health);
            Healthbar4.Value = Convert.ToInt32(example.health);
            
            enemyhealth2.Minimum = 0;
            Attackbutton1.Enabled = false;
            Skillbutton1.Enabled = false;
            Itembutton1.Enabled = false;

        }
        private void enemyaction(object enemy1, EventArgs enemy1event)
        {
            if (enemyhealth1.Value > 0)
            {
                if (enemy1speed < 100) enemy1speed += 10;
                else
                {
                    enemy1choice = random.Next(0, 3);
                    enemy1speed = 0;


                    if (enemy1choice == 0) example.health -= enemy1atk;
                    if (enemy1choice == 1) example2.health -= enemy1atk;
                    if (enemy1choice == 2) example3.health -= enemy1atk;
                    if (enemy1choice == 3) example4.health -= enemy1atk;
                    healthupdate();
                }
            }
            if (enemyhealth2.Value > 0)
            {
                if (enemy2speed < 100) enemy2speed += 10;
                else
                {
                    enemy2choice = random.Next(0, 3);
                    enemy2speed = 0;


                    if (enemy2choice == 0) example.health -= enemy2atk;
                    if (enemy2choice == 1) example2.health -= enemy2atk;
                    if (enemy2choice == 2) example3.health -= enemy2atk;
                    if (enemy2choice == 3) example4.health -= enemy2atk;
                    healthupdate();
                }
            }
            if (enemyhealth3.Value > 0)
            {
                if (enemy3speed < 100) enemy3speed += 10;
                else
                {
                    enemy3choice = random.Next(0, 3);
                    enemy3speed = 0;


                    if (enemy3choice == 0) example.health -= enemy3atk;
                    if (enemy3choice == 1) example2.health -= enemy3atk;
                    if (enemy3choice == 2) example3.health -= enemy3atk;
                    if (enemy3choice == 3) example4.health -= enemy3atk;
                    healthupdate();
                }
            }
            if (enemyhealth1.Value <= 0 && enemyhealth2.Value <= 0  && enemyhealth3.Value <= 0)
            {

            }
        }
       
        private void wait1 (object hero1, EventArgs hero1event)
        {
            if (speedbar1.Value < 100) speedbar1.Value += Convert.ToInt32(example.speed);
            else action1(hero1, hero1event);
        }
        private void wait2 (object hero2, EventArgs hero2event)
        {
            if (Speedbar2.Value < 100) speedbar1.Value += Convert.ToInt32(example.speed);
            else action2(hero2, hero2event);
        }
        private void wait3 (object hero3, EventArgs hero3event)
        {
            if (Speedbar3.Value < 100) Speedbar3.Value += Convert.ToInt32(example.speed);
            else action3(hero3, hero3event);
        }
        private void wait4 (object hero4, EventArgs hero4event)
        {
            if (Speedbar4.Value < 100) Speedbar4.Value += Convert.ToInt32(example.speed);
            else action4(hero4, hero4event);
        }
        private void action1 (object hero1, EventArgs hero1event)
        {
            herotimer1.Stop();
            Attackbutton1.Enabled = true;
            Skillbutton1.Enabled = true;
            Itembutton1.Enabled = true;
        }
        private void action2 (object hero2, EventArgs hero2event)
        {
            herotimer2.Stop();
            Attackbutton2.Enabled = true;
            Skillbutton2.Enabled = true;
            Itembutton2.Enabled = true;
        }
        private void action3 (object hero3, EventArgs hero3event)
        {
            herotimer3.Stop();
            Attackbutton3.Enabled = true;
            Skillbutton3.Enabled = true;
            Itemsbutton3.Enabled = true;
        }
        private void action4 (object hero4, EventArgs hero4event)
        {
            herotimer4.Stop();
            Attackbutton4.Enabled = true;
            Skillbutton4.Enabled = true;
            Itemsbutton4.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            atkchose = 2;
        }

        private void Attackbutton1_Click(object sender, EventArgs e)
        {

            if (atkchose == 1) enemy1health -= example.attack * 3;
            if (atkchose == 2) enemy2health -= example.attack * 3;
            if (atkchose == 3) enemy3health -= example.attack * 3;

            speedbar1.Value = 0;
            Attackbutton1.Enabled = false;
            Skillbutton1.Enabled = false;
            Itembutton1.Enabled = false;
            healthupdate();
            herotimer1.Start();
        }

        private void Skillbutton1_Click(object sender, EventArgs e)
        {
            speedbar1.Value = 0;
            textBox1.Show();
            label1.Text = "";
            Attackbutton1.Enabled = false;
            Skillbutton1.Enabled = false;
            Itembutton1.Enabled = false;
            minigametimer1.Start();
        }
        private void minigame1(object player1, EventArgs player)
        {
            if (minigame1count != 20)
            {
                minigame1count++;
            }
            else
            {
                label1.Hide();
                if (label1.Text == textBox1.Text)
                {
                    if (atkchose == 1) enemy1health -= 70;
                    if (atkchose == 2) enemy2health -= 70;
                    if (atkchose == 3) enemy3health -= 70;
                    herotimer1.Start();
                }
                else HealthBar1.Value -= HealthBar1.Value;
                healthupdate();
                herotimer1.Start();
                minigametimer1.Stop();
            }
            
        }

        private void Skillbutton2_Click(object sender, EventArgs e)
        {
            label2.Show();
            minigametimer2.Start();
            Attackbutton2.Enabled = false;
            Skillbutton2.Enabled = false;
            Itembutton2.Enabled = false;

        }
        private void minigame2 (object sender, EventArgs e)
        {
         
            if (minigame2count < 20) minigame2count++;
            else
            {
                label2.Hide();
                if (count2 > 100)
                {
                    if (atkchose == 1) enemy1health -= example.attack * 10;
                    if (atkchose == 2) enemy2health -= example.attack * 10;
                    if (atkchose == 3) enemy3health -= example.attack * 10;
                    herotimer2.Start();
                }
                else Healthbar2.Value -= Healthbar2.Value;
                minigame2count = 0;
                count2 = 0;
                minigametimer2.Stop();
                healthupdate();
            }
            
            
        }

        private void Attackbutton2_Click(object sender, EventArgs e)
        {
            if (atkchose == 1) enemy1health -= example.attack * 3;
            if (atkchose == 2) enemy2health -= example.attack * 3;
            if (atkchose == 3) enemy3health -= example.attack * 3;

            Speedbar2.Value = 0;
            Attackbutton2.Enabled = false;
            Skillbutton2.Enabled = false;
            Itembutton2.Enabled = false;
            healthupdate();
            herotimer2.Start();
        }

        private void Attackbutton3_Click(object sender, EventArgs e)
        {
            if (atkchose == 1) enemy1health -= example.attack * 3;
            if (atkchose == 2) enemy2health -= example.attack * 3;
            if (atkchose == 3) enemy3health -= example.attack * 3;

            Speedbar3.Value = 0;
            Attackbutton3.Enabled = false;
            Skillbutton3.Enabled = false;
            Itemsbutton3.Enabled = false;
            healthupdate();
            herotimer3.Start();
        }

        private void Attackbutton4_Click(object sender, EventArgs e)
        {
            if (atkchose == 1) enemy1health -= example.attack * 3;
            if (atkchose == 2) enemy2health -= example.attack * 3;
            if (atkchose == 3) enemy3health -= example.attack * 3;

            Speedbar4.Value = 0;
            Attackbutton4.Enabled = false;
            Skillbutton4.Enabled = false;
            Itemsbutton4.Enabled = false;
            healthupdate();
            herotimer4.Start();
        }

        private void Skillbutton2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) count2++;
        }

        private void Skillbutton3_Click(object sender, EventArgs e)
        {
            minigame3button.Show();
            minigametimer3.Start();
        }
        private void minigame3 (object sender, EventArgs e)
        {
            
            if (minigame3count < 20) minigame3count++;
            else
            {
                if (count3 >= 25)
                {
                    if (atkchose == 1) enemy1health -= example.attack * 9;
                    if (atkchose == 2) enemy2health -= example.attack * 9;
                    if (atkchose == 3) enemy3health -= example.attack * 9;
                    herotimer3.Start();
                }
                else Healthbar3.Value -= Healthbar3.Value; 
                healthupdate();
                minigametimer3.Stop();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int random1 = random.Next(0, 126);
            int random2 = random.Next(0,850);
            count3++;
            minigametimer3.Interval -= 200;
            minigame3button.Location = new System.Drawing.Point(random2, random1);
        }

        private void enemypic1_Click(object sender, EventArgs e)
        {
            atkchose = 1;
        }

        private void enemypic3_Click(object sender, EventArgs e)
        {
            atkchose = 3;
        }
        private void healthupdate()
        {
            enemyhealth1.Value = enemy1health;
            enemyhealth2.Value = enemy2health;
            enemyhealth3.Value = enemy3health;
            HealthBar1.Value = example.health;
            Healthbar2.Value = example2.health;
            Healthbar3.Value = example3.health;
            Healthbar4.Value = example4.health;
            
        }
        private void enemychooser()
        {

        }

        private void Skillbutton4_Click(object sender, EventArgs e)
        {
            example.health += 25;
            example2.health += 25;
            example3.health += 25;
            example4.health -= 50;
            healthupdate();
        }
    }
}
    
    

