using MBilling.Core;
using MBilling.Core.Domain;
using MBilling.DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Business.Business
{
    public class CustomerDao
    {

        private PersonDao m_PersonDao = new PersonDao();
        public CustomerDao(PersonDao p_taxRateDao)
        {
            m_PersonDao = p_taxRateDao;
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            IEnumerable<Person> personEntityList = await m_PersonDao.GetAllBy(x => x.PersonTypeId == Core.PersonTypeEnum.Customer);
            IEnumerable<Customer> customerEntityList = personEntityList as IEnumerable<Customer>;
            return customerEntityList;
        }
    }
}
