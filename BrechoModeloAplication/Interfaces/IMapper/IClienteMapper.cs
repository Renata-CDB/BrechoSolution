using BrechoDomain.Entitys;
using BrechoModeloAplication.Dtos;
using System.Collections.Generic;

namespace BrechoModeloAplication.Interfaces.Mapper
{
    public interface IClienteMapper
    {   
        Cliente MapperToEntity(ClienteDTO clienteDTO);

        IEnumerable<ClienteDTO> MapperListClientes(IEnumerable<Cliente> clientes);

        ClienteDTO MapperToDTO(Cliente Cliente);
    }
}
