using MBilling.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class PersonTaxDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<PersonTaxDao> PersonTaxDaoDaoRepository;

        public PersonTaxDao()
        {
            PersonTaxDaoDaoRepository = unitOfWork.Repository<PersonTaxDao>();
        }

        public bool Validate(PersonTaxDao _PersonTaxDao, out List<string> lstMessages)
        {
            return PersonTaxDaoDaoRepository.Validate(_PersonTaxDao, out lstMessages);
        }

        public int Insert(PersonTaxDao _PersonTaxDao)
        {
            return PersonTaxDaoDaoRepository.Insert(_PersonTaxDao);
        }

        public int Update(PersonTaxDao _PersonTaxDao)
        {
            return PersonTaxDaoDaoRepository.Update(_PersonTaxDao);
        }

        public int Delete(PersonTaxDao _PersonTaxDao)
        {
            return PersonTaxDaoDaoRepository.Delete(_PersonTaxDao);
        }

        public async Task<PersonTaxDao> GetById(int _id)
        {
            return await PersonTaxDaoDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<PersonTaxDao>> GetAll()
        {
            return await PersonTaxDaoDaoRepository.GetAll();
        }

        public async Task<IEnumerable<PersonTaxDao>> FindBy(Expression<Func<PersonTaxDao, bool>> predicate)
        {
            return await PersonTaxDaoDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<PersonTaxDao>> GetAllBy(Expression<Func<PersonTaxDao, bool>> filter = null, Func<IEnumerable<PersonTaxDao>, IOrderedEnumerable<PersonTaxDao>> orderBy = null)
        {
            return await PersonTaxDaoDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
