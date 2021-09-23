using BrechoDomain.Entitys;
using BrechoDomainCore.Interfaces.Repository;

namespace BrechoModelo.Infrastructure.Data.Repositorys
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        private readonly SqlContext sqlContext;

        public ClienteRepository(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
