using MBilling.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class AddressTypeDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<AddressType> AddressTypeDaoRepository;

        public AddressTypeDao()
        {
            AddressTypeDaoRepository = unitOfWork.Repository<AddressType>();
        }

        public bool Validate(AddressType _AddressType, out List<string> lstMessages)
        {
            return AddressTypeDaoRepository.Validate(_AddressType, out lstMessages);
        }

        public int Insert(AddressType _AddressType)
        {
            return AddressTypeDaoRepository.Insert(_AddressType);
        }

        public int Update(AddressType _AddressType)
        {
            return AddressTypeDaoRepository.Update(_AddressType);
        }

        public int Delete(AddressType _AddressType)
        {
            return AddressTypeDaoRepository.Delete(_AddressType);
        }

        public async Task<AddressType> GetById(int _id)
        {
            return await AddressTypeDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<AddressType>> GetAll()
        {
            return await AddressTypeDaoRepository.GetAll();
        }

        public async Task<IEnumerable<AddressType>> FindBy(Expression<Func<AddressType, bool>> predicate)
        {
            return await AddressTypeDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<AddressType>> GetAllBy(Expression<Func<AddressType, bool>> filter = null, Func<IEnumerable<AddressType>, IOrderedEnumerable<AddressType>> orderBy = null)
        {
            return await AddressTypeDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
