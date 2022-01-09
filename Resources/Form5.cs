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
    public partial class Form5 : Form
    {
        bool goleft;
        bool goright;
        int speed = 6;
        int speedboss = 5;
        int score = 50;
        bool isPressed;
        int playerspeed = 5;
        int count = 0;
        int row = 1;
        int count1 = 0;
        int temp = 0;
        int hpboss = 11;
        int life = 4; //ditambahkan karena untuk kepentingan power up
        //penambahan deklarasi
        bool thundershow = false; //belum muncul
        bool heartshow = false;   //belum muncul 
        Random rnd = new Random();
        int powerheartspeed = 5 * 50; //speed kemunculan hati 50 artinya perdetik dengan interval timer 20
        int powerthunderspeed = 3 * 50;
        int ctrheart = 0;
        int ctrthunder = 0;

        public Form5()
        {
            InitializeComponent();
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
                if (x is PictureBox && x.Tag.ToString() == "invader")
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
                    if (count == 18 - temp)
                    {
                        count = 0;
                        row = 2;
                    }
                    if (((PictureBox)x).Left > 720 && row == 2)
                    {
                        ((PictureBox)x).Top += ((PictureBox)x).Height + 25;
                        ((PictureBox)x).Left = -50;
                        count1++;
                    }
                    if (count1 == 18 - temp)
                    {
                        row = 1;
                        count1 = 0;
                    }
                }
                if (x is PictureBox && x.Tag.ToString() == "boss")
                {
                    ((PictureBox)x).Left += speedboss;
                    if (((PictureBox)x).Left > 720)
                    {
                        ((PictureBox)x).Left = -50;
                    }
                }
                //peluru player nembak, ilang lewati batas map
                foreach (Control y in this.Controls)
                {
                    if (y is PictureBox && y.Tag.ToString() == "bullet")
                    {
                        y.Top -= 3;

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
                        if (i is PictureBox && i.Tag.ToString() == "invader")
                        {
                            if (j is PictureBox && j.Tag.ToString() == "bullet")
                            {
                                if (i.Bounds.IntersectsWith(j.Bounds))
                                {
                                    score++;
                                    temp++;
                                    this.Controls.Remove(i);
                                    this.Controls.Remove(j);
                                }
                            }
                        }
                    }
                }
                foreach (Control i in this.Controls)
                {
                    foreach (Control j in this.Controls)
                    {
                        if (i is PictureBox && i.Tag.ToString() == "boss")
                        {
                            if (j is PictureBox && j.Tag.ToString() == "bullet")
                            {

                                if (i.Bounds.IntersectsWith(j.Bounds))
                                {
                                    hpboss--;
                                    this.Controls.Remove(j);
                                    if (hpboss == 0)
                                    {
                                        score = score + 7;
                                        this.Controls.Remove(i);
                                        this.Controls.Remove(j);
                                        Form6(); //form 6 muncul 
                                    }                                   
                                }
                            }
                        }
                    }
                }
                label1.Text = "Score : " + score;
                invaderBoss();
            }
        }
        private void Form5_KeyDown(object sender, KeyEventArgs e)
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

        private void Form5_KeyUp(object sender, KeyEventArgs e)
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
        private void invaderBoss()
        {
            if (temp == 18)
            {
                PictureBox boss = new PictureBox();
                boss.Image = Properties.Resources.boss;
                boss.BackgroundImageLayout = ImageLayout.Zoom;
                boss.Size = new Size(190, 170);
                boss.Tag = "boss";
                boss.Name = "boss";
                boss.Location = new Point(210, 12);
                this.Controls.Add(boss);
                boss.BringToFront();
                temp = 0;
            }
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
       
        private void BossBulet(PictureBox b)
        {
            PictureBox bossBulet1 = new PictureBox();
            bossBulet1.Location = new Point(b.Location.X + b.Width / 3, b.Location.Y + 20);
            bossBulet1.Size = new Size(5, 20);
            bossBulet1.BackgroundImage = Properties.Resources.bulletinvader;
            bossBulet1.BackgroundImageLayout = ImageLayout.Stretch;
            bossBulet1.Tag = "Laser";
            this.Controls.Add(bossBulet1);
            PictureBox bossBulet2 = new PictureBox();
            bossBulet2.Location = new Point(b.Location.X + b.Width / 1 - 5, b.Location.Y + 20);
            bossBulet2.Size = new Size(5, 20);
            bossBulet2.BackgroundImage = Properties.Resources.bulletinvader;
            bossBulet2.BackgroundImageLayout = ImageLayout.Stretch;
            bossBulet2.Tag = "Laser";
            this.Controls.Add(bossBulet2);
        }
        private void gameOver()
        {
            timer1.Stop();
            invaderNembak.Stop();
            tesLaser.Stop();
            label1.Text = " Game Over";
            this.Hide();
            GameLose formGameLose = new GameLose();
            formGameLose.ShowDialog();
            this.Close();
        }
        private void Form6()
        {
            timer1.Stop();
            invaderNembak.Stop();
            tesLaser.Stop();
            this.Hide();
            Form6 form6 = new Form6();
            form6.ShowDialog();
            this.Close();
        }

        private void invaderNembak_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int angka = rand.Next(1, 18);
            if (score < 68)
            {
                if (angka == 1)
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
            foreach (Control b in this.Controls)
            {
                if (b is PictureBox && b.Name == "boss")
                {
                    PictureBox boss = (PictureBox)b;
                    BossBulet(boss);
                }
            }
        }

        private void tesLaser_Tick(object sender, EventArgs e)
        {
            foreach (Control i in this.Controls)
            {
                if (i is PictureBox && i.Tag.ToString() == "Laser")
                {
                    i.Top += 7; //invader bullet
                    if (score == 18) // untuk boss
                    {
                        i.Top += 9; //Boss Bulet
                    }
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
                    if (j is PictureBox && j.Tag.ToString() == "player")
                    {
                        if (i is PictureBox && i.Tag.ToString() == "Laser")
                        {
                            if (i.Bounds.IntersectsWith(j.Bounds))
                            {
                                this.Controls.Remove(i); //hapus laser

                                life -= 1;
                                LblLife.Text = life.ToString();
                                if (life == 0)
                                {
                                    gameOver();
                                    this.Controls.Remove(j); //hapus ufo
                                }
                            }
                        }
                    }
                }
            }
        }

        private void powerup_Tick(object sender, EventArgs e)
        {
            //interval setting = 20
            //interval setting = 1000 = 1 detik
            //kalau 20 artinya 1 detik procedure ini dipanggil 1000/20 ==> 50 x 
            //powershowspeed = 50 artinya 1 detik dicari peluangnya
            ctrheart++;
            if (powerheartspeed == ctrheart) //tiap 1 detik
            {
                ctrheart = 0;
                int peluang = rnd.Next(200); //hitung peluang kemunculan

                if (peluang > 5) //peluang 1/5 artinya kemungkinan 5 detik muncul 1x
                {
                    if (heartshow == false && thundershow == false) //jika power heart nya belum tampil
                    {
                        heartshow = true;
                        pbHeart.Top = 0; //posisi dikembalikan ke atas
                        pbHeart.Visible = true; //ditampilkan                        
                    }
                }
            }
            if (heartshow == true)
            {
                pbHeart.Top += 4; //bergerak 5 pixel
                //Console.WriteLine(pbthunder.Left + "-" + pbthunder.Top);
                if (pbHeart.Top == Height)
                {
                    pbHeart.Visible = false;
                    heartshow = false;
                }
            }
            ctrthunder++;
            if (powerthunderspeed == ctrthunder) //tiap 1 detik
            {
                ctrthunder = 0;
                int peluang2 = rnd.Next(100); //hitung peluang kemunculan

                if (peluang2 > 20) //peluang 1/5 artinya kemungkinan 5 detik muncul 1x
                {
                    if (thundershow == false && heartshow == false) //jika power heart nya belum tampil
                    {
                        thundershow = true;
                        pbthunder.Top = 0; //posisi dikembalikan ke atas
                        pbthunder.Visible = true; //ditampilkan
                    }
                }
            }

            if (thundershow == true)
            {
                pbthunder.Top += 4; //bergerak 5 pixel turun 
                //Console.WriteLine(pbthunder.Left + "-" + pbthunder.Top);
                if (pbthunder.Top == Height)
                {
                    pbthunder.Visible = false; // picturebox thunder
                    thundershow = false;
                }
            }
            foreach (Control x in this.Controls)
            {
                //jika kena heart
                if (x is PictureBox && x.Tag.ToString() == "heart")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        life++;
                        LblLife.Text = life.ToString();
                        heartshow = false;
                        pbHeart.Visible = false;
                        pbHeart.Top = 0;
                    }
                }
                //jika kena speed/thunder
                if (x is PictureBox && x.Tag.ToString() == "thunder")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        playerspeed++;
                        thundershow = false;
                        pbthunder.Visible = false;
                        pbthunder.Top = 0;
                    }
                }
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pbthunder_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pbLIFE_Click(object sender, EventArgs e)
        {

        }

        private void player_Click(object sender, EventArgs e)
        {

        }
    }
}
  

      
