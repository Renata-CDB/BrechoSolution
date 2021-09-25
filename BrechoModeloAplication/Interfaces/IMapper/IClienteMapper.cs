using BrechoDomain.Entitys;
using BrechoModeloAplication.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrechoModeloAplication.Interfaces.Mapper
{
    public interface IClienteMapper 
    {
        Cliente MapperToEntity(ClienteDTO clienteDTO);

        IEnumerable<ClienteDTO> MapperListClientes(IEnumerable<Cliente> clientes);

        ClienteDTO MapperToDTO(Cliente Cliente);
    }
}
