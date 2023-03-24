using FinalProject;
using Microsoft.VisualBasic;

namespace WinFormsUI
{
    public static class Program
    {
        static Student newStudent;
        static int ID;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            Form1 f1 = new Form1();
            f1.Show();

            

            
        }
    }
}