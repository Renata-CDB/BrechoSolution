using System.Collections.Generic;

namespace BrechoDomainCore.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        void add(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);

    }
}
