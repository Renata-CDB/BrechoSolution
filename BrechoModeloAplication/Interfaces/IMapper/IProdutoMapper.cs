using BrechoDomain.Entitys;
using BrechoModeloAplication.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrechoModeloAplication.Interfaces.Mapper
{
    public interface IProdutoMapper
    {
        Produto MapperToEntity(ProdutoDTO produtoDTO);

        IEnumerable<ProdutoDTO> MapperListProdutos(IEnumerable<Produto> clientes);

        ProdutoDTO MapperToDTO(Produto produto);
    }
}
