using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MBilling.DataAcces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        bool Validate(TEntity entity,out List<string> lstMessages);
        Task<TEntity> GetById(int id);
        Task<ICollection<TEntity>> FindBy(Expression<Func<TEntity, bool>> predicate);
        int Insert(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);
        ICollection<TEntity> FindBySync(Expression<Func<TEntity, bool>> predicate);
        Task<int> InsertAsync(TEntity entity);
        Task<int> UpdateAsync(TEntity entity);
        Task<int> DeleteAsync(TEntity entity);
        Task<ICollection<TEntity>> GetAll();
        Task<ICollection<TEntity>> GetAllBy(Expression<Func<TEntity, bool>> filter = null, Func<IEnumerable<TEntity>, IOrderedEnumerable<TEntity>> orderBy = null);
    }
}
