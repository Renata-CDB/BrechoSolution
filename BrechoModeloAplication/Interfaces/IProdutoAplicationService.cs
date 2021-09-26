using BrechoModeloAplication.Dtos;
using System.Collections.Generic;

namespace BrechoModeloAplication.Interfaces
{
    public interface IProdutoAplicationService
    {
        void Add(ProdutoDTO obj);

        ProdutoDTO GetById(int id);

        IEnumerable<ProdutoDTO> GetAll();

        void Update(ProdutoDTO obj);

        void Remove(ProdutoDTO obj);

        //void Dispose();
    }
}
