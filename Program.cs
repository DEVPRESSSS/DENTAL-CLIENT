using Dental.Areas.Admin;

namespace Dental
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
         
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
            //Application.Run(new AdminLayout());
        }
    }
}