using MBilling.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Common.Interfaces
{
    public interface ITaxRateView : IView<TaxRateViewModel>
    {
        //void ShowAllTaxRate(IEnumerable<TaxRateViewModel> taxRateViewModelList);
        //void ShowTaxRate(TaxRateViewModel taxRateViewModel);
        //void ShowError(string message);
        //void SearchTaxRate(TaxRateViewModel taxRateViewModel);
        void ReadUserInput();
        void ShowStateProvince(Dictionary<int,string> lstStateData);
        //void Close();

    }
}
