using ControleEstoqueApp.Aplicacao.Servicos;
using ControleEstoqueApp.Dominio.Servicos;
using ControleEstoqueApp.Infraestrutura.Database;
using ControleEstoqueApp.Infraestrutura.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ControleEstoqueApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite("Data Source=estoque.db"));

            services.AddScoped<IProdutoDominioServico, ProdutoDominioServico>();

            services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
            services.AddScoped<IProdutoAppServico, ProdutoAppServico>();

            var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(new FrmControleEstoque(serviceProvider));
        }
    }
}
