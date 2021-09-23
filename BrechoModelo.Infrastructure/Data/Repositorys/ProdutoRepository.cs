using BrechoDomain.Entitys;
using BrechoDomainCore.Interfaces.Repository;

namespace BrechoModelo.Infrastructure.Data.Repositorys
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        private readonly SqlContext sqlContext;

        public ProdutoRepository(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
