using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VM_Server.Interfaces;

namespace VM_Server.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext repositoryContext;
        public RepositoryBase(RepositoryContext context) => this.repositoryContext = context;

        public IQueryable<T> GetAll(bool trackChanges) => !trackChanges ? repositoryContext.Set<T>().AsNoTracking() : repositoryContext.Set<T>();

        public IQueryable<T> GetThroughStatement(Expression<Func<T, bool>> exp, bool trackChanges) => !trackChanges ? repositoryContext.Set<T>().Where(exp).AsNoTracking() : repositoryContext.Set<T>().Where(exp);
  
    }
}
