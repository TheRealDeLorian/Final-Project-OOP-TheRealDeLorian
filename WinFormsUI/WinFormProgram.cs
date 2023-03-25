using FinalProject;
using Microsoft.VisualBasic;

namespace WinFormsUI
{
    public static class WinFormProgram
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
            Application.Run(new LoginScreen());
            LoginScreen login = new LoginScreen();
            login.Show();

            

            
        }
    }
}