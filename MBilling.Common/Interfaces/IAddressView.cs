using MBilling.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Common.Interfaces
{
    public interface IAddressView : IView<AddressViewModel>
    {
        void ReadUserInput();
        void ShowStateProvince(IEnumerable<StateProvienceModel> lstStateData);
    }
}
