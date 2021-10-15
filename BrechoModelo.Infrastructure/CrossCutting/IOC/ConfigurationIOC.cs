using BrechoDomain.Service;
using BrechoDomainCore.Interfaces.Repository;
using BrechoDomainCore.Interfaces.Services;
using BrechoModelo.Infrastructure.Data;
using BrechoModelo.Infrastructure.Data.Repositorys;
using BrechoModeloAplication;
using BrechoModeloAplication.Interfaces;
using BrechoModeloAplication.Interfaces.Mapper;
using BrechoModeloAplication.Mapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BrechoModelo.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        //public class SqlContext : DbContext
        public static void RegisterServices(IServiceCollection services, string connectionString, IConfiguration configuration)
        {
            services.AddDbContext<SqlContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            #region IOC
            services.AddScoped<IClienteAplicationService, ClienteAplicationService>();
            services.AddScoped<IProdutoAplicationService, ProdutoAplicationService>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IClienteMapper, ClienteMapper>();
            services.AddScoped<IProdutoMapper, ProdutoMapper>();
            #endregion
        }
    }
}



//Re-throwing caught exception changes stack information
//The variable ex is declared but never used 