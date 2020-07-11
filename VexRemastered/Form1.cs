using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VexRemastered
{
    public partial class Form1 : Form
    {
        //Gets Screen Width and Height from Console
        private readonly int width = (short)(Screen.PrimaryScreen.Bounds.Width);
        private readonly int height = (short)(Screen.PrimaryScreen.Bounds.Height);

        public Form1()
        {
            Console.WriteLine("Initiate Form1 Constructor");
            InitializeComponent();
            this.Size = new System.Drawing.Size(width, height);
            Console.WriteLine("Exiting Form1 Constructor");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Initiate Form1_Load");
            Console.WriteLine("Exiting Form1_Load");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("Inititate Form1_Paint");

            //Creates instance of Form1
            Form1 f1 = new Form1();
            //Creates instance of Graphics object
            Graphics graphics = e.Graphics;
            //Creates instance of GameMenu object
            GameMenu gMenu = new GameMenu();

            //List of Pen objects
            #region
            Pen whitePen = new Pen(Color.White);
            Pen redPen = new Pen(Color.Red);
            Pen bluePen = new Pen(Color.Blue);
            Pen yellowPen = new Pen(Color.Yellow);
            #endregion

            //Calls GameMenu.Paint to draw Menu Screen
            gMenu.Paint(e.Graphics);

            Console.WriteLine("Exiting Form1_Paint");

        }

        // Getter for Screen width and height
        #region

        public int getWidth()
        {
            Console.WriteLine("Calling getWidth() from Form1");
            return width;
        }

        public int getHeight()
        {
            Console.WriteLine("Calling getHeight() from Form1.");
            return height;
        }

        #endregion

        
    }
}
