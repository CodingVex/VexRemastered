using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VexRemastered
{
    class VectorLetters
    {
        static Form1 f1 = new Form1();


        Graphics g;
        Pen pen;
        int xLoc = f1.getWidth()/2;
        int yLoc = f1.getHeight()/2;
        Point[] points;
        

        public VectorLetters(Graphics g, Pen pen, int xLoc, int yLoc, Point[] points)
        {
            this.g = g;
            this.pen = pen;
            this.xLoc = xLoc;
            this.yLoc = yLoc;
            this.points = points;
        }

        public void Draw(Pen pen, Point[] points)
        {
            g.DrawLines(pen,points);
        }

        public void setX(int x)
        {xLoc = x;}

        public void setY(int y)
        {yLoc = y;}

        public int getX()
        {return xLoc;}

        public int getY()
        {return yLoc;}

    }
}
