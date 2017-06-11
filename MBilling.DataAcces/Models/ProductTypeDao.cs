using MBilling.Core.Data;
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
        private Repository<ProductTypeDao> ProductTypeDaoDaoRepository;

        public ProductTypeDao()
        {
            ProductTypeDaoDaoRepository = unitOfWork.Repository<ProductTypeDao>();
        }

        public bool Validate(ProductTypeDao _ProductTypeDao, out List<string> lstMessages)
        {
            return ProductTypeDaoDaoRepository.Validate(_ProductTypeDao, out lstMessages);
        }

        public int Insert(ProductTypeDao _ProductTypeDao)
        {
            return ProductTypeDaoDaoRepository.Insert(_ProductTypeDao);
        }

        public int Update(ProductTypeDao _ProductTypeDao)
        {
            return ProductTypeDaoDaoRepository.Update(_ProductTypeDao);
        }

        public int Delete(ProductTypeDao _ProductTypeDao)
        {
            return ProductTypeDaoDaoRepository.Delete(_ProductTypeDao);
        }

        public async Task<ProductTypeDao> GetById(int _id)
        {
            return await ProductTypeDaoDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<ProductTypeDao>> GetAll()
        {
            return await ProductTypeDaoDaoRepository.GetAll();
        }

        public async Task<IEnumerable<ProductTypeDao>> FindBy(Expression<Func<ProductTypeDao, bool>> predicate)
        {
            return await ProductTypeDaoDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<ProductTypeDao>> GetAllBy(Expression<Func<ProductTypeDao, bool>> filter = null, Func<IEnumerable<ProductTypeDao>, IOrderedEnumerable<ProductTypeDao>> orderBy = null)
        {
            return await ProductTypeDaoDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
