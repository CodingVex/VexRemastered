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

            
            for(int i = 20; i >= 0; i--)
            {
                Point[] MenuPoints = { new Point(f1.getWidth() / 2, 0), new Point(f1.getWidth(), f1.getHeight() / 2), new Point(f1.getWidth() / 2, f1.getHeight()), new Point(0, f1.getHeight() / 2) };
                Point[] vPoints = { new Point((f1.getWidth() / 100) * 30, f1.getHeight() / 3), new Point((f1.getWidth() / 100) * 35, f1.getHeight() / 2), new Point((f1.getWidth() / 100) * 40, f1.getHeight() / 3) };
                Point[] ePoints = { new Point((f1.getWidth() / 100) * 45, f1.getHeight() / 3), new Point((f1.getWidth() / 100) * 55, f1.getHeight() / 3), new Point((f1.getWidth() / 100) * 45, f1.getHeight() / 3), new Point((f1.getWidth() / 100) * 45, f1.getHeight() / 2),
                    new Point((f1.getWidth() / 100) * 55, f1.getHeight() / 2), new Point((f1.getWidth() / 100) * 45, f1.getHeight() / 2), new Point((f1.getWidth() / 100) * 45, (f1.getHeight() / 100) * 45), new Point((f1.getWidth() / 100) * 55, (f1.getHeight() / 100) * 45) };
                Point[] xPoints = { new Point((f1.getWidth() / 100) * 60, f1.getHeight() / 3), new Point((f1.getWidth() / 100) * 65, (f1.getHeight() / 100) * 45), new Point((f1.getWidth() / 100) * 70, f1.getHeight() / 3), new Point((f1.getWidth() / 100) * 60, f1.getHeight() / 2),
                    new Point((f1.getWidth() / 100) * 65, (f1.getHeight() / 100) * 45), new Point((f1.getWidth() / 100) * 70, f1.getHeight() / 2) };

                if (i == 0)
                {
                    
                    g.DrawPolygon(bluePen, MenuPoints);

                    //V blue
                    g.DrawLines(bluePen, vPoints);
                    //E blue
                    g.DrawLines(bluePen, ePoints);
                    //X
                    g.DrawLines(bluePen, xPoints);
                }
                else if (i % 2 == 0)
                {
                    g.DrawPolygon(whitePen, MenuPoints);

                    //V white
                    g.DrawLines(whitePen, vPoints);
                    //E white
                    g.DrawLines(whitePen, ePoints);
                    //X
                    g.DrawLines(whitePen, xPoints);
                    
                }
                else if (i % 2 != 0)
                {
                    g.DrawPolygon(redPen, MenuPoints);

                    //V red
                    g.DrawLines(redPen, vPoints);
                    //E red
                    g.DrawLines(redPen, ePoints);
                    //X
                    g.DrawLines(redPen, xPoints);
                }
                Thread.Sleep(100);
            }

           
            
            
        }

    }
}
