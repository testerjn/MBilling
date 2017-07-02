using MBilling.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Common.ViewModels
{
    public class PersonAddressViewModel : ViewModel<PersonAddress>
    {

        private readonly PersonAddress m_PersonAddress;

        public PersonAddressViewModel(PersonAddress _PersonAddress)
            :base(_PersonAddress)
        {
            m_PersonAddress = _PersonAddress;
        }

        public int PersonAddressId
        {
            get { return m_PersonAddress.PersonAddressId; }
            set { m_PersonAddress.PersonAddressId = value; }
        }

        public int AddressId
        {
            get { return m_PersonAddress.AddressId; }
            set { m_PersonAddress.AddressId = value; }
        }

        public int PersonId
        {
            get { return m_PersonAddress.PersonId; }
            set { m_PersonAddress.PersonId = value; }
        }

        public AddressTypeEnum AddressTyIpeId
        {
            get { return m_PersonAddress.AddressTyIpeId; }
            set { m_PersonAddress.AddressTyIpeId = value; }
        }
    }
}
