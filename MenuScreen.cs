using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_invader
{
    public partial class MenuScreen : Form
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void clickToBegin(object sender, EventArgs e)
        {
            this.Hide();
            Form1 myForm = new Form1();
            myForm.ShowDialog();
            this.Close();
        }

        private void MenuScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void klikMasukControl(object sender, EventArgs e)
        {
            this.Hide();
            MenuControl myForm = new MenuControl();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
