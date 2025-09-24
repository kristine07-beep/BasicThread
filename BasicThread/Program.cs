using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BasicThread
{
    internal static class Program
    {
        [DllImport("kernel32.dll")] private static extern bool AllocConsole();
        [DllImport("kernel32.dll")] private static extern IntPtr GetConsoleWindow();

        [STAThread]
        static void Main()
        {
   
            if (GetConsoleWindow() == IntPtr.Zero)
                AllocConsole();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
