using QLNhanVien.View;

namespace QLNhanVien
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        //Scaffold-DbContext 'Data Source=PHAMHIEU\SQLEXPRESS;Initial Catalog=QLNVien;Integrated Security=True; TrustServerCertificate=true' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context DBContext -Contextdir Context -DataAnnotations -Force
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}