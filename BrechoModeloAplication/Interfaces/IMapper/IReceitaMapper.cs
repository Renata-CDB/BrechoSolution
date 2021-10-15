using BrechoDomain.Entitys;
using BrechoModeloAplication.Dtos;
using System.Collections.Generic;

namespace BrechoModeloAplication.Interfaces.IMapper
{
    public interface IReceitaMapper
    {
        Receita MapperToEntity(ReceitaDTO receitaDTO);

        IEnumerable<ReceitaDTO> MapperListClientes(IEnumerable<Receita> receitas);

        ReceitaDTO MapperToDTO(Receita receita);
    }
}
