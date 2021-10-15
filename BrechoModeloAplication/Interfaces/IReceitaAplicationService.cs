using BrechoModeloAplication.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrechoModeloAplication.Interfaces
{
    public interface IReceitaplicationService
    {
        void Add(ReceitaDTO obj);

        ReceitaDTO GetById(int id);

        IEnumerable<ReceitaDTO> GetAll();

        void Remove(ReceitaDTO obj);

        //void Dispose();
    }
}
