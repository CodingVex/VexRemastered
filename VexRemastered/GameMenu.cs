using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VexRemastered
{
    class GameMenu
    {
        private Form1 f1 = new Form1();

        public void Paint(Graphics g)
        {

            AnimateMenu(g);
            
        }

        void AnimateMenu(Graphics g)
        {

            Form1 f1 = new Form1();

            //List of Pen objects
            #region
            Pen whitePen = new Pen(Color.White);
            Pen redPen = new Pen(Color.Red);
            Pen bluePen = new Pen(Color.Blue);
            Pen yellowPen = new Pen(Color.Yellow);
            #endregion

            //Outer Polygon
            for(int i = 20; i >= 0; i--)
            {
                Point[] MenuPoints = { new Point(f1.getWidth() / 2, 0), new Point(f1.getWidth(), f1.getHeight() / 2), new Point(f1.getWidth() / 2, f1.getHeight()), new Point(0, f1.getHeight() / 2) };
                if(i == 0)
                    g.DrawPolygon(bluePen, MenuPoints);
                else if(i % 2 == 0)
                    g.DrawPolygon(whitePen, MenuPoints);
                    else if(i % 2 != 0)
                        g.DrawPolygon(redPen, MenuPoints);
                Thread.Sleep(100);
            }
            
            //Vex
            
            
        }

    }
}
