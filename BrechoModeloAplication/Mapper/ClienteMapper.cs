using BrechoDomain.Entitys;
using BrechoModeloAplication.Dtos;
using BrechoModeloAplication.Interfaces.Mapper;
using System.Collections.Generic;

namespace BrechoModeloAplication.Mapper
{
    public class ClienteMapper : IClienteMapper
    {
        List<ClienteDTO> clienteDTOs = new List<ClienteDTO>();



        public Cliente MapperToEntity(ClienteDTO clienteDTO)
        {
            Cliente cliente = new Cliente
            {
                Id = clienteDTO.Id
                ,
                Nome = clienteDTO.Nome
                ,
                Sobrenome = clienteDTO.Sobrenome
                ,
                Email = clienteDTO.Email
            };

            return cliente;

        }


        public IEnumerable<ClienteDTO> MapperListClientes(IEnumerable<Cliente> clientes)
        {
            foreach (var item in clientes)
            {


                ClienteDTO clienteDTO = new ClienteDTO
                {
                    Id = (int)item.Id
                   ,
                    Nome = item.Nome
                   ,
                    Sobrenome = item.Sobrenome
                   ,
                    Email = item.Email
                };



                clienteDTOs.Add(clienteDTO);

            }

            return clienteDTOs;
        }

        public ClienteDTO MapperToDTO(Cliente Cliente)
        {

            ClienteDTO clienteDTO = new ClienteDTO
            {
                Id = (int)Cliente.Id
                ,
                Nome = Cliente.Nome
                ,
                Sobrenome = Cliente.Sobrenome
                ,
                Email = Cliente.Email
            };

            return clienteDTO;

        }



    }
}

