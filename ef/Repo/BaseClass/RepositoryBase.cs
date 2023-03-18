using System.Linq.Expressions;
using EF.Context;
using Microsoft.EntityFrameworkCore;


namespace EF.Repos
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private bool disposed = false;
        protected InMemoryContext Context { get; set; }

        public RepositoryBase(InMemoryContext context)
        {
            Context = context;
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return Context.Set<T>().Where(expression).AsNoTracking();
        }

        public T Get(long id)
        {
            return Context.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return Context.Set<T>().AsNoTracking();
        }

        public void Insert(T entity) => Context.Set<T>().Add(entity);

        public void Update(T entity) => Context.Set<T>().Update(entity);


        public void Delete(int id)
        {
            var entity = Context.Set<T>().Find(id);
            if (entity != null)
            {
                Context.Remove(entity);
            }
        }

        public void Delete(T entyty) => Context.Set<T>().Remove(entyty);

        public void DeleteAll()
        {
            foreach (var entity in Context.Set<T>())
            {
                Delete(entity);
            }
        }

        public long Count()
        {
            var count = Context.Set<T>().Count();
            return count;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
