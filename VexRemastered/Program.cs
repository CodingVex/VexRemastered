﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VexRemastered
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Boolean running = true;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            while(running)
            {
                Application.Run(new Form1());
                running = false;
            }
            

        }
    }
}
