using Entities.Abstact;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // T nesnesi class ,IEntity'nin alt sınıfı ve new()'lenebilir olmalıdır.
    // IEntityRepository oluşturulacak fonksiyonları belirtir.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
