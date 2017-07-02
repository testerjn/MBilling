using MBilling.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Common.ViewModels
{
    public class AddressViewModel : ViewModel<Address>
    {
        private readonly Address m_AddressData;

        public AddressViewModel(Address _Address)
            : base(_Address)
        {
            m_AddressData = _Address;
        }

        public int AddressID
        {
            get { return m_AddressData.AddressID; }
            set { m_AddressData.AddressID = value; }
        }

        public string Address1
        {
            get { return m_AddressData.Address1; }
            set { m_AddressData.Address1 = value; }
        }

        public string Address2
        {
            get { return m_AddressData.Address2; }
            set { m_AddressData.Address2 = value; }
        }

        public string Address3
        {
            get { return m_AddressData.Address3; }
            set { m_AddressData.Address3 = value; }
        }

        public int StateId
        {
            get { return m_AddressData.StateId; }
            set { m_AddressData.StateId = value; }
        }

        public string Town
        {
            get { return m_AddressData.Town; }
            set { m_AddressData.Town = value; }
        }

        public string PostalCode
        {
            get { return m_AddressData.PostalCode; }
            set { m_AddressData.PostalCode = value; }
        }

        public bool? IsActive
        {
            get { return m_AddressData.IsActive; }
            set { m_AddressData.IsActive = value; }
        }

        public int CreatedByUserId
        {
            get { return m_AddressData.CreatedByUserId; }
            set { m_AddressData.CreatedByUserId = value; }
        }

        public int ModifiedByUserId
        {
            get { return m_AddressData.ModifiedByUserId; }
            set { m_AddressData.ModifiedByUserId = value; }
        }

        public DateTime? ModifiedOn
        {
            get { return m_AddressData.ModifiedOn; }
            set { m_AddressData.ModifiedOn = value; }
        }
    }
}
