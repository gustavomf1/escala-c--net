using EscalasAgent.Infraestrutura.Context;
using EscalasAgent.Infraestrutura.Repository;
using EscalasAgent.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace EscalasAgent
{
    internal static class Program
    {
        public static ServiceProvider serviceProvider;


        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService<FrmPrincipal>();
                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<DbContextEscolaAgent>();

            services.AddScoped<FrmPrincipal>();
            services.AddScoped<FrmConsultaPessoa>();
            services.AddScoped<FrmCadPessoa>();
            services.AddScoped<FrmCadEquipe>();
            services.AddScoped<FrmConsultaEquipe>();
            services.AddScoped<FrmCadEscala>();
            services.AddScoped<FrmConsultaEscala>();
            services.AddScoped<FrmLogin>();
            services.AddScoped<Form1>();

            services.AddSingleton<IEquipeRepositorio, EquipeRepositorio>();
            services.AddSingleton<IEscalaRepositorio, EscalaRepositorio>();
            services.AddSingleton<IPessoaRepositorio, PessoaRepositorio>();
        }
    }
}