using Autofac;
using BrechoDomain.Service;
using BrechoDomainCore.Interfaces.Repository;
using BrechoDomainCore.Interfaces.Services;
using BrechoModelo.Infrastructure.Data.Repositorys;
using BrechoModeloAplication;
using BrechoModeloAplication.Interfaces;
using BrechoModeloAplication.Interfaces.Mapper;
using BrechoModeloAplication.Mapper;

namespace BrechoModelo.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC
            builder.RegisterType<ClienteAplicationService>().As<IClienteAplicationService>();
            builder.RegisterType<ProdutoAplicationService>().As<IProdutoAplicationService>();
            builder.RegisterType<ClienteService>().As<IClienteService>();
            builder.RegisterType<ProdutoService>().As<IProdutoService>();
            builder.RegisterType<ClienteRepository>().As<IClienteRepository>();
            builder.RegisterType<ProdutoRepository>().As<IProdutoRepository>();
            builder.RegisterType<ClienteMapper>().As<IClienteMapper>();
            builder.RegisterType<ProdutoMapper>().As<IProdutoMapper>();
            #endregion
        }
    }
}



//Re-throwing caught exception changes stack information
//The variable ex is declared but never used 