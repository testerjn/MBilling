using MBilling.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class ProductDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<Product> ProductRepository;

        public ProductDao()
        {
            ProductRepository = unitOfWork.Repository<Product>();
        }

        public bool Validate(Product _ProductDao, out List<string> lstMessages)
        {
            return ProductRepository.Validate(_ProductDao, out lstMessages);
        }

        public int Insert(Product _ProductDao)
        {
            return ProductRepository.Insert(_ProductDao);
        }

        public int Update(Product _ProductDao)
        {
            return ProductRepository.Update(_ProductDao);
        }

        public int Delete(Product _ProductDao)
        {
            return ProductRepository.Delete(_ProductDao);
        }

        public async Task<Product> GetById(int _id)
        {
            return await ProductRepository.GetById(_id);
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await ProductRepository.GetAll();
        }

        public async Task<IEnumerable<Product>> FindBy(Expression<Func<Product, bool>> predicate)
        {
            return await ProductRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<Product>> GetAllBy(Expression<Func<Product, bool>> filter = null, Func<IEnumerable<Product>, IOrderedEnumerable<Product>> orderBy = null)
        {
            return await ProductRepository.GetAllBy(filter, orderBy);
        }

    }
}
