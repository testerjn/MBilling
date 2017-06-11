using MBilling.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class PersonContactDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<PersonContactDao> PersonContactDaoDaoRepository;

        public PersonContactDao()
        {
            PersonContactDaoDaoRepository = unitOfWork.Repository<PersonContactDao>();
        }

        public bool Validate(PersonContactDao _PersonContactDao, out List<string> lstMessages)
        {
            return PersonContactDaoDaoRepository.Validate(_PersonContactDao, out lstMessages);
        }

        public int Insert(PersonContactDao _PersonContactDao)
        {
            return PersonContactDaoDaoRepository.Insert(_PersonContactDao);
        }

        public int Update(PersonContactDao _PersonContactDao)
        {
            return PersonContactDaoDaoRepository.Update(_PersonContactDao);
        }

        public int Delete(PersonContactDao _PersonContactDao)
        {
            return PersonContactDaoDaoRepository.Delete(_PersonContactDao);
        }

        public async Task<PersonContactDao> GetById(int _id)
        {
            return await PersonContactDaoDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<PersonContactDao>> GetAll()
        {
            return await PersonContactDaoDaoRepository.GetAll();
        }

        public async Task<IEnumerable<PersonContactDao>> FindBy(Expression<Func<PersonContactDao, bool>> predicate)
        {
            return await PersonContactDaoDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<PersonContactDao>> GetAllBy(Expression<Func<PersonContactDao, bool>> filter = null, Func<IEnumerable<PersonContactDao>, IOrderedEnumerable<PersonContactDao>> orderBy = null)
        {
            return await PersonContactDaoDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
