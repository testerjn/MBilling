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
        private Repository<ProductDao> ProductDaoDaoRepository;

        public ProductDao()
        {
            ProductDaoDaoRepository = unitOfWork.Repository<ProductDao>();
        }

        public bool Validate(ProductDao _ProductDao, out List<string> lstMessages)
        {
            return ProductDaoDaoRepository.Validate(_ProductDao, out lstMessages);
        }

        public int Insert(ProductDao _ProductDao)
        {
            return ProductDaoDaoRepository.Insert(_ProductDao);
        }

        public int Update(ProductDao _ProductDao)
        {
            return ProductDaoDaoRepository.Update(_ProductDao);
        }

        public int Delete(ProductDao _ProductDao)
        {
            return ProductDaoDaoRepository.Delete(_ProductDao);
        }

        public async Task<ProductDao> GetById(int _id)
        {
            return await ProductDaoDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<ProductDao>> GetAll()
        {
            return await ProductDaoDaoRepository.GetAll();
        }

        public async Task<IEnumerable<ProductDao>> FindBy(Expression<Func<ProductDao, bool>> predicate)
        {
            return await ProductDaoDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<ProductDao>> GetAllBy(Expression<Func<ProductDao, bool>> filter = null, Func<IEnumerable<ProductDao>, IOrderedEnumerable<ProductDao>> orderBy = null)
        {
            return await ProductDaoDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
