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
    public partial class Form1 : Form
    {
        bool goleft;
        bool goright;
        int speed = 5;
        int score = 0;
        bool isPressed;
        int totalEnemies = 11;
        int playerspeed = 4;
        int count = 0;
        int row = 1;
        public Form1()
        {
            InitializeComponent();            
        }        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (goleft)
            {
                player.Left -= playerspeed;
            }
            else if (goright)
            {
                player.Left += playerspeed;
            }
            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && x.Tag == "invader")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        gameOver();

                    }

                          ((PictureBox)x).Left += speed;

                    if (((PictureBox)x).Left > 720 && row == 1)
                    {
                        ((PictureBox)x).Left = -50;
                        count++;
                    }
                    if (count == 11)
                    {
                        count = 0;
                        row = 2;
                    }
                    if (((PictureBox)x).Left > 720 && row == 2)
                    {
                        ((PictureBox)x).Top += ((PictureBox)x).Height + 25;
                        ((PictureBox)x).Left = -50;
                    }
                }
                foreach (Control y in this.Controls)
                {
                    if (y is PictureBox && y.Tag == "bullet")
                    {

                        y.Top -= 20;

                        if (((PictureBox)y).Top < this.Height - 490)
                        {
                            this.Controls.Remove(y);
                        }
                    }
                }
                foreach (Control i in this.Controls)
                {
                    foreach (Control j in this.Controls)
                    {
                        if (i is PictureBox && i.Tag == "invader")
                        {
                            if (j is PictureBox && j.Tag == "bullet")
                            {

                                if (i.Bounds.IntersectsWith(j.Bounds))
                                {
                                    score++;
                                    this.Controls.Remove(i);
                                    this.Controls.Remove(j);
                                }
                            }
                        }
                    }
                }
                label1.Text = "Score : " + score;

                if (score > totalEnemies - 1)
                {
                    gameOver();
                    MessageBox.Show("You Win");
                }
            }
        }


            private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Space && !isPressed)
            {
                isPressed = true;

                makeBullet();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                goright = false;
            }
            if (isPressed)
            {
                isPressed = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void makeBullet()
        {
            PictureBox bullet = new PictureBox();

            bullet.Image = Properties.Resources.bullet;

            bullet.Size = new Size(5, 20);

            bullet.Tag = "bullet";

            bullet.Left = player.Left + player.Width / 2;

            bullet.Top = player.Top - 20;

            this.Controls.Add(bullet);

            bullet.BringToFront();

        }
        private void gameOver()
        {
            timer1.Stop();
            label1.Text += " Game Over";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
       
    }
}
