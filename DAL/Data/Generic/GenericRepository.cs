using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Model;

namespace DAL.Data.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbContext _context;
        public DbSet<T> Dbset { get; private set; }

        public GenericRepository()
        {
            _context = new PrivateChefContext();
            Dbset = _context.Set<T>();
        }

        public GenericRepository(DbContext context)
        {
            _context = context;
            Dbset = context.Set<T>();
        }

        public IQueryable<T> All
        {
            get { return Dbset.AsQueryable(); }
        }

        public IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            var query = includeProperties.Aggregate<Expression<Func<T, object>>, IQueryable<T>>(Dbset, (current, includeProperty) => current.Include(includeProperty));
            return query;
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            var query = Dbset.Where(predicate).AsEnumerable();
            return query;
        }

        public T Single(Expression<Func<T, bool>> predicate)
        {
            return Dbset.Single<T>(predicate);
        }
        public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            return Dbset.SingleOrDefault<T>(predicate);
        }

        public T First(Expression<Func<T, bool>> predicate)
        {
            return Dbset.First(predicate);
        }
        public T FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return Dbset.FirstOrDefault(predicate);
        }
        public int Count()
        {
            return Dbset.Count();
        }
        public int Count(Expression<Func<T, bool>> predicate)
        {
            return Dbset.Count(predicate);
        }
        public IQueryable<T> Except(IQueryable<T> excluded)
        {
           return All.Except(excluded);
        }
        public T Find(T entity)
        {
            return Dbset.Find(entity);
        }

        public void Add(T entity)
        {
            Dbset.Add(entity);
            Save();
        }

        public void Insert(T entity)
        {
            Dbset.Add(entity);
            Save();
        }

        public void Update(T entity)
        {
            Dbset.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            Save();
        }

        public void Edit(T entity)
        {
            Dbset.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            Save();
        }

        public void Delete(T entity)
        {
            Dbset.Remove(entity);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }


        //Async
        public Task<IQueryable<T>> AllAsync()
        {
            return Task<IQueryable<T>>.Factory.StartNew(() => Dbset.AsQueryable());
        }

    }
}
