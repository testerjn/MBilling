using MBilling.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class ProductTypeDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<ProductType> ProductTypeRepository;

        public ProductTypeDao()
        {
            ProductTypeRepository = unitOfWork.Repository<ProductType>();
        }

        public bool Validate(ProductType _ProductTypeDao, out List<string> lstMessages)
        {
            return ProductTypeRepository.Validate(_ProductTypeDao, out lstMessages);
        }

        public int Insert(ProductType _ProductTypeDao)
        {
            return ProductTypeRepository.Insert(_ProductTypeDao);
        }

        public int Update(ProductType _ProductTypeDao)
        {
            return ProductTypeRepository.Update(_ProductTypeDao);
        }

        public int Delete(ProductType _ProductTypeDao)
        {
            return ProductTypeRepository.Delete(_ProductTypeDao);
        }

        public async Task<ProductType> GetById(int _id)
        {
            return await ProductTypeRepository.GetById(_id);
        }

        public async Task<IEnumerable<ProductType>> GetAll()
        {
            return await ProductTypeRepository.GetAll();
        }

        public async Task<IEnumerable<ProductType>> FindBy(Expression<Func<ProductType, bool>> predicate)
        {
            return await ProductTypeRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<ProductType>> GetAllBy(Expression<Func<ProductType, bool>> filter = null, Func<IEnumerable<ProductType>, IOrderedEnumerable<ProductType>> orderBy = null)
        {
            return await ProductTypeRepository.GetAllBy(filter, orderBy);
        }

    }
}
