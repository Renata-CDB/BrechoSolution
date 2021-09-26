using BrechoDomainCore.Interfaces.Services;
using BrechoModeloAplication.Dtos;
using BrechoModeloAplication.Interfaces;
using BrechoModeloAplication.Interfaces.Mapper;
using System.Collections.Generic;

namespace BrechoModeloAplication
{
    public class ClienteAplicationService : IClienteAplicationService
    {

        private readonly IClienteService clienteService;
        private readonly IClienteMapper clienteMapper;

        public ClienteAplicationService(IClienteService clienteService
                                        , IClienteMapper clienteMapper)
        {
            //clienteService = clienteService;
            //clienteMapper = clienteMapper;
        }



        public void Add(ClienteDTO clienteDTO)
        {
            var Cliente = clienteMapper.MapperToEntity(clienteDTO);
            clienteService.add(Cliente);
        }

        //public void Dispose()
        

        public IEnumerable<ClienteDTO> GetAll()
        {
            var clientes = clienteService.GetAll();
            return clienteMapper.MapperListClientes(clientes);
        }

        public ClienteDTO GetById(int id)
        {
            var cliente = clienteService.GetById(id);
            return clienteMapper.MapperToDTO(cliente);
        }

        public void Remove(ClienteDTO obj)
        {
            var objCliente = clienteMapper.MapperToEntity(obj);
            clienteService.Remove(objCliente);
        }

        public void Update(ClienteDTO obj)
        {
            var objCliente = clienteMapper.MapperToEntity(obj);
            clienteService.Update(objCliente);
        }
    }
}
