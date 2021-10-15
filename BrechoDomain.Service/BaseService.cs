using BrechoDomainCore.Interfaces.Repository;
using BrechoDomainCore.Interfaces.Services;
using System.Collections.Generic;

namespace BrechoDomain.Service
{
    public abstract class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;

        

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }



        public void add(TEntity obj)
        {   
                _repository.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public void Update(TEntity obj)
        {   
                _repository.Update(obj);
        }
    }
}
