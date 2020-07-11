using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VexReRezzed
{
    class Star
    {
        public Graphics graphics;
        Form1 f1 = new Form1();
        int x, y;

        public Star(Graphics g, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.graphics = g;
        }

        public void Draw(Pen pen, Point[] points)
        {
            graphics.DrawLines(pen, points);
        }

        public void Spawn(int spawnAmount ,Pen pen, Point[] points)
        {
            for(int i = spawnAmount; spawnAmount > 0; spawnAmount--)
            {
                var rand = new Random();
                new Star(graphics, x, y);

                setX(rand.Next(f1.Width / 10, f1.Width - f1.Width / 10));
                setY(rand.Next(f1.Height / 10, f1.Height - f1.Height / 10));

                Draw(pen, points);
                
            }
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
