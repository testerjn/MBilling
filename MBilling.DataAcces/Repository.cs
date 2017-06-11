using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace MBilling.DataAcces
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private BillingDBContext _context;
        private IDbSet<TEntity> _entities;

        public Repository(BillingDBContext context)
        {
            this._context = context;
            this._entities = _context.Set<TEntity>();
        }

        public int Insert(TEntity entity)
        {
            int result = 0;
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this.Entities.Add(entity);
                this._context.SaveChanges();
                result = 1;
            }
            catch (DbEntityValidationException dbEx)
            {
                var msg = string.Empty;

                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        msg += string.Format("Property: {0} Error: {1}",
                        validationError.PropertyName, validationError.ErrorMessage) + Environment.NewLine;
                    }
                }

                var fail = new Exception(msg, dbEx);
                throw fail;
            }
            return result;
        }

        public int Update(TEntity entity)
        {
            int result = 0;
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this._context.SaveChanges();
                result = 1;
            }
            catch (DbEntityValidationException dbEx)
            {
                var msg = string.Empty;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        msg += Environment.NewLine + string.Format("Property: {0} Error: {1}",
                        validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
                var fail = new Exception(msg, dbEx);
                throw fail;
            }
            return result;
        }

        public int Delete(TEntity entity)
        {
            int result = 0;
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this.Entities.Remove(entity);
                this._context.SaveChanges();
                result = 1;
            }
            catch (DbEntityValidationException dbEx)
            {
                var msg = string.Empty;

                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        msg += Environment.NewLine + string.Format("Property: {0} Error: {1}",
                        validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
                var fail = new Exception(msg, dbEx);
                throw fail;
            }
            return result;
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<ICollection<TEntity>> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().Where(predicate).ToListAsync();
        }

        public async Task<ICollection<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<ICollection<TEntity>> GetAllBy(Expression<Func<TEntity, bool>> filter = null, Func<IEnumerable<TEntity>, IOrderedEnumerable<TEntity>> orderBy = null)
        {
            IQueryable<TEntity> query = _entities;

            if (filter != null)
                query = query.Where(filter);

            //if (orderBy != null)
            //    query = orderBy(query);

            return await query.ToListAsync();
        }

        public async Task<int> InsertAsync(TEntity entity)
        {
            int result = 0;
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this.Entities.Add(entity);
                result = await _context.SaveChangesAsync();
            }
            catch (DbEntityValidationException dbEx)
            {
                var msg = string.Empty;

                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        msg += string.Format("Property: {0} Error: {1}",
                        validationError.PropertyName, validationError.ErrorMessage) + Environment.NewLine;
                    }
                }

                var fail = new Exception(msg, dbEx);
                throw fail;
            }
            return result;
        }

        public async Task<int> UpdateAsync(TEntity entity)
        {
            int result = 0;
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                result = await _context.SaveChangesAsync();
            }
            catch (DbEntityValidationException dbEx)
            {
                var msg = string.Empty;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        msg += Environment.NewLine + string.Format("Property: {0} Error: {1}",
                        validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
                var fail = new Exception(msg, dbEx);
                throw fail;
            }
            return result;
        }

        public async Task<int> DeleteAsync(TEntity entity)
        {
            int result = 0;
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this.Entities.Remove(entity);
                result = await _context.SaveChangesAsync();
            }
            catch (DbEntityValidationException dbEx)
            {
                var msg = string.Empty;

                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        msg += Environment.NewLine + string.Format("Property: {0} Error: {1}",
                        validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
                var fail = new Exception(msg, dbEx);
                throw fail;
            }
            return result;
        }

        public ICollection<TEntity> FindBySync(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).ToList();
        }

        public bool Validate(TEntity entity, out List<string> lstMessages)
        {
            bool isValid = true;
            lstMessages = new List<string>();
            ValidationContext context = new ValidationContext(entity, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            isValid = Validator.TryValidateObject(entity, context, results, true);
            if (!isValid)
            {
                foreach (ValidationResult vr in results)
                {
                    lstMessages.Add(vr.ErrorMessage);
                }
            }
            return isValid;
        }

        private IDbSet<TEntity> Entities
        {
            get
            {
                if (_entities == null)
                {
                    this._entities = _context.Set<TEntity>();
                }
                return this._entities;
            }
        }
    }
}
