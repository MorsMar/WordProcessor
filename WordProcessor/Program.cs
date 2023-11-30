using Microsoft.Extensions.DependencyInjection;
using WordProcessor.InfrastructureLayer;
using static System.Windows.Forms.DataFormats;
namespace WordProcessor
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            DictionaryCollection.ConfigureService(services);
            services.AddScoped<FormWordProcessor>();
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<FormWordProcessor>();
                Application.Run(form1);
            }
            //// To customize application configuration such as set high DPI settings or default font,
            //// see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new FormWordProcessor());
        }
    }
}