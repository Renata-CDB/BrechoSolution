using BrechoDomain.Entitys;
using BrechoDomainCore.Interfaces.Repository;
using BrechoDomainCore.Interfaces.Services;

namespace BrechoDomain.Service
{
    public class ReceitaService : BaseService<Receita>, IReceitaService
    {
        private readonly IReceitaRepository _receitaRepository;

        public ReceitaService(IReceitaRepository receitaRepository)
            : base(receitaRepository)
        {
            _receitaRepository = receitaRepository;
        }
    }
}


