using BrechoDomain.Entitys;
using BrechoDomainCore.Interfaces.Repository;

namespace BrechoModelo.Infrastructure.Data.Repositorys
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        private readonly SqlContext _sqlContext;

        public ProdutoRepository(SqlContext sqlContext)
            : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
