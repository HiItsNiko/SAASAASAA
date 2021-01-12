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
    public partial class FormStory : Form
    {
        public FormStory()
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
                FormGameplay myForm = new FormGameplay();
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }
        }

        private void FormStory_Load(object sender, EventArgs e)
        {
            
        }
    }
}
