using System.Collections.Generic;

namespace BrechoDomainCore.Interfaces.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity obj);

        void Delete(TEntity obj);

        void Dispose();
    }
}
