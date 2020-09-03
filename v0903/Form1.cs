﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0903
{
    public partial class Form1 : Form
    {
        int vx = rand.Next (-20,20);
        int vy = rand.Next (-20,20);
        int vx2 = rand.Next(-20, 20);
        int vy2 = rand.Next(-20, 20);

        int a = Math.Abs(-10);

        static Random rand = new Random();


        public Form1()
        {
            InitializeComponent();

            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);

            label2.Left = rand.Next(ClientSize.Width - label2.Width);
            label2.Top = rand.Next(ClientSize.Height - label2.Height);


        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;
            label2.Left += vx2;
            label2.Top += vy2;
            Point mp = MousePosition;
            mp = PointToClient(mp);


            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy) ;
            }
            if (label1.Right >= ClientSize.Width)
            {
                vx = -Math.Abs(vx) ;
            }
            if (label1.Bottom >= ClientSize.Height)
            {
                vy = -Math.Abs(vy) ;
            }
            if ((mp.X >= label1.Left) && (mp.X < label1.Right) && (mp.Y >= label1.Top) && (mp.Y < label1.Bottom))
            {
                timer1.Enabled = false;
            }
            if (label2.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            if (label2.Top < 0)
            {
                vy = Math.Abs(vy);
            }
            if (label2.Right >= ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
            if (label2.Bottom >= ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }
            if ((mp.X >= label1.Left) && (mp.X < label1.Right) && (mp.Y >= label1.Top) && (mp.Y < label1.Bottom))
            {
                timer1.Enabled = false;
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
