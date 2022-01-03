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
        int totalEnemies = 18;
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
            //player gerak kiri kanan (timer)
            if (goleft)
            {
                player.Left -= playerspeed;
            }
            else if (goright)
            {
                player.Left += playerspeed;
            }
            //invader gerak dan kebawah, kena player = gameover
            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && x.Tag == "invader")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        gameOver();
                        this.Hide();
                        GameLose formGameLose = new GameLose();
                        formGameLose.ShowDialog();
                        this.Close();
                    }
                          ((PictureBox)x).Left += speed;

                    if (((PictureBox)x).Left > 720 && row == 1)
                    {
                        ((PictureBox)x).Left = -50;
                        count++;
                    }
                    if (count == 18)
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
                //peluru player nembak, ilang lewati batas map
                foreach (Control y in this.Controls)
                {
                    if (y is PictureBox && y.Tag == "bullet")
                    {
                        y.Top -= 5;

                        if (((PictureBox)y).Top < this.Height - 490)
                        {
                            this.Controls.Remove(y);
                        }
                    }
                }
                //peluru kontak dengan invader ilangkan bulet dan invader
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
                //score dan menang
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
        private void invaderBoss(PictureBox k)
        {
            PictureBox boss = new PictureBox();

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
        private void invaderBullet(PictureBox a)
        {
            PictureBox invaderBullet = new PictureBox();
            invaderBullet.Location = new Point(a.Location.X + a.Width / 3, a.Location.Y + 20);
            invaderBullet.Size = new Size(5, 20);
            invaderBullet.BackgroundImage = Properties.Resources.bulletinvader;
            invaderBullet.BackgroundImageLayout = ImageLayout.Stretch;
            invaderBullet.Tag = "Laser";
            this.Controls.Add(invaderBullet);
            invaderBullet.BringToFront();

        }
        private void gameOver()
        {
            timer1.Stop();
            invaderNembak.Stop();
            tesLaser.Stop();
            label1.Text = " Game Over";
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

        private void invaderNembak_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int angka = rand.Next(1,18);
            if(angka == 1)
            {
                invaderBullet(pictureBox1);
            }
            if (angka == 2)
            {
                invaderBullet(pictureBox3);
            }
            if (angka == 3)
            {
                invaderBullet(pictureBox4);
            }
            if (angka == 4)
            {
                invaderBullet(pictureBox5);
            }
            if (angka == 5)
            {
                invaderBullet(pictureBox6);
            }
            if (angka == 6)
            {
                invaderBullet(pictureBox11);
            }
            if (angka == 7)
            {
                invaderBullet(pictureBox10);
            }
            if (angka == 8)
            {
                invaderBullet(pictureBox9);
            }
            if (angka == 9)
            {
                invaderBullet(pictureBox7);
            }
            if (angka == 10)
            {
                invaderBullet(pictureBox8);
            }
            if (angka == 11)
            {
                invaderBullet(pictureBox13);
            }
            if (angka == 12)
            {
                invaderBullet(pictureBox17);
            }
            if (angka == 13)
            {
                invaderBullet(pictureBox16);
            }
            if (angka == 14)
            {
                invaderBullet(pictureBox15);
            }
            if (angka == 15)
            {
                invaderBullet(pictureBox14);
            }
            if (angka == 16)
            {
                invaderBullet(pictureBox12);
            }
            if (angka == 17)
            {
                invaderBullet(pictureBox18);
            }
            if (angka == 18)
            {
                invaderBullet(pictureBox2);
            }
        }

        private void tesLaser_Tick(object sender, EventArgs e)
        {
            foreach (Control i in this.Controls)
            {
                if (i is PictureBox && i.Tag == "Laser")
                {
                    i.Top += 5;

                    if (i.Location.Y >= this.Height)
                    {
                        this.Controls.Remove(i);
                    }
                }
            }
            foreach (Control i in this.Controls)
            {
                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && j.Tag == "player")
                    {
                        if (i is PictureBox && i.Tag == "Laser")
                        {
                            if (i.Bounds.IntersectsWith(j.Bounds))
                            {
                                this.Controls.Remove(i);
                                this.Controls.Remove(j);
                                gameOver();
                                // fitur live untuk mines
                            }
                        }
                    }
                }
            }
        }        
    }
}
