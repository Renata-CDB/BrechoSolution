using BrechoDomain.Entitys;
using BrechoModeloAplication.Dtos;
using System.Collections.Generic;

namespace BrechoModelo.Infrastructure.CrossCutting.Interfaces
{
    public interface IClienteMapper
    {
        Cliente MapperToEntity(ClienteDTO clienteDTO);

        IEnumerable<ClienteDTO> MapperListClientes(IEnumerable<Cliente> clientes);

        ClienteDTO MapperToDTO(Cliente Cliente);

    }
}
