using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polygon_Creator
{
    public partial class Form1 : Form
    {
        Graphics g;
        int click_count = 1;

        List<Line> lines;
        List<Point> points;
        Pen pen;

        private void resetButton_Click(object sender, EventArgs e)
        {
            g.Clear(Form1.DefaultBackColor);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(click_count != 1)
            {
                Point p = new Point(e.X, e.Y);
                Line l = new Line(points[click_count-2], p);
                g.Clear(Form1.DefaultBackColor);
                l.Draw(g, pen);
                DrawLines();
            }
        }

        private void DrawLines()
        {
            foreach(Line l in lines)
            {
                l.Draw(g, pen);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            pen = new Pen(Color.FromArgb(0,0,0));
            lines = new List<Line>();
            points = new List<Point>();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            points.Add(p);
            if (click_count % 2 == 0)
            {
                Line l = new Line(points[click_count-1], points[click_count-2]);
                lines.Add(l);
                l.Draw(g, pen);
            }
            click_count++;
        }
    
    }

    public class Line
    {
        public Point p1, p2;
        public Line(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public void Draw(Graphics g, Pen pen)
        {
            g.DrawLine(pen, this.p1.X, this.p1.Y, this.p2.X, this.p2.Y);
        }
    }
}
