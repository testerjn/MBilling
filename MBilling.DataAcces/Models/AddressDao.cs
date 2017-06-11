using MBilling.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class AddressDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<Address> AddressDaoRepository;

        public AddressDao()
        {
            AddressDaoRepository = unitOfWork.Repository<Address>();
        }

        public bool Validate(Address _Address, out List<string> lstMessages)
        {
            return AddressDaoRepository.Validate(_Address, out lstMessages);
        }

        public int Insert(Address _Address)
        {
            return AddressDaoRepository.Insert(_Address);
        }

        public int Update(Address _Address)
        {
            return AddressDaoRepository.Update(_Address);
        }

        public int Delete(Address _Address)
        {
            return AddressDaoRepository.Delete(_Address);
        }

        public async Task<Address> GetById(int _id)
        {
            return await AddressDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<Address>> GetAll()
        {
            return await AddressDaoRepository.GetAll();
        }

        public async Task<IEnumerable<Address>> FindBy(Expression<Func<Address, bool>> predicate)
        {
            return await AddressDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<Address>> GetAllBy(Expression<Func<Address, bool>> filter = null, Func<IEnumerable<Address>, IOrderedEnumerable<Address>> orderBy = null)
        {
            return await AddressDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
