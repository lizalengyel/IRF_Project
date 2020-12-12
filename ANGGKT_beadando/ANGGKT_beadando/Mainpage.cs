using System;
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
        public Mainpage()
        {
            InitializeComponent();
 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
           // Graphics g = e.Graphics;
            Graphics g = panel1.CreateGraphics();

            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rec = new Rectangle(10, 10, 150, 150);
            Rectangle rec1 = new Rectangle(150, 150, 100, 100);

            Pen pirosP = new Pen(Color.Red, 4);
            Pen feketeP = Pens.Black;

            SolidBrush zoldB = new SolidBrush(Color.Green);

            g.DrawRectangle(pirosP, rec);
            g.DrawRectangle(feketeP, rec1);
        }

    }



}
