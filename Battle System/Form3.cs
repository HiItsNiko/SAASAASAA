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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void FormStory_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void FormStory_KeyDown(object sender, KeyEventArgs e)
        {
            //opening gameplay form using f key
            if (e.KeyCode == Keys.F)
            {
                Form4 myForm = new Form4();
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }
        }

        private void FormStory_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
