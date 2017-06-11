using MBilling.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class PersonAddressDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<PersonAddressDao> PersonAddressDaoDaoRepository;

        public PersonAddressDao()
        {
            PersonAddressDaoDaoRepository = unitOfWork.Repository<PersonAddressDao>();
        }

        public bool Validate(PersonAddressDao _PersonAddressDao, out List<string> lstMessages)
        {
            return PersonAddressDaoDaoRepository.Validate(_PersonAddressDao, out lstMessages);
        }

        public int Insert(PersonAddressDao _PersonAddressDao)
        {
            return PersonAddressDaoDaoRepository.Insert(_PersonAddressDao);
        }

        public int Update(PersonAddressDao _PersonAddressDao)
        {
            return PersonAddressDaoDaoRepository.Update(_PersonAddressDao);
        }

        public int Delete(PersonAddressDao _PersonAddressDao)
        {
            return PersonAddressDaoDaoRepository.Delete(_PersonAddressDao);
        }

        public async Task<PersonAddressDao> GetById(int _id)
        {
            return await PersonAddressDaoDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<PersonAddressDao>> GetAll()
        {
            return await PersonAddressDaoDaoRepository.GetAll();
        }

        public async Task<IEnumerable<PersonAddressDao>> FindBy(Expression<Func<PersonAddressDao, bool>> predicate)
        {
            return await PersonAddressDaoDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<PersonAddressDao>> GetAllBy(Expression<Func<PersonAddressDao, bool>> filter = null, Func<IEnumerable<PersonAddressDao>, IOrderedEnumerable<PersonAddressDao>> orderBy = null)
        {
            return await PersonAddressDaoDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
