using BrechoDomain.Entitys;
using BrechoDomainCore.Interfaces.Repository;
using BrechoDomainCore.Interfaces.Services;

namespace BrechoDomain.Service
{
    public class ClienteService : BaseService<Cliente>, IClienteService
    {
        private readonly IClienteRepository clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
            : base(clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }
    }
}
