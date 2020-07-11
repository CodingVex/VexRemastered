using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VexReRezzed
{
    class Letters
    {
        public Graphics graphics;
        int x, y;

        public Letters(Graphics g, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.graphics = g;
        }

        public void Draw( Pen pen, Point[] points)
        {
            graphics.DrawLines(pen, points);
        }

        //Getters
        #region
        public int getX()
        { return x; }

        public int getY()
        { return y; }
        #endregion

        //Setter
        #region
        public void setX(int xNew)
        { x = xNew; }

        public void setY(int yNew)
        { y = yNew; }
        #endregion
    }
}
