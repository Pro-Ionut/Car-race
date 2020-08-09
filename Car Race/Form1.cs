using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Race
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
            restart.Visible = false;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation =@"C:\Users\cionc\OneDrive\Desktop\C# Projects\Car Race\Car Race\music.wav";
            player.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int gamespeed = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            coins(gamespeed);
            coincollection();
        }

        Random r = new Random();
        int x = 0, y = 0;
        void enemy(int speed)
        {
            if (enemy1.Top >= 600)
            {
                x = r.Next(0, 200);

                enemy1.Location = new Point(x, 0);
            }
            else enemy1.Top += speed;

            if (enemy2.Top >= 600)
            {
                x = r.Next(250, 300);

                enemy2.Location = new Point(x, y);
            }
            else enemy2.Top += speed;

            if (enemy3.Top >= 600)
            {
                x = r.Next(100, 300);

                enemy3.Location = new Point(x, y);
            }
            else enemy3.Top += speed;

        }

        void coins(int speed)
        {
            if (coin1.Top >= 600)
            {
                x = r.Next(0, 200);

                coin1.Location = new Point(x, 0);
            }
            else coin1.Top += speed;

            if (coin2.Top >= 600)
            {
                x = r.Next(0, 200);

                coin2.Location = new Point(x, 0);
            }
            else coin2.Top += speed;

            if (coin3.Top >= 600)
            {
                x = r.Next(0, 200);

                coin3.Location = new Point(x, 0);
            }
            else coin3.Top += speed;

            if (coin4.Top >= 600)
            {
                x = r.Next(0, 200);

                coin4.Location = new Point(x, 0);
            }
            else coin4.Top += speed;


        }
        int collectedcoins = 0;
        void coincollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoins++;
                coin.Text = "Coins=" + collectedcoins.ToString();
                x = r.Next(0, 200);
                coin1.Location = new Point(x, 0);

            }
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoins++;
                coin.Text = "Coins=" + collectedcoins.ToString();
                x = r.Next(0, 200);

                coin2.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoins++;
                coin.Text = "Coins=" + collectedcoins.ToString();
                x = r.Next(0, 200);

                coin3.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoins++;
                coin.Text = "Coins=" + collectedcoins.ToString();
                x = r.Next(0, 200);

                coin4.Location = new Point(x, 0);
            }
        }


        void gameover()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
                restart.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
                restart.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;

            }

        }
        void moveline(int speed)
        {
            if (pictureBox1.Top > 600)
                pictureBox1.Top = 0;
            else pictureBox1.Top += speed;

            if (pictureBox2.Top > 600)
                pictureBox2.Top = 0;
            else pictureBox2.Top += speed;

            if (pictureBox3.Top > 600)
                pictureBox3.Top = 0;
            else pictureBox3.Top += speed;

            if (pictureBox4.Top > 600)
                pictureBox4.Top = 0;
            else pictureBox4.Top += speed;

            if (pictureBox5.Top > 600)
                pictureBox5.Top = 0;
            else pictureBox5.Top += speed;




        }

        private void pictureBox9_Click(object sender, EventArgs e) { }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void over_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left > 10)
                    car.Left += -gamespeed;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 375)
                    car.Left += 10;
            }
            if (e.KeyCode == Keys.Up)
                if (gamespeed < 21)
                {
                    gamespeed++;
                }
            if (e.KeyCode == Keys.Down)
                if (gamespeed > 0)
                {
                    gamespeed--;
                }
            if (e.KeyCode == Keys.Enter)
            {
                Application.Restart();
            }
        }
    }
}