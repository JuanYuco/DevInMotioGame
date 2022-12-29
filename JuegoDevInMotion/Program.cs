using Microsoft.Extensions.DependencyInjection;
using BL.Models;
using BL.Models.Interfaces;
using BL.Services;

namespace JuegoDevInMotion
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

            var services = new ServiceCollection();
            ConfigureServices(services);
            using (var serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetService<Form1>();
                Application.Run(form1);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IPesonaje, Personaje>()
                .AddScoped<Form1>()
                .AddScoped<IArmasService, ArmaService>()
                .AddScoped<IContexturaService, ContexturaService>()
                .AddScoped<IAccionAtaque, Ataque>()
                .AddScoped<IAccionCorrer, Correr>()
                .AddScoped<IAccionSalto, Salto>()
                .AddScoped<IControladorEstamina, ControladorEstamina>();
        }
    }
}