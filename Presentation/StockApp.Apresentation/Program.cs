using StockApp.Business.Interfaces.Banco;
using StockApp.WindowsForms._inicializar;
using StockApp.WindowsForms.Cadastros;

namespace StockApp.Apresentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        ///
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            try
            {
                var banco = new InicializarDataBase();
                banco.Init();
            }
            catch (Exception ex )
            {

                throw;
            }        
            Application.Run(new frmCategoria());
        }
    }
}