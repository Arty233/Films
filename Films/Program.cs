﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Films
{
    static class Program
    {
        /// <summary> 
        /// The main entry point for the application.
        /// </summary>
        // С 15:00 во вторник
        // С 15:00 214 в среду
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
