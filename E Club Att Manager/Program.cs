﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace E_Club_Att_Manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DemoManagerFrm());
        }
        public static MCls MC = new MCls();
    }
}