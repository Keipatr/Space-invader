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
    public partial class MenuControl : Form
    {
        public MenuControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backToMenuScreen(object sender, EventArgs e)
        {
            this.Hide();
            MenuScreen myForm = new MenuScreen();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
