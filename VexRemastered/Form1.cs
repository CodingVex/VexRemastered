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
        private readonly int width = (short)(Screen.PrimaryScreen.Bounds.Width);
        private readonly int height = (short)(Screen.PrimaryScreen.Bounds.Height);

        public Form1()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(width, height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
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

            
        }

        // Getter for Screen width and height
        #region

        public int getWidth()
        {
            return width;
        }

        public int getHeight()
        {
            return height;
        }

        #endregion

        
    }
}
