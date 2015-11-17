using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DAL.Data.Generic;

namespace DAL.Fake.Generic
{
    public class FakeGenericRepository<T> : IGenericRepository<T> where T : class
    {
        public List<T> MyList;

        public FakeGenericRepository(List<T> list)
        {
            MyList = list;
        }

        public IQueryable<T> All
        {
            get { return MyList.AsQueryable(); }
        }

        public IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            return MyList.AsQueryable();
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return MyList.Where(predicate.Compile()).AsEnumerable();
        }

        public T Single(Expression<Func<T, bool>> predicate)
        {
            return MyList.Where(predicate.Compile()).Single();
        }

        public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            return MyList.Where(predicate.Compile()).SingleOrDefault();
        }

        public T First(Expression<Func<T, bool>> predicate)
        {
            return MyList.Where(predicate.Compile()).First();
        }

        public T FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return MyList.Where(predicate.Compile()).FirstOrDefault();
        }
        //Addition
        public  IQueryable<T> Except(IQueryable<T> excluded)
        {
            return MyList.AsQueryable().Except( excluded).AsQueryable();
        }
        //Addition
        public int Count()
        {
            return MyList.Count();
        }

        public int Count(Expression<Func<T, bool>> predicate)
        {
            return MyList.Count(predicate.Compile());
        }

        public virtual T Find(T entity)
        {
            var index = MyList.IndexOf(entity);
            if (index == -1) return null;
            var item = MyList[index];
            return item;
        }

        public void Add(T entity)
        {
            MyList.Add(entity);
        }

        public void Insert(T entity)
        {
            MyList.Add(entity);
        }

        public void Edit(T entity)
        {
            var newentity = entity;
            MyList.Remove(entity);
            MyList.Add(newentity);
        }

        public void Update(T entity)
        {
            var newentity = entity;
            MyList.Remove(entity);
            MyList.Add(newentity);
        }

        public void Delete(T entity)
        {
            MyList.Remove(entity);
        }

        public void Save()
        {
           //Nothing
        }

        public void Dispose()
        {
            MyList = null;
        }


        //Async
        public Task<IQueryable<T>> AllAsync()
        {
            return Task<IQueryable<T>>.Factory.StartNew(() => MyList.AsQueryable());
        }
    }
}


//public IQueryable<T> All
//{
//    get { return _myDomains.AsQueryable(); }

//}

//public IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
//{
//    return _myDomains.AsQueryable();
//}

//public T Find(int id)
//{
//    return _myDomains.FirstOrDefault(x => x.Id == id);
//}

//public void InsertOrUpdate(T domain)
//{
//    if (domain.Id == 0)
//    {
//        _myDomains.Add(domain);
//    }
//    else
//    {
//        _myDomains.Remove(_myDomains.Find(x => x.Id == domain.Id));
//        _myDomains.Add(domain);
//    }
//}

//public void Delete(int id)
//{
//    _myDomains.Remove(_myDomains.Find(x => x.Id == id));
//}

//public void Save()
//{
//}

//public Task<IQueryable<T>> AllAsync()
//{
//    return Task<IQueryable<T>>.Factory.StartNew(() => _myDomains.AsQueryable());
//}

//public void Dispose()
//{
//    _myDomains = null;
//}

//IQueryable<T> query = All as DbQuery<T>;
//if (query == null)
//{
//    return All;
//}

//foreach (var includeProperty in predicate)
//{
//    query = query.Include(includeProperty);
//}
//return query;