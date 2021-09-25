using BrechoModeloAplication.Dtos;
using System.Collections.Generic;

namespace BrechoModeloAplication.Interfaces
{
    public interface IClienteAplicationService
    {
        void Add(ClienteDTO obj);

        ClienteDTO GetById(int id);

        IEnumerable<ClienteDTO> GetAll();

        void Update(ClienteDTO obj);

        void Remove(ClienteDTO obj);

        //void Dispose();

    }
}
