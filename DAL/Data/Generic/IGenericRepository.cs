using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DAL.Data.Generic
{
    public interface IGenericRepository<T>
    {
        IQueryable<T> All { get; }
        IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);

        //From http://mto-library.googlecode.com/svn-history/r5/trunk/app/MTO.Framework.Data/Repository.cs
        T Single(Expression<Func<T, bool>> predicate);
        T SingleOrDefault(Expression<Func<T, bool>> predicate);
        T First(Expression<Func<T, bool>> predicate);
        T FirstOrDefault(Expression<Func<T, bool>> predicate);
        //Addition
        IQueryable<T> Except(IQueryable<T> excluded);
        //Addition
        int Count();
        int Count(Expression<Func<T, bool>> predicate);

        T Find(T entity);
         void Add(T entity);
        void Insert(T entity);
        void Update(T entity);
        void Edit(T entity);
        void Delete(T entity);
        void Save();

        //For the Async
        Task<IQueryable<T>> AllAsync();
    }
}
