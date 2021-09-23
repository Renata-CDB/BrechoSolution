using BrechoDomain.Entitys;
using BrechoDomainCore.Interfaces.Repository;
using BrechoDomainCore.Interfaces.Services;

namespace BrechoDomain.Service
{
    public class ProdutoService : BaseService<Produto>, IProdutoService
    {
        private readonly IProdutoRepository produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
            : base(produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }
    }
}
