using BrechoDomain.Entitys;
using BrechoDomainCore.Interfaces.Repository;
using BrechoDomainCore.Interfaces.Services;

namespace BrechoDomain.Service
{
    public class ClienteService : BaseService<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
    }
}
