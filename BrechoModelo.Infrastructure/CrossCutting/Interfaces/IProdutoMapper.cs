using BrechoDomain.Entitys;
using BrechoModeloAplication.Dtos;
using System.Collections.Generic;

namespace BrechoModelo.Infrastructure.CrossCutting.Interfaces
{
    public interface IProdutoMapper
    {
        Produto MapperToEntity(ProdutoDTO produtoDTO);

        IEnumerable<ProdutoDTO> MapperListProdutos(IEnumerable<Produto> clientes);

        ProdutoDTO MapperToDTO(Produto produto);
    }
}
