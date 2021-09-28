
using BrechoDomainCore.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BrechoModelo.Infrastructure.Data.Repositorys
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly SqlContext _sqlContext;

        public BaseRepository(SqlContext sqlContext) 
        {
            _sqlContext = sqlContext;
        }

        public void Add(TEntity obj)
        {
            try
            {
                _sqlContext.Set<TEntity>().Add(obj);
                _sqlContext.SaveChanges();
            }
            catch (System.Exception )
            {

                throw;
            }
        }

        public void Remove(TEntity obj)
        {
            try
            {
                _sqlContext.Set<TEntity>().Remove(obj);
                _sqlContext.SaveChanges();
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _sqlContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _sqlContext.Set<TEntity>().Find(id);
        }

        public void Update(TEntity obj)
        {
            try
            {
                _sqlContext.Entry(obj).State = EntityState.Modified;
                _sqlContext.SaveChanges();

            }
            catch (System.Exception )
            {

                throw;
            }
        }

        
    }
}
