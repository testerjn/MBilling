using MBilling.Common.ViewModels;
using MBilling.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Common.Interfaces
{
    public interface ITaxRateView : IView<TaxRateViewModel>
    {
        void ReadUserInput();
        void ShowStateProvince(IEnumerable<StateProvienceModel> lstStateData);
        //void Close();

    }
}
