using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //generic constraint
    //class: referans tip
    //new(): new lenebilir olmalı
    public interface IEntityRepository<T> where T : class, IEntity, new()
    { /*T ya IEntity olabilir ya da IEntity den refere bir şey olabilir.*/
        /*IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olablir */
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
