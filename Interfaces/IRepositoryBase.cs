using System.Linq.Expressions;

namespace VM_Server.Interfaces
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> GetAll(bool trackChanges);
        IQueryable<T> GetThroughStatement(Expression<Func<T, bool>> exp, bool trackChanges);
    }
}
