using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VexReRezzed
{
    class GameMenu
    {
        Form1 f1 = new Form1();
        Letters letters;
        Star star;

        //Pens
        #region

        readonly Pen whitePen = new Pen(Color.White);
        readonly Pen redPen = new Pen(Color.Red);
        readonly Pen greenPen = new Pen(Color.Green);
        readonly Pen bluePen = new Pen(Color.Blue);
        readonly Pen yellowPen = new Pen(Color.Yellow);
        readonly Pen orangePen = new Pen(Color.Orange);

        #endregion

        //Constuctor
        #region
        public GameMenu(Graphics graphics)
        {}
        #endregion

        //Draw Method executes AnimateMenu to Screen
        public void Draw(Graphics g)
        {
            AnimateMenu(g);
            DrawStar(g, whitePen, 50);
        }

        //AnimateMenu Method draws title to animate
        private void AnimateMenu(Graphics g)
        {
            for(int i = 20; i >= 0; i--)
            {
                if (i == 0)
                    DrawTitle(g, whitePen);
                else if (i % 2 == 0)
                    DrawTitle(g, bluePen);
                else if (i % 2 != 0)
                    DrawTitle(g, redPen);
                else
                    Console.WriteLine("AnimateMenu iterator failed operation");

                Thread.Sleep(100);
            }
            
        }

        //DrawTitle Method stores all information on drawing the Title screen.
        private void DrawTitle(Graphics g, Pen pen)
        {

            int midWidth = f1.Width / 2;
            int midHeight = f1.Height / 2;

            //Draws V
            #region
            letters = new Letters( g, midWidth/2, midHeight-100);

            Point[] pointsV = { new Point( letters.getX()+3, letters.getY()+97), new Point(letters.getX(), letters.getY() + 100), new Point(letters.getX()-50, letters.getY()+25), new Point(letters.getX()-125, letters.getY()),
                new Point(letters.getX(), letters.getY()+200), new Point( letters.getX()+125, letters.getY()), new Point( letters.getX()+50, letters.getY()+25) };

            letters.Draw(pen, pointsV);
            #endregion

            //Draws E (main body)
            #region
            letters = new Letters(g, midWidth, midHeight);

            Point[] pointsE = { new Point( letters.getX()+125, letters.getY()-50) , new Point( letters.getX()+125, letters.getY()-100), new Point( letters.getX()-125, letters.getY()-100), new Point( letters.getX()-125, letters.getY()+100),
                new Point( letters.getX()+125, letters.getY()+100), new Point( letters.getX()+125, letters.getY()+50), new Point( letters.getX()-50, letters.getY()+50), new Point( letters.getX()-50, letters.getY()+30) };

            letters.Draw(pen, pointsE);
            #endregion

            //Draws E (mid append)
            #region
            letters = new Letters(g, midWidth, midHeight-25);

            Point[] pointsEMid = { new Point( letters.getX()-50, letters.getY()-25) , new Point( letters.getX()-50, letters.getY()) , new Point( letters.getX()+125, letters.getY()), new Point( letters.getX()+125, letters.getY()+50) };

            letters.Draw(pen, pointsEMid);
            #endregion

            //Draws X (left)
            #region
            letters = new Letters(g, midWidth+(midWidth/2), midHeight);

            Point[] pointsXLeft = { new Point( letters.getX()-25, letters.getY()-100), new Point(letters.getX()-125, letters.getY()-100), new Point(letters.getX()-50, letters.getY()), new Point( letters.getX()-125, letters.getY()+100), 
                new Point( letters.getX()-25, letters.getY()+100) };

            letters.Draw(pen, pointsXLeft);
            #endregion

            //Draws X (right)
            #region
            letters = new Letters(g, midWidth + (midWidth / 2), midHeight);

            Point[] pointsXRight = { new Point( letters.getX()+25, letters.getY()-100), new Point(letters.getX()+125, letters.getY()-100), new Point(letters.getX()+50, letters.getY()), new Point( letters.getX()+125, letters.getY()+100),
                new Point( letters.getX()+25, letters.getY()+100) };

            letters.Draw(pen, pointsXRight);
            #endregion

        }

        //DrawStar Method draws stars onto the Title Screen
        private void DrawStar(Graphics g, Pen pen, int starAmount)
        {
            star = new Star(g, 0, 0);

            Point[] starPoints = { new Point(star.getX(), star.getY()), new Point(star.getX()+50, star.getY()-50) };

            star.Spawn(starAmount ,pen, starPoints);
        }

    }
}
