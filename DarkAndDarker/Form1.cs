using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DarkAndDarker
{
    public partial class Form1 : Form
    {

        bool debugging = true;

        //Hero variables
        Rectangle hero = new Rectangle(200, 250, 30, 30);
        int heroSpeed = 10;

        //rooms
        int room = 1;

        Rectangle room1top = new Rectangle(50, 50, 500, 30);
        Rectangle room1bottom = new Rectangle(50, 530, 500, 30);
        Rectangle room1left = new Rectangle(50, 50, 30, 500);
        Rectangle room1right = new Rectangle(520, 50, 30, 500);

        Rectangle room2Hleft = new Rectangle(80, 245, 160, 30);


        //knife
        string knife = "up";

        //Rectangle knife = new Rectangle(210, 250, 30, 30);

        //enemys 


        int room2;


        //int score = 0;
        int time = 1000;
        int heroScore = 0;


        bool leftDown = false;
        bool rightDown = false;
        bool upDown = false;
        bool downDown = false;
        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;

        SolidBrush whiteBrush = new SolidBrush(Color.White);

        Random randGen = new Random();
        int randValue = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //draw hero
            e.Graphics.FillRectangle(whiteBrush, hero);
            e.Graphics.FillRectangle(whiteBrush, room1top);
            e.Graphics.FillRectangle(whiteBrush, room1bottom);
            e.Graphics.FillRectangle(whiteBrush, room1left);
            e.Graphics.FillRectangle(whiteBrush, room1right);

            if (room == 2)
            {
                e.Graphics.FillRectangle(whiteBrush, room2Hleft);
            }

            if (debugging == true)
            {
                cordLabel.Visible = true;
                cordLabel.Text = $"X: {hero.X}\nY:{hero.Y}";
            }
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;

                case Keys.Up:
                    upDown = false;
                    break;
                case Keys.Down:
                    downDown = false;
                    break;
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;

                case Keys.Up:
                    upDown = true;
                    break;
                case Keys.Down:
                    downDown = true;
                    break;
                case Keys.Left:
                    leftDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;

            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            if (knife == "up")
            {
                Rectangle knifeUp = new Rectangle(hero.X, hero.Y, 5, 25);
                g.FillRectangle(whiteBrush, knifeUp);
            }
            /*
            else if (knife == "down")
            {
                Rectangle knifeDown = new Rectangle(hero.X + hero.Width, hero.Y - (hero.Height / 2), 7, 5);
                g.FillRectangle(whiteBrush, knifeDown);
            }
            else if (knife == "left")
            {
                Rectangle knifeLeft = new Rectangle(hero.X + hero.Width, hero.Y + (hero.Height / 2), 7, 5);
                g.FillRectangle(whiteBrush, knifeLeft);
            }
            else if (knife == "right")
            {
                Rectangle knifeRight = new Rectangle(hero.X + hero.Width, hero.Y + (hero.Height / 2), 7, 5);
                g.FillRectangle(whiteBrush, knifeRight);
            } 
           */
            //room = 2;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        { 
            switch (room)
            {
                case 1:
                    //walls
                    if (hero.X < 80)
                    {
                        hero.X += heroSpeed;
                    }
                    if (hero.X > 490)
                    {
                        hero.X -= heroSpeed;
                    }
                    if (hero.Y < 80)
                    {
                        hero.Y += heroSpeed;
                    }
                    if (hero.Y > 500)
                    {
                        hero.Y -= heroSpeed;
                    }
                    break;

                case 2:
                    //main walls           
                    if (hero.X < 80)
                    {
                        hero.X += heroSpeed;
                    }
                    if (hero.X > 490)
                    {
                        hero.X -= heroSpeed;
                    }
                    if (hero.Y < 80)
                    {
                        hero.Y += heroSpeed;
                    }
                    if (hero.Y > 500)
                    {
                        hero.Y -= heroSpeed;
                    }
                    //secondary walls
                    if (hero.Y < 270 && hero.X < 239 && hero.Y > 240)
                    {
                        hero.Y = 270;
                    }
                    if (hero.Y <= 230 && hero.X < 235 && hero.Y > 220)
                    {
                        hero.Y = 215;
                    }
                    break;
            }


            if (upDown == true && hero.Y > 0)
            {
                hero.Y -= heroSpeed;
            }
            if (downDown == true && hero.Y > 0)
            {
                hero.Y += heroSpeed;
            }

            if (wDown == true && hero.Y > 0)
            {
                hero.Y -= heroSpeed;
            }
            if (sDown == true && hero.Y > 0)
            {
                hero.Y += heroSpeed;
            }

            if (aDown == true && hero.X > 0)
            {
                hero.X -= heroSpeed;
            }
            if (dDown == true && hero.X > 0)
            {
                hero.X += heroSpeed;
            }
            if (leftDown == true && hero.X > 0)
            {
                hero.X -= heroSpeed;
            }
            if (rightDown == true && hero.X > 0)
            {
                hero.X += heroSpeed;
            }
        
    
            //redraw the screen
            Refresh();
        }

        private void startButton_click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            startButton.Visible = false;
            titleLabel.Text = "";
            BackColor = Color.Black;
            
        }
    }
}



