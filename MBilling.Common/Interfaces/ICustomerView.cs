using MBilling.Common.ViewModels;
using MBilling.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Common.Interfaces
{
    public interface ICustomerView : IView<CustomerViewModel>
    {
        void PopulateAddressType(List<string> lstAddressTypeEnumData);
        void ReadUserInput();
        void ShowAddress(IEnumerable<AddressViewModel> lstAddressData);
    }
}
