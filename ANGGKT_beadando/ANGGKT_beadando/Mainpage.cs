﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ANGGKT_beadando
{
    public partial class Mainpage : Form
    {

        CicaEntities1 context = new CicaEntities1();
        public static int cicaid;


        public Mainpage()
        {
            InitializeComponent();
 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
           // Graphics g = e.Graphics;
            Graphics g = panel1.CreateGraphics();

            g.SmoothingMode = SmoothingMode.AntiAlias;

            Pen feketeP = new Pen( Color.Black, 4);

            SolidBrush zoldB = new SolidBrush(Color.Green);

            g.DrawLine(feketeP, 0, 85, this.Width, 85);
            g.FillEllipse(Brushes.DarkCyan, 165, 40, 30, 30);
            g.FillEllipse(Brushes.LightCyan, 195, 30, 40, 40);
            g.FillEllipse(Brushes.LightGray, 235, 20, 50, 50);
            g.FillEllipse(Brushes.LightCyan, 285, 30, 40, 40);
            g.FillEllipse(Brushes.DarkCyan, 325, 40, 30, 30);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 userControl3 = new UserControl3();
            panel1.Controls.Add(userControl3);
            userControl3.Dock = DockStyle.Fill;
            cicaid = 112;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 userControl3 = new UserControl3();
            panel1.Controls.Add(userControl3);
            userControl3.Dock = DockStyle.Fill;
            cicaid = 113;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 userControl3 = new UserControl3();
            panel1.Controls.Add(userControl3);
            userControl3.Dock = DockStyle.Fill;
            cicaid = 114;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 userControl3 = new UserControl3();
            panel1.Controls.Add(userControl3);
            userControl3.Dock = DockStyle.Fill;
            cicaid = 116;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 userControl3 = new UserControl3();
            panel1.Controls.Add(userControl3);
            userControl3.Dock = DockStyle.Fill;
            cicaid = 117;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 userControl3 = new UserControl3();
            panel1.Controls.Add(userControl3);
            userControl3.Dock = DockStyle.Fill;
            cicaid = 118;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 userControl3 = new UserControl3();
            panel1.Controls.Add(userControl3);
            userControl3.Dock = DockStyle.Fill;
            cicaid = 119;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 userControl3 = new UserControl3();
            panel1.Controls.Add(userControl3);
            userControl3.Dock = DockStyle.Fill;
            cicaid = 120;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 userControl3 = new UserControl3();
            panel1.Controls.Add(userControl3);
            userControl3.Dock = DockStyle.Fill;
            cicaid = 121;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 userControl3 = new UserControl3();
            panel1.Controls.Add(userControl3);
            userControl3.Dock = DockStyle.Fill;
            cicaid = 122;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 userControl3 = new UserControl3();
            panel1.Controls.Add(userControl3);
            userControl3.Dock = DockStyle.Fill;
            cicaid = 123;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 userControl3 = new UserControl3();
            panel1.Controls.Add(userControl3);
            userControl3.Dock = DockStyle.Fill;
            cicaid = 124;
        }
    }



}
