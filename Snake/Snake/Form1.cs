using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LunchTimer();
        }
        public void LunchTimer()
        {
            timer.Interval = 500;
            timer.Start();
        }
        //Fields
        public int dx ;
        public int dy ;
        public int xc ;
        public int yc ; 
        Timer timer = new Timer();
        bool[,] visit = new bool[40, 25];


        //Methods
        public void move()
        {
            yc = btnsnake.Location.Y / 5;
            xc = btnsnake.Location.X / 5;
            if (dy == -1)
            {
                yc -= 1;
                btnsnake.Location = new Point(xc * 5, yc * 5);
                label1.Text = yc.ToString();
            }
            else if (dy == 1)
            {
                yc += 1;
                btnsnake.Location = new Point(xc * 5, yc * 5);
                label1.Text = yc.ToString();
            }
            else if (dx == 1)
            {
                xc += 1;
                btnsnake.Location = new Point(xc * 5, yc * 5);
                label2.Text = xc.ToString();
            }
            else if (dx == -1)
            {
                xc -= 1;
                btnsnake.Location = new Point(xc * 5, yc * 5);
                label2.Text = xc.ToString();
            }
            yc = 0;
            xc = 0;
        }
        //Events
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            dy = dx = 0;
            timer.Stop();
            switch (e.KeyCode)
            {
                case Keys.Up:
                    dy = -1;
                    break;
                case Keys.Down:
                    dy = 1;
                    break;
                case Keys.Right:
                    dx = 1;
                    break;
                case Keys.Left:
                    dx = -1;
                    break; 
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            move();
        }
    }
}
