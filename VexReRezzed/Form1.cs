using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VexReRezzed
{
    public partial class Form1 : Form
    {
        //Gets Screen Width and Height from Console
        private readonly int width = (short)(Screen.PrimaryScreen.Bounds.Width);
        private readonly int height = (short)(Screen.PrimaryScreen.Bounds.Height);

        public Form1()
        {
            Console.WriteLine("Initiate Form1 Constructor");

            //Initializes the Form1 Objects and sets Width and Height.
            #region
            InitializeComponent();
            this.Size = new System.Drawing.Size(width, height);
            #endregion

            Console.WriteLine("Exiting Form1 Constructor");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("Inititate Form1_Paint");

            //Creates GameMenu Instance, Creates Graphics Object, Calls paint method from GameMenu and begins Title card.
            #region
            //Creates GameMenu Instance
            GameMenu gMenu = new GameMenu(e.Graphics);
            //Creates Graphics Object
            Graphics graphics = e.Graphics;

            //Calls Draw method and draws title screen.
            gMenu.Draw(e.Graphics);
            #endregion

            Console.WriteLine("Exiting Form1_Paint");
        }
    }
}
