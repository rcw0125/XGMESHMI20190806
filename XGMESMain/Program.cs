using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices; 

namespace XGMESMain
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        //[DllImport("AutoUPDT.DLL")]
        //public static extern bool DoUpdate();
        [STAThread]

        static void Main()
        {
           // DoUpdate();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);           
            SingleApplication.Run(new frmMain());
           
           
        }
    }
}