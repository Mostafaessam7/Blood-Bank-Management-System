using BBMS.DBContext;

namespace BBMS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SampleData sample = new SampleData();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Splash());
            //Application.Run(new Login());
           // Application.Run(new DashBoard());
        }
    }
}