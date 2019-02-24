using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using SyZero.Domain.Interface;
using SyZero.Domain.Model;

namespace SyZero.Infrastructure.Repository
{
    public class MongoRepositoryBase<T> : IBaseRepository<T> where T : EntityRoot
    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void AddAll(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAllByPage<TKey>(Expression<Func<T, TKey>> orderByLambda, out int count, int page, int size, bool isAsc = true)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAllLazy()
        {
            throw new NotImplementedException();
        }

        public T GetById(long Id)
        {
            throw new NotImplementedException();
        }

        public T GetById(string Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetManyByPage<TKey>(Expression<Func<T, bool>> where, Expression<Func<T, TKey>> orderByLambda, out int count, int page, int size, bool isAsc = true)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }
    }
}
