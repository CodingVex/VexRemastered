using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VexRemastered
{
    class GameMenu
    {
        static Point[] emptyPointArray;
        static Pen emptyPen;
        static Graphics graphics;
        static int x, y;
        public VectorLetters vectorL = new VectorLetters(graphics, emptyPen, x, y, emptyPointArray);

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
                //Contains all verticies of the shapes and letters drawn on menu screen during animation.
                #region
                Point[] MenuPoints = { new Point(f1.getWidth() / 2, 0), new Point(f1.getWidth(), f1.getHeight() / 2), new Point(f1.getWidth() / 2, f1.getHeight()), new Point(0, f1.getHeight() / 2) };

                Point[] vPoints = { new Point((f1.getWidth() / 100) * 35, (f1.getHeight() / 100) * 45), new Point((f1.getWidth() / 100) * 33, f1.getHeight() / 3), new Point((f1.getWidth() / 100) * 30, f1.getHeight() / 3),
                    new Point((f1.getWidth() / 100) * 35, f1.getHeight() / 2), new Point((f1.getWidth() / 100) * 40, f1.getHeight() / 3),
                    new Point((f1.getWidth() / 100) * 37, f1.getHeight() / 3) };

                Point[] ePoints = { new Point((f1.getWidth() /  100) * 55, (f1.getHeight() / 100) *  41), new Point((f1.getWidth() / 100) * 55, f1.getHeight() / 3), new Point((f1.getWidth() / 100) * 45, f1.getHeight() / 3),
                    new Point((f1.getWidth() / 100) * 45, f1.getHeight() / 3), new Point((f1.getWidth() / 100) * 45, f1.getHeight() / 2), new Point((f1.getWidth() / 100) * 55, f1.getHeight() / 2),
                    new Point((f1.getWidth() / 100) * 55, (f1.getHeight() / 100) * 49), new Point((f1.getWidth() / 100) * 48, (f1.getHeight() / 100) * 49), new Point((f1.getWidth() / 100) * 48, (f1.getHeight() / 100) * 47) };

                Point[] ePointsMid = { new Point((f1.getWidth() / 100) * 55, (f1.getHeight() / 100) * 46),  new Point((f1.getWidth() / 100) * 55, (f1.getHeight() / 100) * 44), new Point((f1.getWidth() / 100) * 48, (f1.getHeight() / 100) * 44),
                    new Point((f1.getWidth() / 100) * 48, (f1.getHeight() / 100) * 42) };

                Point[] xPointsLeft = { new Point((f1.getWidth() / 100) * 63, (f1.getHeight() / 2)), new Point((f1.getWidth() / 100) * 60, (f1.getHeight() / 2)), new Point((f1.getWidth() / 100) * 63, (f1.getHeight() / 100) * 45),
                    new Point((f1.getWidth() / 100) * 60, f1.getHeight() / 3), new Point((f1.getWidth() / 100) * 63, (f1.getHeight() / 3)) };

                Point[] xPointsRight = { new Point((f1.getWidth() / 100) * 67, (f1.getHeight() / 3)), new Point((f1.getWidth() / 100) * 70, (f1.getHeight() / 3)),  new Point((f1.getWidth() / 100) * 67, (f1.getHeight() / 100) * 45), 
                    new Point((f1.getWidth() / 100) * 70, (f1.getHeight() / 2)), new Point((f1.getWidth() / 100) * 67, (f1.getHeight() / 2)) };

                #endregion

                Point[] test = { new Point(vectorL.getX(), vectorL.getY()), new Point(vectorL.getX()+200, vectorL.getY()+200) };
                vectorL = new VectorLetters(g, whitePen, f1.getWidth()/2, f1.getHeight()/2, test);
                vectorL.Draw(whitePen, test);


                //Animated the shapes and letters to flash colors depending on the modulus of the previous for loop.
                #region
                if (i == 0)
                { 
                    g.DrawPolygon(bluePen, MenuPoints);

                    //V blue
                    g.DrawLines(bluePen, vPoints);
                    //E blue
                    g.DrawLines(bluePen, ePoints);
                    g.DrawLines(bluePen, ePointsMid);
                    //X
                    g.DrawLines(bluePen, xPointsLeft);
                    g.DrawLines(bluePen, xPointsRight);
                }
                else if (i % 2 == 0)
                {
                    g.DrawPolygon(whitePen, MenuPoints);

                    //V white
                    g.DrawLines(whitePen, vPoints);
                    //E white
                    g.DrawLines(whitePen, ePoints);
                    g.DrawLines(whitePen, ePointsMid);
                    //X
                    g.DrawLines(whitePen, xPointsLeft);
                    g.DrawLines(whitePen, xPointsRight);
                }
                else if (i % 2 != 0)
                {
                    g.DrawPolygon(redPen, MenuPoints);

                    //V red
                    g.DrawLines(redPen, vPoints);
                    //E red
                    g.DrawLines(redPen, ePoints);
                    g.DrawLines(redPen, ePointsMid);
                    //X
                    g.DrawLines(redPen, xPointsLeft);
                    g.DrawLines(redPen, xPointsRight);
                }
                Thread.Sleep(100);
                #endregion
            }

        }

    }
}
