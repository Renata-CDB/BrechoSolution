using BrechoDomainCore.Interfaces.Services;
using BrechoModeloAplication.Dtos;
using BrechoModeloAplication.Interfaces;
using BrechoModeloAplication.Interfaces.Mapper;
using System.Collections.Generic;

namespace BrechoModeloAplication
{
    public class ClienteAplicationService : IClienteAplicationService
    {

        private readonly IClienteService _clienteService;
        private readonly IClienteMapper _clienteMapper;

        public ClienteAplicationService(IClienteService clienteService
                                        , IClienteMapper clienteMapper)
        {
            _clienteService = clienteService;
            _clienteMapper = clienteMapper;
        }



        public void Add(ClienteDTO clienteDTO)
        {
            var Cliente = _clienteMapper.MapperToEntity(clienteDTO);
            _clienteService.add(Cliente);
        }

        //public void Dispose()
        //{
            
        //}

        public IEnumerable<ClienteDTO> GetAll()
        {
            var clientes = _clienteService.GetAll();
            return _clienteMapper.MapperListClientes(clientes);
        }

        public ClienteDTO GetById(int id)
        {
            var cliente = _clienteService.GetById(id);
            return _clienteMapper.MapperToDTO(cliente);
        }

        public void Remove(ClienteDTO obj)
        {
            var objCliente = _clienteMapper.MapperToEntity(obj);
            _clienteService.Remove(objCliente);
        }

        public void Update(ClienteDTO obj)
        {
            var objCliente = _clienteMapper.MapperToEntity(obj);
            _clienteService.Update(objCliente);
        }
    }
}
