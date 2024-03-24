using DietProject.BLL.Manager.Concrete;
using DietProject.BLL.Models;

namespace DietProject.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frm_AnaGirisEkrani());

           
            
        }
    }
}