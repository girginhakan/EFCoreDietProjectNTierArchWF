using DietProject.BLL.Manager.Concrete;
using DietProject.BLL.Models;

namespace DietProject.UI
{
    internal static class Program
    {
        public static KullaniciModel KullaniciModel { get; set; }
        public static TuketilenOgunlerViewModel SecilenYemek {  get; set; }
        public static KullaniciOgunYemekPorsiyonModel kullaniciOgunYemekPorsiyonModel { get; set; }
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