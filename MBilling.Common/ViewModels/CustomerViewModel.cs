using MBilling.Core;
using MBilling.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Common.ViewModels
{
    public class CustomerViewModel : ViewModel<Customer>
    {
        private readonly Customer m_CustomerData;

        public CustomerViewModel(Customer _Customer)
            : base(_Customer)
        {
            m_CustomerData = _Customer;
        }

        public int PersonId
        {
            get { return m_CustomerData.PersonId; }
            set { m_CustomerData.PersonId = value; }
        }


        [Display(Name = "Customer Name")]
        [Column(name: "Name")]
        [Required(ErrorMessage = "Customer Name is required")]
        public string Name
        {
            get { return m_CustomerData.Name; }
            set { m_CustomerData.Name = value; }
        }

        public ICollection<PersonAddress> PersonAddresses
        {
            get
            {
                return m_CustomerData.PersonAddresses;
            }
            set { m_CustomerData.PersonAddresses = value; }
        }

        public Customer CustomerData { get { return m_CustomerData; } }

    }
}
