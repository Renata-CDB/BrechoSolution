using BrechoDomainCore.Interfaces.Services;
using BrechoModeloAplication.Dtos;
using BrechoModeloAplication.Interfaces;
using System;
using System.Collections.Generic;

namespace BrechoModeloAplication
{
    public class ClienteAplicationServicecs : IClienteAplicationService
    {


        //private readonly IClienteService _ClienteService;
        //private readonly IClienteMapper _ClienteMapper;

        //public ClienteAplicationService(IClienteAplicationService ClienteService
        //                                         , IClienteMapper ClienteMapper)

        //{
        //    _ClienteService = ClienteService;
        //    _ClienteMapper = ClienteMapper;
        //}


        //public void Add(ClienteDTO obj)
        //{
        //    var objCliente = _ClienteMapper.MapperToEntity(obj);
        //    _ClienteService.Add(objCliente);
        //}



        //public void Dispose()
        //{
        //    _ClienteService.Dispose();
        //}

        //public IEnumerable<ClienteDTO> GetAll()
        //{
        //    var objProdutos = _ClienteService.GetAll();
        //    return _ClienteService.(objProdutos);
        //}

        //public ClienteDTO GetById(int id)
        //{
        //    var objcliente = _ClienteService.GetById(id);
        //    return _ClienteMapper.MapperToDTO(objcliente);
        //}

        //public void Remove(ClienteDTO obj)
        //{
        //    var objCliente = _ClienteMapper.MapperToEntity(obj);
        //    _ClienteService.Remove(objCliente);
        //}



        //public void Update(ClienteDTO obj)
        //{
        //    var objCliente = _ClienteMapper.MapperToEntity(obj);
        //    this.Update(objCliente);
        //}
        public void Add(ClienteDTO obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public ClienteDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ClienteDTO obj)
        {
            throw new NotImplementedException();
        }

        public void Update(ClienteDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
