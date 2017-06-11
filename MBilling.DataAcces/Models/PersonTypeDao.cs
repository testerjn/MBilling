using MBilling.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class PersonTypeDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<PersonTypeDao> PersonTypeDaoDaoRepository;

        public PersonTypeDao()
        {
            PersonTypeDaoDaoRepository = unitOfWork.Repository<PersonTypeDao>();
        }

        public bool Validate(PersonTypeDao _PersonTypeDao, out List<string> lstMessages)
        {
            return PersonTypeDaoDaoRepository.Validate(_PersonTypeDao, out lstMessages);
        }

        public int Insert(PersonTypeDao _PersonTypeDao)
        {
            return PersonTypeDaoDaoRepository.Insert(_PersonTypeDao);
        }

        public int Update(PersonTypeDao _PersonTypeDao)
        {
            return PersonTypeDaoDaoRepository.Update(_PersonTypeDao);
        }

        public int Delete(PersonTypeDao _PersonTypeDao)
        {
            return PersonTypeDaoDaoRepository.Delete(_PersonTypeDao);
        }

        public async Task<PersonTypeDao> GetById(int _id)
        {
            return await PersonTypeDaoDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<PersonTypeDao>> GetAll()
        {
            return await PersonTypeDaoDaoRepository.GetAll();
        }

        public async Task<IEnumerable<PersonTypeDao>> FindBy(Expression<Func<PersonTypeDao, bool>> predicate)
        {
            return await PersonTypeDaoDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<PersonTypeDao>> GetAllBy(Expression<Func<PersonTypeDao, bool>> filter = null, Func<IEnumerable<PersonTypeDao>, IOrderedEnumerable<PersonTypeDao>> orderBy = null)
        {
            return await PersonTypeDaoDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
