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
    public partial class YouWin : Form
    {
        public YouWin()
        {
            InitializeComponent();
        }

        private void clickToBegin(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();  //form disembunyikan
            MenuScreen myForm = new MenuScreen(); //membuat menuscreen
            myForm.ShowDialog();       // menampilkan menuscreen
            this.Close();
        }
    }
}
