using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space
{
    public partial class Form1 : Form
    {

        public int newX = 0;
        public int newY = 0;
        public const int pxlmvX = 15;
        public const int pxlmvY = 15;

        public bool roomUp = false;
        public bool roomDown = false;
        public bool roomLeft = false;
        public bool roomRight = false;
        public bool inRoom = false;

        string[] pictureBoxArray = new string[] { @"C:\Users\One\source\repos\Space\Space\Resources\normal.png", @"C:\Users\One\source\repos\Space\Space\Resources\normalLeft.png", @"C:\Users\One\source\repos\Space\Space\Resources\back.png", @"C:\Users\One\source\repos\Space\Space\Resources\down.png" };
        Image hub = new Bitmap(@"C:\Users\One\source\repos\Space\Space\Resources\Hub.png");
        Image rmup = new Bitmap(@"C:\Users\One\source\repos\Space\Space\Resources\CameraSus.png");
        Image rmdown = new Bitmap(@"C:\Users\One\source\repos\Space\Space\Resources\CameraJos.png");
        Image rmleft = new Bitmap(@"C:\Users\One\source\repos\Space\Space\Resources\CameraStanga.png");
        Image rmright = new Bitmap(@"C:\Users\One\source\repos\Space\Space\Resources\CameraDreapta.png");

        public Form1()
        {
            InitializeComponent();
            BackgroundImage = hub;
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                Up.Enabled = true;
            }
            if (e.KeyCode == Keys.S)
            {
                Down.Enabled = true;
            }
            if (e.KeyCode == Keys.A)
            {
                Left.Enabled = true;
            }
            if (e.KeyCode == Keys.D)
            {
                Right.Enabled = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                Up.Enabled = false;
            }
            if (e.KeyCode == Keys.S)
            {
                Down.Enabled = false;
            }
            if (e.KeyCode == Keys.A)
            {
                Left.Enabled = false;
            }
            if (e.KeyCode == Keys.D)
            {
                Right.Enabled = false;
            }
        }

        

        private void Up_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y > 0)
            {
                newY = pictureBox1.Location.Y - pxlmvY;
                pictureBox1.Location = new Point(pictureBox1.Location.X, newY);
                pictureBox1.ImageLocation = pictureBoxArray[2];
                if (roomUp == false)
                    Up_Room_Entrance();
                
                if (roomDown == true)
                    Down_Room_Exit();

                if (roomUp || roomRight || roomLeft || roomDown)
                {
                    Interaction(pictureBox1, pictureBox2);
                }
            }
            
            
        }

        private void Down_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y < this.Height)
            {
                newY = pictureBox1.Location.Y + pxlmvY;
                pictureBox1.Location = new Point(pictureBox1.Location.X, newY);
                pictureBox1.ImageLocation = pictureBoxArray[3];
                
                if (roomUp == true)
                    Up_Room_Exit();
                if (roomDown == false)
                    Down_Room_Entrance();

                if (roomUp || roomRight || roomLeft || roomDown)
                {
                    Interaction(pictureBox1, pictureBox2);
                }
            }
        }

        private void Left_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X > 0)
            {
                newX = pictureBox1.Location.X - pxlmvX;
                pictureBox1.Location = new Point(newX, pictureBox1.Location.Y);
                pictureBox1.ImageLocation = pictureBoxArray[1];
                if (roomRight == true)
                    Right_Room_Exit();
                if (roomLeft == false)
                    Left_Room_Entrance();

                if (roomUp || roomRight || roomLeft || roomDown)
                {
                    Interaction(pictureBox1, pictureBox2);
                }

            }
        }

        private void Right_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X < this.Width)
            {
                newX = pictureBox1.Location.X + pxlmvX;
                pictureBox1.Location = new Point(newX, pictureBox1.Location.Y);
                pictureBox1.ImageLocation = pictureBoxArray[0];
                if (roomLeft == true)
                    Left_Room_Exit();
                if (roomRight == false)
                    Right_Room_Entrance();

                if (roomUp || roomRight || roomLeft || roomDown)
                {
                    Interaction(pictureBox1, pictureBox2);
                }

            }
        }

        public void Up_Room_Entrance()
        {
            if (pictureBox1.Location.Y == 0 && pictureBox1.Location.X >= 395 && pictureBox1.Location.X <= 525 && inRoom == false)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, 1080);
                BackgroundImage = rmup;
                roomUp = true;
                inRoom = true;
                LoadUpRoom();
               
            }
    
        }

        public void Up_Room_Exit()
        {
            if (pictureBox1.Location.Y == 1080 && pictureBox1.Location.X >= 395 && pictureBox1.Location.X <= 525)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, 0);
                BackgroundImage = hub;
                roomUp = false;
                inRoom = false;
                HideUpRoom();
            }
        }

        public void Down_Room_Entrance()
        {
            if (pictureBox1.Location.Y == 1080 && pictureBox1.Location.X >= 1180 && pictureBox1.Location.X <= 1300 && inRoom == false)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, 0);
                BackgroundImage = rmdown;
                roomDown = true;
                inRoom = true;
            }

        }
        
        public void Down_Room_Exit()
        {
            if (pictureBox1.Location.Y == 0 && pictureBox1.Location.X >= 1180 && pictureBox1.Location.X <= 1300)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, 1080);
                BackgroundImage = hub;
                roomDown = false;
                inRoom = false;
            }
        }


        public void Left_Room_Entrance()
        {
            if (pictureBox1.Location.X == 0 && pictureBox1.Location.Y >= 490 && pictureBox1.Location.Y <= 595 && inRoom == false)
            {
                pictureBox1.Location = new Point(1920, pictureBox1.Location.Y);
                BackgroundImage = rmleft;
                roomLeft = true;
                inRoom = true;
            }

        }

        public void Left_Room_Exit()
        {
            if (pictureBox1.Location.X == 1920 && pictureBox1.Location.Y >= 490 && pictureBox1.Location.Y <= 595)
            {
                pictureBox1.Location = new Point(0, pictureBox1.Location.Y);
                BackgroundImage = hub;
                roomLeft = false;
                inRoom = false;
            }
        }


        public void Right_Room_Entrance()
        {
            if (pictureBox1.Location.X == 1920 && pictureBox1.Location.Y >= 470 && pictureBox1.Location.Y <= 565 && inRoom == false)
            {
                pictureBox1.Location = new Point(0, pictureBox1.Location.Y);
                BackgroundImage = rmright;
                roomRight = true;
                inRoom = true;
            }

        }

        public void Right_Room_Exit()
        {
            if (pictureBox1.Location.X == 0 && pictureBox1.Location.Y >= 470 && pictureBox1.Location.Y <= 565)
            {
                pictureBox1.Location = new Point(1920, pictureBox1.Location.Y);
                BackgroundImage = hub;
                roomRight = false;
                inRoom = false;
            }
        }

        private static double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        public void Interaction(PictureBox player, PictureBox obj)
        {
            double dist = GetDistance(player.Location.X, player.Location.Y, obj.Location.X, obj.Location.Y);
            if (dist <= 170)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        public void LoadUpRoom()
        {
            pictureBox2.Visible = true;
        }

        public void HideUpRoom()
        {
            pictureBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
