
namespace Space_invader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.invaderNembak = new System.Windows.Forms.Timer(this.components);
            this.tesLaser = new System.Windows.Forms.Timer(this.components);
            this.pbthunder = new System.Windows.Forms.PictureBox();
            this.pbHeart = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pbLIFE = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblLife = new System.Windows.Forms.Label();
            this.powerup = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbthunder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLIFE)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "score";
            // 
            // invaderNembak
            // 
            this.invaderNembak.Enabled = true;
            this.invaderNembak.Interval = 1000;
            this.invaderNembak.Tick += new System.EventHandler(this.invaderNembak_Tick);
            // 
            // tesLaser
            // 
            this.tesLaser.Enabled = true;
            this.tesLaser.Interval = 20;
            this.tesLaser.Tick += new System.EventHandler(this.tesLaser_Tick);
            // 
            // pbthunder
            // 
            this.pbthunder.BackColor = System.Drawing.Color.Transparent;
            this.pbthunder.Image = global::Space_invader.Properties.Resources.thunder;
            this.pbthunder.Location = new System.Drawing.Point(226, 11);
            this.pbthunder.Name = "pbthunder";
            this.pbthunder.Size = new System.Drawing.Size(33, 27);
            this.pbthunder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbthunder.TabIndex = 24;
            this.pbthunder.TabStop = false;
            this.pbthunder.Tag = "thunder";
            this.pbthunder.Visible = false;
            // 
            // pbHeart
            // 
            this.pbHeart.BackColor = System.Drawing.Color.Transparent;
            this.pbHeart.Image = ((System.Drawing.Image)(resources.GetObject("pbHeart.Image")));
            this.pbHeart.Location = new System.Drawing.Point(314, 12);
            this.pbHeart.Name = "pbHeart";
            this.pbHeart.Size = new System.Drawing.Size(33, 27);
            this.pbHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHeart.TabIndex = 23;
            this.pbHeart.TabStop = false;
            this.pbHeart.Tag = "heart";
            this.pbHeart.Visible = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::Space_invader.Properties.Resources.invader3;
            this.pictureBox18.Location = new System.Drawing.Point(535, 153);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(61, 40);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox18.TabIndex = 22;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "invader";
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = global::Space_invader.Properties.Resources.invader3;
            this.pictureBox17.Location = new System.Drawing.Point(159, 153);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(61, 40);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox17.TabIndex = 21;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "invader";
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::Space_invader.Properties.Resources.invader3;
            this.pictureBox16.Location = new System.Drawing.Point(253, 153);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(61, 40);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 20;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "invader";
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::Space_invader.Properties.Resources.invader3;
            this.pictureBox15.Location = new System.Drawing.Point(349, 153);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(61, 40);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox15.TabIndex = 19;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "invader";
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::Space_invader.Properties.Resources.invader3;
            this.pictureBox14.Location = new System.Drawing.Point(441, 153);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(61, 40);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 18;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "invader";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::Space_invader.Properties.Resources.invader3;
            this.pictureBox13.Location = new System.Drawing.Point(67, 153);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(61, 40);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 17;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "invader";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::Space_invader.Properties.Resources.invader2;
            this.pictureBox12.Location = new System.Drawing.Point(535, 81);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(61, 40);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 16;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "invader";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Space_invader.Properties.Resources.invader2;
            this.pictureBox11.Location = new System.Drawing.Point(67, 81);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(61, 40);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 15;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "invader";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Space_invader.Properties.Resources.invader2;
            this.pictureBox10.Location = new System.Drawing.Point(159, 81);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(61, 40);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 14;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "invader";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Space_invader.Properties.Resources.invader2;
            this.pictureBox9.Location = new System.Drawing.Point(253, 81);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(61, 40);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 13;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "invader";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Space_invader.Properties.Resources.invader2;
            this.pictureBox8.Location = new System.Drawing.Point(441, 81);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(61, 40);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "invader";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Space_invader.Properties.Resources.invader2;
            this.pictureBox7.Location = new System.Drawing.Point(349, 81);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(61, 40);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "invader";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Space_invader.Properties.Resources.invader1;
            this.pictureBox3.Location = new System.Drawing.Point(159, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "invader";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Space_invader.Properties.Resources.invader1;
            this.pictureBox6.Location = new System.Drawing.Point(441, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(61, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "invader";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Space_invader.Properties.Resources.invader1;
            this.pictureBox5.Location = new System.Drawing.Point(349, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(61, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "invader";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Space_invader.Properties.Resources.invader1;
            this.pictureBox4.Location = new System.Drawing.Point(253, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(61, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "invader";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Space_invader.Properties.Resources.invader1;
            this.pictureBox1.Location = new System.Drawing.Point(67, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "invader";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Space_invader.Properties.Resources.invader1;
            this.pictureBox2.Location = new System.Drawing.Point(535, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "invader";
            // 
            // player
            // 
            this.player.Image = global::Space_invader.Properties.Resources.tank;
            this.player.Location = new System.Drawing.Point(297, 367);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // pbLIFE
            // 
            this.pbLIFE.BackColor = System.Drawing.Color.Transparent;
            this.pbLIFE.Image = ((System.Drawing.Image)(resources.GetObject("pbLIFE.Image")));
            this.pbLIFE.Location = new System.Drawing.Point(609, 12);
            this.pbLIFE.Name = "pbLIFE";
            this.pbLIFE.Size = new System.Drawing.Size(20, 16);
            this.pbLIFE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLIFE.TabIndex = 25;
            this.pbLIFE.TabStop = false;
            this.pbLIFE.Tag = "heart";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(628, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "X";
            // 
            // LblLife
            // 
            this.LblLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLife.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LblLife.Location = new System.Drawing.Point(647, 10);
            this.LblLife.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLife.Name = "LblLife";
            this.LblLife.Size = new System.Drawing.Size(35, 19);
            this.LblLife.TabIndex = 27;
            this.LblLife.Text = "3";
            // 
            // powerup
            // 
            this.powerup.Enabled = true;
            this.powerup.Interval = 20;
            this.powerup.Tick += new System.EventHandler(this.powerup_Tick);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.LblLife);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbLIFE);
            this.Controls.Add(this.pbthunder);
            this.Controls.Add(this.pbHeart);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbthunder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLIFE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.Timer invaderNembak;
        private System.Windows.Forms.Timer tesLaser;
        private System.Windows.Forms.PictureBox pbHeart;
        private System.Windows.Forms.PictureBox pbthunder;
        private System.Windows.Forms.PictureBox pbLIFE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblLife;
        private System.Windows.Forms.Timer powerup;
    }
}

