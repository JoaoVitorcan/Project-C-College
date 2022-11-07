using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Linq;

namespace JoãoBooks.DataAccess.Repository.IRepository
{
    interface IRepository<T> where T :class
    {
        T Get(int id);

        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null
            );

        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );

        void Add(T entify); // to add an entity
        void Remove(int id);  //to remove an object or category
        void Remove(T entity); //another way to remove an object
        void RemoveRange(IEnumerable<T> entity);  //removes a complete range of entities




    }
}
