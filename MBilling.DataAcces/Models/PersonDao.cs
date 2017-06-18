using MBilling.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class PersonDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<Person> PersonDaoRepository;

        public PersonDao()
        {
            PersonDaoRepository = unitOfWork.Repository<Person>();
        }

        public bool Validate(Person _Person, out List<string> lstMessages)
        {
            return PersonDaoRepository.Validate(_Person, out lstMessages);
        }

        public int Insert(Person _Person)
        {
            return PersonDaoRepository.Insert(_Person);
        }

        public int Update(Person _Person)
        {
            return PersonDaoRepository.Update(_Person);
        }

        public int Delete(Person _Person)
        {
            return PersonDaoRepository.Delete(_Person);
        }

        public async Task<Person> GetById(int _id)
        {
            return await PersonDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            return await PersonDaoRepository.GetAll();
        }

        public async Task<IEnumerable<Person>> FindBy(Expression<Func<Person, bool>> predicate)
        {
            return await PersonDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<Person>> GetAllBy(Expression<Func<Person, bool>> filter = null, Func<IEnumerable<Person>, IOrderedEnumerable<Person>> orderBy = null)
        {
            return await PersonDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
