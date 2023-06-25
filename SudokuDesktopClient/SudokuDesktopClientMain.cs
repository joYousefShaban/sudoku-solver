using System;
using System.Windows.Forms;

namespace SudokuDektopClient
{
    internal static class SudokuDesktopClientMain
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SudokuForm());
        }
    }
}