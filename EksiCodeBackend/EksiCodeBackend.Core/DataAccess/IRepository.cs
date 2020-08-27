using EksiCodeBackend.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EksiCodeBackend.Core.DataAccess
{
    public interface IRepository<T> where T : class, IBaseEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter = null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        void Insert(T entity);
        void Insert(List<T> entities);
        void Update(T entity);
        void Update(List<T> entities);
        void Delete(T entity);
        void Delete(List<T> entities);
        void DeleteHard(T entity);
    }
}
